using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;

namespace Metapsi.WebComponentGenerator;

public class CSharpComponent
{
    public string ClassName { get; set; }
    public string BaseClassName { get; set; }
    public string HtmlTag { get; set; }

    public string ServerSideConstructorName { get; set; } = "Tag";
    public string ClientSideConstructorName { get; set; } = "H";

    public List<CSharpPropertySetter> AttributeSetters { get; set; } = new();
    public List<CSharpPropertySetter> PropertySetters { get; set; } = new();

    public string DefaultSlotComment { get; set; } = string.Empty;
    public List<string> Comments { get; set; } = new();
    public List<CSharpSlot> Slots { get; set; } = new();
    public List<CSharpMethod> Methods { get; set; } = new();
    public List<CSharpEvent> Events { get; set; } = new();
    public List<NotAnonymousAnymoreEventType> EventTypes { get; set; } = new();
    public List<NotAnonymousAnymorePropertyType> PropertyTypes { get; set; } = new();
}

public class CSharpMethod
{
    public string CSharpName { get; set; }
    public string OriginalName { get; set; }
    public List<string> Comments { get; set; } = new(); // Multiple paragraphs
}

public class CSharpSlot
{
    public string CSharpName { get; set; }
    public string OriginalName { get; set; }
    public List<string> Comments { get; set; } = new(); // Multiple paragraphs
}

public class CSharpEvent
{
    public string CSharpName { get; set; }
    public string OriginalName { get; set; }
    public string TypeName { get; set; }
    public List<string> DetailPath { get; set; } = new List<string>() { "detail" };
    public List<string> Comments { get; set; } = new();
}

public class NotAnonymousAnymoreEventType
{
    public string CSharpName { get; set; }
    public List<CSharpEventProperty> EventProperties { get; set; } = new();
    public List<string> Comments { get; set; } = new();
}

public class NotAnonymousAnymorePropertyType
{
    public string CSharpName { get; set; }
    public List<CSharpPropertySetter> Setters { get; set; } = new();
}

public class CSharpEventProperty
{
    public string PropertyType { get; set; }
    public string PropertyName { get; set; }
}

/// <summary>
/// Setters could appear multiple times with slight variations
/// For example
/// * setter without parameters for a boolean value
/// * setters with multiple parameters for an object property
/// </summary>
public class CSharpPropertySetter
{
    public string SetterName { get; set; }
    public string CSharpType { get; set; }
    public string ClientSidePropertyName { get; set; }
    public List<CSharpPropertySetterParameter> Parameters { get; set; } = new();
    public string DefaultValue { get; set; } = string.Empty;
    public List<string> Comments { get; set; } = new(); // Multiple paragraphs
    public bool GenerateConst { get; set; } = true;
}

public class CSharpPropertySetterParameter
{
    public string ParameterName { get; set; } = "value";
    public string CSharpType { get; set; }
}

public static class CSharpGeneratorExtensions
{
    public static CSharpComponent ToCSharpComponent(
        this WebComponent webComponent,
        CSharpConverter cSharpConverter)
    {
        CSharpComponent output = new CSharpComponent()
        {
            ClassName = webComponent.Name,
            HtmlTag = webComponent.Tag
        };


        var defaultSlot = webComponent.Slots.SingleOrDefault(x => string.IsNullOrWhiteSpace(x.Name));

        if (defaultSlot != null)
        {
            output.DefaultSlotComment = Utils.ReplaceAngleBrackets(defaultSlot.Comment);
        }
        foreach (var slot in webComponent.Slots.Where(x => x != defaultSlot))
        {
            var csSlot = new CSharpSlot()
            {
                OriginalName = slot.Name,
                CSharpName = Utils.ToCSharpValidName(slot.Name),
            };
            csSlot.Comments.Add(Utils.ReplaceAngleBrackets(slot.Comment));

            output.Slots.Add(csSlot);
        }

        foreach (var method in webComponent.Methods)
        {
            var csMethod = new CSharpMethod()
            {
                CSharpName = Utils.ToCSharpValidName(method.Name),
                OriginalName = method.Name,
            };

            csMethod.Comments.Add(Utils.ReplaceAngleBrackets(method.Comment));
            if (!string.IsNullOrWhiteSpace(method.Signature))
            {
                csMethod.Comments.Add(Utils.ReplaceAngleBrackets(method.Signature));
            }
            foreach (var parameter in method.Parameters)
            {
                csMethod.Comments.Add($"{parameter.Name} {parameter.Comment}");
            }
            output.Methods.Add(csMethod);
        }

        foreach (var property in webComponent.Properties.Where(x => !string.IsNullOrEmpty(x.AttributeName)))
        {
            // !!!!!!!
            // !!!!!!!
            // TODO: To server side property setters, bool gets magically transformed to string

            var csharpType = cSharpConverter.ToCSharpType(property.TypeScriptType, cSharpConverter);

            if (csharpType == "bool")
            {
                // Add twice, with default 'true' if not set

                var withDefaultTrue = new CSharpPropertySetter()
                {
                    SetterName = $"Set{Utils.ToCSharpValidName(property.AttributeName)}",
                    CSharpType = "bool",
                    ClientSidePropertyName = property.AttributeName,
                };
                withDefaultTrue.Comments.Add(property.Description);

                output.AttributeSetters.Add(withDefaultTrue);

                var withParameter = new CSharpPropertySetter()
                {
                    SetterName = $"Set{Utils.ToCSharpValidName(property.AttributeName)}",
                    CSharpType = "bool",
                    ClientSidePropertyName = property.AttributeName,
                };
                withParameter.Parameters.Add(new CSharpPropertySetterParameter()
                {
                    CSharpType = "bool",
                    ParameterName = property.AttributeName.ToParameterName(),
                });
                withParameter.Comments.Add(property.Description);

                output.AttributeSetters.Add(withParameter);
            }
            else
            {
                //var csharpType = cSharpConverter.ToCSharpType(property.TypeScriptType, cSharpConverter);

                var csProp = new CSharpPropertySetter()
                {
                    SetterName = $"Set{Utils.ToCSharpValidName(property.AttributeName)}",
                    CSharpType = "string",
                    ClientSidePropertyName = property.AttributeName,
                };

                csProp.Parameters.Add(new CSharpPropertySetterParameter()
                {
                    CSharpType = "string",
                    ParameterName = Utils.ToCSharpValidName(property.AttributeName).ToParameterName()
                });

                csProp.Comments.Add(property.Description);

                output.AttributeSetters.Add(csProp);

                if (Generator.IsMultiTypeUnion(property.TypeScriptType))
                {
                    TypeScriptUnion typeScriptUnion = (property.TypeScriptType as TypeScriptUnion);

                    List<string> stringSabotageTypes = new List<string>() { "null", "undefined", "List<string>" };
                    var stringOptions = typeScriptUnion.Options.Where(x => !stringSabotageTypes.Contains(cSharpConverter.ToCSharpType(x, cSharpConverter)));
                    var allAreLiterals = stringOptions.All(x => x is TypeScriptLiteral);

                    if (allAreLiterals)
                    {
                        // For non-literals we already generated above

                        if (stringOptions.All(x => cSharpConverter.ToCSharpType(x, cSharpConverter) == "string"))
                        {
                            foreach (var option in stringOptions)
                            {
                                TypeScriptLiteral typeScriptLiteral = option as TypeScriptLiteral;

                                var enumValueSetter = new CSharpPropertySetter()
                                {
                                    SetterName = $"Set{Utils.ToCSharpValidName(property.AttributeName)}{Utils.ToCSharpValidName(typeScriptLiteral.Value)}",
                                    CSharpType = "string",
                                    ClientSidePropertyName = property.AttributeName,
                                    DefaultValue = typeScriptLiteral.StringValue()
                                };

                                enumValueSetter.Comments.Add(property.Description);

                                output.AttributeSetters.Add(enumValueSetter);
                            }
                        }
                    }
                }
            }
        }

        foreach (var property in webComponent.Properties)
        {
            var allDistinctTypes = property.GetAllDistinctPropertyTypes(webComponent, cSharpConverter);
            foreach(var distinctType in allDistinctTypes)
            {
                output.PropertySetters.AddRange(distinctType.ToClientSidePropertySetters(webComponent, cSharpConverter));
            }

            var anonPropertyTypes = allDistinctTypes.Where(x => x.CollapsedTypeScriptType is TypeScriptAnonymousType);

            if (anonPropertyTypes.Any())
            {
                foreach (var anonType in anonPropertyTypes)
                {
                    var innerType = new NotAnonymousAnymorePropertyType()
                    {
                        CSharpName = anonType.Property.PropertyTypeFromAnonymous(webComponent),
                    };

                    foreach (var anonProperty in (anonType.CollapsedTypeScriptType as TypeScriptAnonymousType).properties)
                    {
                        var innerSetter = new CSharpPropertySetter()
                        {
                            ClientSidePropertyName = anonProperty.name,
                            CSharpType = anonProperty.type.ToCSharpType(cSharpConverter),
                            GenerateConst = false,
                            SetterName = "Set" + Utils.Capitalize(Utils.ToCSharpValidName(anonProperty.name)),
                        };

                        innerSetter.Parameters.Add(new CSharpPropertySetterParameter()
                        {
                            CSharpType = anonProperty.type.ToCSharpType(cSharpConverter),
                            ParameterName = Utils.ToParameterName(anonProperty.name),
                        });

                        innerType.Setters.Add(innerSetter);
                    }

                    output.PropertyTypes.Add(innerType);
                }
            }
        }

        foreach (var @event in webComponent.Events)
        {
            string eventTypeName = string.Empty;

            if (Generator.IsAnonymousType(@event.Type))
            {
                eventTypeName = @event.EventNameFromAnonymous(webComponent);

                var csharpType = new NotAnonymousAnymoreEventType()
                {
                    CSharpName = eventTypeName,
                };

                csharpType.Comments.Add(@event.Comment);

                var anonymousType = @event.Type as TypeScriptAnonymousType;


                foreach (var eventProperty in anonymousType.properties)
                {
                    csharpType.EventProperties.Add(new CSharpEventProperty()
                    {
                        PropertyName = eventProperty.name,
                        PropertyType = eventProperty.type.ToCSharpType(cSharpConverter)
                    });
                }

                output.EventTypes.Add(csharpType);
            }
            else
            {
                eventTypeName = cSharpConverter.ToCSharpType(@event.Type, cSharpConverter);
            }

            var csEvent = new CSharpEvent()
            {
                CSharpName = "On" + Utils.ToCSharpValidName(@event.Name),
                OriginalName = @event.Name,
                DetailPath = @event.DetailPath,
                TypeName = eventTypeName
            };

            csEvent.Comments.Add(@event.Comment);

            output.Events.Add(csEvent);
        }

        return output;
    }
    
    public class CollapsedPropertyType
    {
        public WebComponentProperty Property { get; set; }
        public ITypeScriptType CollapsedTypeScriptType { get; set; }
    }

    public static bool AreSameType(ITypeScriptType t1, ITypeScriptType t2, CSharpConverter cSharpConverter)
    {
        if (Generator.IsAnonymousType(t1) && Generator.IsAnonymousType(t2))
        {
            var anon1 = t1 as TypeScriptAnonymousType;
            var anon2 = t2 as TypeScriptAnonymousType;

            string anon1Props = string.Join(",", anon1.properties.Select(x => x.name));
            string anon2Props = string.Join(",", anon2.properties.Select(x => x.name));

            return anon1Props == anon2Props;
        }
        else if(Generator.IsStringLiteral(t1) && Generator.IsStringLiteral(t2))
        {
            var literal1 = t1 as TypeScriptLiteral;
            var literal2 = t2 as TypeScriptLiteral;
            return literal1.Value == literal2.Value;
        }
        else if (!Generator.IsAnonymousType(t1) && !Generator.IsAnonymousType(t2))
        {
            return t1.ToCSharpType(cSharpConverter) == t2.ToCSharpType(cSharpConverter);
        }
        else return false;
    }

    public static List<CollapsedPropertyType> GetAllDistinctPropertyTypes(this WebComponentProperty property, WebComponent webComponent, CSharpConverter converter)
    {
        List<CollapsedPropertyType> distinctTypes = new();


        if (Generator.IsMultiTypeUnion(property.TypeScriptType))
        {
            TypeScriptUnion typeScriptUnion = (property.TypeScriptType as TypeScriptUnion);

            foreach (var option in typeScriptUnion.Options)
            {
                var possiblyRepeatedTypes = GetAllDistinctPropertyTypes(
                    new WebComponentProperty()
                    {
                        AttributeName = property.PropertyName,
                        Description = property.Description,
                        PropertyName = property.PropertyName,
                        TypeScriptType = option
                    },
                    webComponent,
                    converter);

                foreach (var optionType in possiblyRepeatedTypes)
                {
                    if (!distinctTypes.Any(x => AreSameType(x.CollapsedTypeScriptType, optionType.CollapsedTypeScriptType, converter)))
                    {
                        distinctTypes.Add(optionType);
                    }
                }
            }
        }
        else if (Generator.IsBoolType(property.TypeScriptType))
        {
            distinctTypes.Add(new CollapsedPropertyType()
            {
                Property = property,
                CollapsedTypeScriptType = property.TypeScriptType,
            });
        }
        else if (Generator.IsStringLiteral(property.TypeScriptType))
        {
            distinctTypes.Add(new CollapsedPropertyType()
            {
                Property = property,
                CollapsedTypeScriptType = property.TypeScriptType,
            });
        }
        else if (Generator.IsObjectType(property.TypeScriptType))
        {
            TypeScriptObjectType objectType = property.TypeScriptType as TypeScriptObjectType;
            if (objectType.TypeName != "undefined" && objectType.TypeName != "null")
            {
                distinctTypes.Add(new CollapsedPropertyType()
                {
                    Property = property,
                    CollapsedTypeScriptType = property.TypeScriptType,
                });
            }
        }
        else if (Generator.IsFuncType(property.TypeScriptType))
        {
            TypeScriptFunction functionType = property.TypeScriptType as TypeScriptFunction;

            distinctTypes.Add(new CollapsedPropertyType()
            {
                Property = property,
                CollapsedTypeScriptType = property.TypeScriptType,
            });
        }
        else if (Generator.IsCollectionType(property.TypeScriptType))
        {
            TypeScriptCollection collectionType = property.TypeScriptType as TypeScriptCollection;

            var itemType = collectionType.ItemType;

            if (itemType is TypeScriptUnion)
            {
                var typeScriptUnion = itemType as TypeScriptUnion;
                foreach (var option in typeScriptUnion.Options)
                {
                    distinctTypes.Add(new CollapsedPropertyType()
                    {
                        Property = property,
                        CollapsedTypeScriptType = new TypeScriptCollection() { ItemType = option },
                    });
                }
            }
            else
            {
                distinctTypes.Add(new CollapsedPropertyType()
                {
                    Property = property,
                    CollapsedTypeScriptType = property.TypeScriptType,
                });
            }
        }
        else if (Generator.IsAnonymousType(property.TypeScriptType))
        {
            distinctTypes.Add(new CollapsedPropertyType()
            {
                Property = property,
                CollapsedTypeScriptType = property.TypeScriptType,
            });
        }
        else
        {
            throw new NotImplementedException();
        }

        return distinctTypes;
    }

    // A single web component property generates more setters with different signatures
    public static List<CSharpPropertySetter> ToClientSidePropertySetters(
        this CollapsedPropertyType propertyType,
        WebComponent webComponent,
        CSharpConverter cSharpConverter)
    {
        List<CSharpPropertySetter> setters = new List<CSharpPropertySetter>();



        if (Generator.IsBoolType(propertyType.CollapsedTypeScriptType))
        {
            // Add twice, with default 'true' if not set
            var withDefaultTrue = new CSharpPropertySetter()
            {
                SetterName = $"Set{Utils.ToCSharpValidName(propertyType.Property.PropertyName)}",
                CSharpType = "bool",
                ClientSidePropertyName = propertyType.Property.PropertyName,
                DefaultValue = "true"
            };
            withDefaultTrue.Comments.Add(propertyType.Property.Description);

            setters.Add(withDefaultTrue);

            var withParameter = new CSharpPropertySetter()
            {
                SetterName = $"Set{Utils.ToCSharpValidName(propertyType.Property.PropertyName)}",
                CSharpType = "bool",
                ClientSidePropertyName = propertyType.Property.PropertyName
            };
            withParameter.Parameters.Add(new CSharpPropertySetterParameter()
            {
                CSharpType = "bool",
                ParameterName = propertyType.Property.PropertyName.ToParameterName(),
            });
            withParameter.Comments.Add(propertyType.Property.Description);

            setters.Add(withParameter);
        }
        else if (Generator.IsStringLiteral(propertyType.CollapsedTypeScriptType))
        {
            TypeScriptLiteral literal = propertyType.CollapsedTypeScriptType as TypeScriptLiteral;

            var setter = new CSharpPropertySetter()
            {
                SetterName = $"Set{Utils.ToCSharpValidName(propertyType.Property.PropertyName)}{Utils.ToCSharpValidName(literal.Value)}",
                CSharpType = cSharpConverter.ToCSharpType(propertyType.CollapsedTypeScriptType, cSharpConverter),
                ClientSidePropertyName = propertyType.Property.PropertyName,
                DefaultValue = literal.Value
            };
            setter.Comments.Add(propertyType.Property.Description);

            setters.Add(setter);
        }
        else if (Generator.IsObjectType(propertyType.CollapsedTypeScriptType))
        {
            TypeScriptObjectType objectType = propertyType.CollapsedTypeScriptType as TypeScriptObjectType;
            if (objectType.TypeName != "undefined" && objectType.TypeName != "null")
            {
                var setter = new CSharpPropertySetter()
                {
                    SetterName = $"Set{Utils.ToCSharpValidName(propertyType.Property.PropertyName)}",
                    CSharpType = cSharpConverter.ToCSharpType(objectType, cSharpConverter),
                    ClientSidePropertyName = propertyType.Property.PropertyName,
                };
                setter.Comments.Add(propertyType.Property.Description);
                setter.Parameters.Add(new CSharpPropertySetterParameter()
                {
                    CSharpType = cSharpConverter.ToCSharpType(objectType, cSharpConverter),
                    ParameterName = propertyType.Property.PropertyName.ToParameterName()
                });

                setters.Add(setter);
            }
        }
        else if (Generator.IsFuncType(propertyType.CollapsedTypeScriptType))
        {
            TypeScriptFunction functionType = propertyType.CollapsedTypeScriptType as TypeScriptFunction;

            var setter = new CSharpPropertySetter()
            {
                SetterName = $"Set{Utils.ToCSharpValidName(propertyType.Property.PropertyName)}",
                CSharpType = cSharpConverter.ToCSharpType(functionType, cSharpConverter),
                ClientSidePropertyName = propertyType.Property.PropertyName,
            };
            setter.Comments.Add(propertyType.Property.Description);
            setter.Parameters.Add(new CSharpPropertySetterParameter()
            {
                CSharpType = cSharpConverter.ToCSharpType(functionType, cSharpConverter),
                ParameterName = propertyType.Property.PropertyName.ToParameterName()
            });

            setters.Add(setter);
        }
        else if (Generator.IsCollectionType(propertyType.CollapsedTypeScriptType))
        {
            var setter = new CSharpPropertySetter()
            {
                SetterName = $"Set{Utils.ToCSharpValidName(propertyType.Property.PropertyName)}",
                CSharpType = cSharpConverter.ToCSharpType(propertyType.CollapsedTypeScriptType, cSharpConverter),
                ClientSidePropertyName = propertyType.Property.PropertyName,
            };
            setter.Comments.Add(propertyType.Property.Description);
            setter.Parameters.Add(new CSharpPropertySetterParameter()
            {
                CSharpType = cSharpConverter.ToCSharpType(propertyType.CollapsedTypeScriptType, cSharpConverter),
                ParameterName = propertyType.Property.PropertyName.ToParameterName()
            });

            setters.Add(setter);
        }
        else if (Generator.IsAnonymousType(propertyType.CollapsedTypeScriptType))
        {
            //var anonType = property.TypeScriptType as TypeScriptAnonymousType;

            var anonTypeName = propertyType.Property.PropertyTypeFromAnonymous(webComponent);

            var setter = new CSharpPropertySetter()
            {
                SetterName = $"Set{Utils.ToCSharpValidName(propertyType.Property.PropertyName)}",
                CSharpType = anonTypeName,
                ClientSidePropertyName = propertyType.Property.PropertyName,
            };
            setter.Comments.Add(propertyType.Property.Description);
            setter.Parameters.Add(new CSharpPropertySetterParameter()
            {
                CSharpType = anonTypeName,
                ParameterName = propertyType.Property.PropertyName.ToParameterName()
            });

            setters.Add(setter);
        }
        else
        {
            throw new NotImplementedException();
        }

        return setters;
    }

    //// A single web component property generates more setters with different signatures
    //public static List<CSharpPropertySetter> ToClientSidePropertySetters(
    //    this WebComponentProperty property, 
    //    WebComponent webComponent,
    //    CSharpConverter cSharpConverter)
    //{
    //    List<CSharpPropertySetter> setters = new List<CSharpPropertySetter>();

    //    if (property.PropertyName.Contains("buttons"))
    //    {

    //    }

    //    if (Generator.IsMultiTypeUnion(property.TypeScriptType))
    //    {
    //        TypeScriptUnion typeScriptUnion = (property.TypeScriptType as TypeScriptUnion);

    //        foreach (var option in typeScriptUnion.Options)
    //        {
    //            setters.AddRange(ToClientSidePropertySetters(
    //                new WebComponentProperty()
    //                {
    //                    AttributeName = property.PropertyName,
    //                    Description = property.Description,
    //                    PropertyName = property.PropertyName,
    //                    TypeScriptType = option
    //                },
    //                webComponent,
    //                cSharpConverter));
    //        }
    //    }
    //    else if (Generator.IsBoolType(property.TypeScriptType))
    //    {
    //        // Add twice, with default 'true' if not set
    //        var withDefaultTrue = new CSharpPropertySetter()
    //        {
    //            SetterName = $"Set{Utils.ToCSharpValidName(property.PropertyName)}",
    //            CSharpType = "bool",
    //            ClientSidePropertyName = property.PropertyName,
    //            DefaultValue = "true"
    //        };
    //        withDefaultTrue.Comments.Add(property.Description);

    //        setters.Add(withDefaultTrue);

    //        var withParameter = new CSharpPropertySetter()
    //        {
    //            SetterName = $"Set{Utils.ToCSharpValidName(property.PropertyName)}",
    //            CSharpType = "bool",
    //            ClientSidePropertyName = property.PropertyName
    //        };
    //        withParameter.Parameters.Add(new CSharpPropertySetterParameter()
    //        {
    //            CSharpType = "bool",
    //            ParameterName = property.PropertyName.ToParameterName(),
    //        });
    //        withParameter.Comments.Add(property.Description);

    //        setters.Add(withParameter);
    //    }
    //    else if (Generator.IsStringLiteral(property.TypeScriptType))
    //    {
    //        TypeScriptLiteral literal = property.TypeScriptType as TypeScriptLiteral;

    //        var setter = new CSharpPropertySetter()
    //        {
    //            SetterName = $"Set{Utils.ToCSharpValidName(property.PropertyName)}{Utils.ToCSharpValidName(literal.Value)}",
    //            CSharpType = cSharpConverter.ToCSharpType(property.TypeScriptType, cSharpConverter),
    //            ClientSidePropertyName = property.PropertyName,
    //            DefaultValue = literal.Value
    //        };
    //        setter.Comments.Add(property.Description);

    //        setters.Add(setter);
    //    }
    //    else if (Generator.IsObjectType(property.TypeScriptType))
    //    {
    //        TypeScriptObjectType objectType = property.TypeScriptType as TypeScriptObjectType;
    //        if (objectType.TypeName != "undefined" && objectType.TypeName != "null")
    //        {
    //            var setter = new CSharpPropertySetter()
    //            {
    //                SetterName = $"Set{Utils.ToCSharpValidName(property.PropertyName)}",
    //                CSharpType = cSharpConverter.ToCSharpType(objectType, cSharpConverter),
    //                ClientSidePropertyName = property.PropertyName,
    //            };
    //            setter.Comments.Add(property.Description);
    //            setter.Parameters.Add(new CSharpPropertySetterParameter()
    //            {
    //                CSharpType = cSharpConverter.ToCSharpType(objectType, cSharpConverter),
    //                ParameterName = property.PropertyName.ToParameterName()
    //            });

    //            setters.Add(setter);
    //        }
    //    }
    //    else if (Generator.IsFuncType(property.TypeScriptType))
    //    {
    //        TypeScriptFunction functionType = property.TypeScriptType as TypeScriptFunction;

    //        var setter = new CSharpPropertySetter()
    //        {
    //            SetterName = $"Set{Utils.ToCSharpValidName(property.PropertyName)}",
    //            CSharpType = cSharpConverter.ToCSharpType(functionType, cSharpConverter),
    //            ClientSidePropertyName = property.PropertyName,
    //        };
    //        setter.Comments.Add(property.Description);
    //        setter.Parameters.Add(new CSharpPropertySetterParameter()
    //        {
    //            CSharpType = cSharpConverter.ToCSharpType(functionType, cSharpConverter),
    //            ParameterName = property.PropertyName.ToParameterName()
    //        });

    //        setters.Add(setter);
    //    }
    //    else if (Generator.IsCollectionType(property.TypeScriptType))
    //    {
    //        TypeScriptCollection collectionType = property.TypeScriptType as TypeScriptCollection;

    //        var itemType = collectionType.ItemType;

    //        if (itemType is TypeScriptUnion)
    //        {
    //            var typeScriptUnion = itemType as TypeScriptUnion;
    //            foreach (var option in typeScriptUnion.Options)
    //            {
    //                var listType = $"List<{cSharpConverter.ToCSharpType(option, cSharpConverter)}>";
    //                var setter = new CSharpPropertySetter()
    //                {
    //                    SetterName = $"Set{Utils.ToCSharpValidName(property.PropertyName)}",
    //                    CSharpType = listType,
    //                    ClientSidePropertyName = property.PropertyName,
    //                };
    //                setter.Comments.Add(property.Description);
    //                setter.Parameters.Add(new CSharpPropertySetterParameter()
    //                {
    //                    CSharpType = listType,
    //                    ParameterName = property.PropertyName.ToParameterName()
    //                });
    //                setters.Add(setter);
    //            }
    //        }
    //        else
    //        {
    //            var setter = new CSharpPropertySetter()
    //            {
    //                SetterName = $"Set{Utils.ToCSharpValidName(property.PropertyName)}",
    //                CSharpType = cSharpConverter.ToCSharpType(collectionType, cSharpConverter),
    //                ClientSidePropertyName = property.PropertyName,
    //            };
    //            setter.Comments.Add(property.Description);
    //            setter.Parameters.Add(new CSharpPropertySetterParameter()
    //            {
    //                CSharpType = cSharpConverter.ToCSharpType(collectionType, cSharpConverter),
    //                ParameterName = property.PropertyName.ToParameterName()
    //            });

    //            setters.Add(setter);
    //        }
    //    }
    //    else if(Generator.IsAnonymousType(property.TypeScriptType))
    //    {
    //        //var anonType = property.TypeScriptType as TypeScriptAnonymousType;

    //        var anonTypeName = property.PropertyTypeFromAnonymous(webComponent);

    //        var setter = new CSharpPropertySetter()
    //        {
    //            SetterName = $"Set{Utils.ToCSharpValidName(property.PropertyName)}",
    //            CSharpType = anonTypeName,
    //            ClientSidePropertyName = property.PropertyName,
    //        };
    //        setter.Comments.Add(property.Description);
    //        setter.Parameters.Add(new CSharpPropertySetterParameter()
    //        {
    //            CSharpType = anonTypeName,
    //            ParameterName = property.PropertyName.ToParameterName()
    //        });

    //        setters.Add(setter);
    //    }
    //    else
    //    {
    //        throw new NotImplementedException();
    //    }

    //    return setters;
    //}

    public static string Indent(int size)
    {
        return new string(' ', size * 4);
    }

    public static string GenerateComments(List<string> comments, int indent)
    {
        StringBuilder stringBuilder = new StringBuilder();
        stringBuilder.AppendLine($"{Indent(indent)}/// <summary>");
        if (!comments.Any())
        {
            comments.Add(string.Empty);
        }
        foreach (var comment in comments)
        {
            if (string.IsNullOrWhiteSpace(comment))
            {
                stringBuilder.AppendLine($"{Indent(indent)}///");
            }
            else
            {
                stringBuilder.AppendLine($"{Indent(indent)}/// <para> {comment} </para>");
            }
        }
        stringBuilder.AppendLine($"{Indent(indent)}/// </summary>");

        return stringBuilder.ToString();
    }

    public static void AppendComments(this StringBuilder b, List<string> comments, int indent)
    {
        b.Append(GenerateComments(comments, indent));
    }

    public static void AppendComments(this StringBuilder b, string comments, int indent)
    {
        b.AppendComments(new List<string>() { comments }, indent);
    }

    public static string ToCSharpFile(this CSharpComponent component, string @namespace, List<string> usingNamespaces)
    {
        StringBuilder codeBuilder = new StringBuilder();

        foreach (var usingNamespace in usingNamespaces)
        {
            codeBuilder.AppendLine($"using {usingNamespace};");
        }
        codeBuilder.AppendLine();
        codeBuilder.AppendLine($"namespace {@namespace};");
        codeBuilder.AppendLine();
        codeBuilder.AppendLine();


        codeBuilder.Append($"public partial class {component.ClassName}");
        if (!string.IsNullOrEmpty(component.BaseClassName))
        {
            codeBuilder.Append($" : {component.BaseClassName}");
        }

        codeBuilder.AppendLine();
        codeBuilder.AppendLine("{");

        if (!string.IsNullOrEmpty(component.BaseClassName))
        {
            codeBuilder.AppendLine($"    public {component.ClassName}() : base(\"{component.HtmlTag}\") {{ }}");
        }

        if (component.Slots.Any())
        {
            codeBuilder.AppendComments(new List<string>() { component.DefaultSlotComment }, 1);

            codeBuilder.AppendLine("    public static class Slot");
            codeBuilder.AppendLine("    {");
            foreach (var slot in component.Slots)
            {
                codeBuilder.AppendComments(slot.Comments, 2);
                codeBuilder.AppendLine($"        public const string {Utils.ToCSharpValidName(slot.CSharpName)} = \"{slot.OriginalName}\";");
            }
            codeBuilder.AppendLine("    }");
        }

        if (component.Methods.Any())
        {
            codeBuilder.AppendLine("    public static class Method");
            codeBuilder.AppendLine("    {");
            foreach (var method in component.Methods)
            {
                codeBuilder.AppendComments(method.Comments, 2);
                codeBuilder.AppendLine($"        public const string {Utils.ToCSharpValidName(method.CSharpName)} = \"{method.OriginalName}\";");
            }
            codeBuilder.AppendLine("    }");
        }

        codeBuilder.AppendLine("}");
        codeBuilder.AppendLine();

        codeBuilder.AppendLine($"public static partial class {component.ClassName}Control");
        codeBuilder.AppendLine("{");

        // Server-side rendering

        codeBuilder.AppendComments(component.Comments, 1);
        codeBuilder.AppendLine($"    public static IHtmlNode {component.ClassName}(this HtmlBuilder b, Action<AttributesBuilder<{component.ClassName}>> buildAttributes, params IHtmlNode[] children)");
        codeBuilder.AppendLine("    {");
        codeBuilder.AppendLine($"        return b.{component.ServerSideConstructorName}(\"{component.HtmlTag}\", buildAttributes, children);");
        codeBuilder.AppendLine("    }");

        codeBuilder.AppendComments(component.Comments, 1);

        codeBuilder.AppendLine($"    public static IHtmlNode {component.ClassName}(this HtmlBuilder b, params IHtmlNode[] children)");
        codeBuilder.AppendLine("    {");
        codeBuilder.AppendLine($"        return b.{component.ServerSideConstructorName}(\"{component.HtmlTag}\", new Dictionary<string, string>(), children);");
        codeBuilder.AppendLine("    }");



        codeBuilder.AppendComments(component.Comments, 1);
        codeBuilder.AppendLine($"    public static IHtmlNode {component.ClassName}(this HtmlBuilder b, Action<AttributesBuilder<{component.ClassName}>> buildAttributes, List<IHtmlNode> children)");
        codeBuilder.AppendLine("    {");
        codeBuilder.AppendLine($"        return b.{component.ServerSideConstructorName}(\"{component.HtmlTag}\", buildAttributes, children);");
        codeBuilder.AppendLine("    }");

        codeBuilder.AppendComments(component.Comments, 1);

        codeBuilder.AppendLine($"    public static IHtmlNode {component.ClassName}(this HtmlBuilder b, List<IHtmlNode> children)");
        codeBuilder.AppendLine("    {");
        codeBuilder.AppendLine($"        return b.{component.ServerSideConstructorName}(\"{component.HtmlTag}\", new Dictionary<string, string>(), children);");
        codeBuilder.AppendLine("    }");

        foreach (var setter in component.AttributeSetters)
        {
            codeBuilder.AppendLine(GenerateServerSideSetter(setter, component));

        }

        // Client side rendering

        codeBuilder.AppendComments(component.Comments, 1);
        codeBuilder.AppendLine($"    public static Var<IVNode> {component.ClassName}(this LayoutBuilder b, Action<PropsBuilder<{component.ClassName}>> buildProps, Var<List<IVNode>> children)");
        codeBuilder.AppendLine("    {");
        codeBuilder.AppendLine($"        return b.{component.ClientSideConstructorName}(\"{component.HtmlTag}\", buildProps, children);");
        codeBuilder.AppendLine("    }");

        codeBuilder.AppendComments(component.Comments, 1);
        codeBuilder.AppendLine($"    public static Var<IVNode> {component.ClassName}(this LayoutBuilder b, Action<PropsBuilder<{component.ClassName}>> buildProps, params Var<IVNode>[] children)");
        codeBuilder.AppendLine("    {");
        codeBuilder.AppendLine($"        return b.{component.ClientSideConstructorName}(\"{component.HtmlTag}\", buildProps, children);");
        codeBuilder.AppendLine("    }");

        codeBuilder.AppendComments(component.Comments, 1);
        codeBuilder.AppendLine($"    public static Var<IVNode> {component.ClassName}(this LayoutBuilder b, Var<List<IVNode>> children)");
        codeBuilder.AppendLine("    {");
        codeBuilder.AppendLine($"        return b.{component.ClientSideConstructorName}(\"{component.HtmlTag}\", children);");
        codeBuilder.AppendLine("    }");

        codeBuilder.AppendComments(component.Comments, 1);
        codeBuilder.AppendLine($"    public static Var<IVNode> {component.ClassName}(this LayoutBuilder b, params Var<IVNode>[] children)");
        codeBuilder.AppendLine("    {");
        codeBuilder.AppendLine($"        return b.{component.ClientSideConstructorName}(\"{component.HtmlTag}\", children);");
        codeBuilder.AppendLine("    }");

        foreach (var setter in component.PropertySetters)
        {
            codeBuilder.AppendLine(GenerateClientSideSetter(setter, component));
        }

        foreach(var innerClass in component.EventTypes)
        {
            codeBuilder.AppendLine(GenerateInnerClass(innerClass));
        }

        foreach (var @event in component.Events)
        {
            codeBuilder.AppendLine(GenerateEvent(@event, component));
        }

        foreach (var innerClass in component.PropertyTypes)
        {
            codeBuilder.AppendLine($"public class {innerClass.CSharpName} {{ }}");

            foreach (var innerSetter in innerClass.Setters)
            {
                var setterCode = GenerateVariableClientSideSetter(innerSetter, new CSharpComponent()
                {
                    ClassName = innerClass.CSharpName
                });

                codeBuilder.AppendLine(setterCode);
            }
        }

        codeBuilder.AppendLine("}");
        codeBuilder.AppendLine();

        return codeBuilder.ToString();
    }

    public static string GenerateServerSideSetter(this CSharpPropertySetter setter, CSharpComponent component)
    {
        StringBuilder codeBuilder = new StringBuilder();
        codeBuilder.AppendComments(setter.Comments, 1);

        var parameters = string.Join(",", setter.Parameters.Select(x => $"{x.CSharpType} {x.ParameterName}"));
        var signature = !string.IsNullOrWhiteSpace(parameters) ?
            string.Join(",", $"    public static void {setter.SetterName}(this AttributesBuilder<{component.ClassName}> b", " " + parameters) + ")" :
            $"    public static void {setter.SetterName}(this AttributesBuilder<{component.ClassName}> b)";

        codeBuilder.AppendLine(signature);
        codeBuilder.AppendLine("    {");

        var setterCode = string.Empty;

        if (setter.Parameters.Count == 1)
        {
            if (setter.CSharpType == "bool")
            {
                setterCode = $"if ({setter.Parameters.Single().ParameterName}) b.SetAttribute(\"{setter.ClientSidePropertyName}\", \"\");";
            }
            else if (setter.CSharpType == "string")
            {
                setterCode = $"b.SetAttribute(\"{setter.ClientSidePropertyName}\", {setter.Parameters.Single().ParameterName});";
            }
            else throw new NotSupportedException();
        }
        else if (setter.Parameters.Count == 0)
        {
            setterCode = $"b.SetAttribute(\"{setter.ClientSidePropertyName}\", \"{setter.DefaultValue}\");";
        }

        if (string.IsNullOrWhiteSpace(setterCode))
        {
            throw new NotImplementedException();
        }

        codeBuilder.AppendLine($"        {setterCode}");

        codeBuilder.AppendLine("    }");

        return codeBuilder.ToString();
    }

    public static string GenerateClientSideSetter(this CSharpPropertySetter setter, CSharpComponent component)
    {
        StringBuilder codeBuilder = new StringBuilder();

        if (setter.Parameters.Count == 0)
        {
            codeBuilder.AppendLine(GenerateLiteralPropertySetter(setter, component));
        }

        else if (setter.Parameters.Count == 1)
        {
            codeBuilder.AppendLine(GenerateVariableClientSideSetter(setter, component));
            codeBuilder.AppendLine(GenerateConstClientSideSetter(setter, component));
        }
        else throw new NotSupportedException();
        return codeBuilder.ToString();
    }

    //public static string GenerateDefaultBoolClientSideSetter(this CSharpPropertySetter setter, CSharpComponent component)
    //{
    //    if (setter.Parameters.Count > 0 && setter.CSharpType != "bool")
    //    {
    //        throw new NotSupportedException();
    //    }

    //    StringBuilder codeBuilder = new StringBuilder();

    //    codeBuilder.AppendComments(setter.Comments, 1);

    //    codeBuilder.AppendLine($"    public static void {setter.SetterName}<T>(this PropsBuilder<T> b) where T: {component.ClassName}");
    //    codeBuilder.AppendLine("    {");
    //    codeBuilder.AppendLine($"        b.SetDynamic(b.Props, new DynamicProperty<{setter.CSharpType}>(\"{setter.ClientSidePropertyName}\"), b.Const(true));");
    //    codeBuilder.AppendLine("    }");

    //    return codeBuilder.ToString();
    //}

    public static string GenerateConstClientSideSetter(this CSharpPropertySetter setter, CSharpComponent component)
    {
        if (setter.GenerateConst == false)
            return string.Empty;

        StringBuilder codeBuilder = new StringBuilder();

        codeBuilder.AppendComments(setter.Comments, 1);

        codeBuilder.AppendLine($"    public static void {setter.SetterName}<T>(this PropsBuilder<T> b, {setter.CSharpType} {setter.ClientSidePropertyName.ToParameterName()}) where T: {component.ClassName}");
        codeBuilder.AppendLine("    {");
        codeBuilder.AppendLine($"        b.SetProperty(b.Props, b.Const(\"{setter.ClientSidePropertyName}\"), b.Const({setter.ClientSidePropertyName.ToParameterName()}));");
        codeBuilder.AppendLine("    }");

        return codeBuilder.ToString();
    }

    public static string GenerateVariableClientSideSetter(this CSharpPropertySetter setter, CSharpComponent component)
    {
        StringBuilder codeBuilder = new StringBuilder();

        codeBuilder.AppendComments(setter.Comments, 1);

        codeBuilder.AppendLine($"    public static void {setter.SetterName}<T>(this PropsBuilder<T> b, Var<{setter.CSharpType}> {setter.ClientSidePropertyName.ToParameterName()}) where T: {component.ClassName}");
        codeBuilder.AppendLine("    {");
        codeBuilder.AppendLine($"        b.SetProperty(b.Props, b.Const(\"{setter.ClientSidePropertyName}\"), {setter.ClientSidePropertyName.ToParameterName()});");
        codeBuilder.AppendLine("    }");

        return codeBuilder.ToString();
    }

    public static string GenerateLiteralPropertySetter(this CSharpPropertySetter setter, CSharpComponent component)
    {
        StringBuilder codeBuilder = new StringBuilder();

        codeBuilder.AppendComments(setter.Comments, 1);

        var setterValue = setter.DefaultValue;
        if (setter.CSharpType == "string")
        {
            setterValue = "\"" + setterValue + "\"";
        }

        codeBuilder.AppendLine($"    public static void {setter.SetterName}<T>(this PropsBuilder<T> b) where T: {component.ClassName}");
        codeBuilder.AppendLine("    {");
        codeBuilder.AppendLine($"        b.SetProperty(b.Props, b.Const(\"{setter.ClientSidePropertyName}\"), b.Const({setterValue}));");
        codeBuilder.AppendLine("    }");

        return codeBuilder.ToString();
    }

    public static string GenerateInnerClass(NotAnonymousAnymoreEventType type)
    {
        StringBuilder codeBuilder = new StringBuilder();
        codeBuilder.AppendComments(type.Comments, 1);
        codeBuilder.AppendLine($"    public class {type.CSharpName}");
        codeBuilder.AppendLine("    {");
        foreach (var eventProperty in type.EventProperties)
        {
            codeBuilder.AppendLine($"        public {eventProperty.PropertyType} {eventProperty.PropertyName} {{ get; set; }}");
        }
        codeBuilder.AppendLine("    }");

        return codeBuilder.ToString();
    }

    public static string GenerateEvent(this CSharpEvent csEvent, CSharpComponent cSharpComponent)
    {
        StringBuilder codeBuilder = new StringBuilder();

        string detailPath = string.Join(", ", csEvent.DetailPath.Select(x => $"\"{x}\""));
        if (string.IsNullOrWhiteSpace(detailPath))
            detailPath = "";
        else detailPath = ", " + detailPath;


        if (csEvent.TypeName == "void")
        {
            // HyperAction with no payload
            codeBuilder.AppendComments(csEvent.Comments, 1);
            codeBuilder.AppendLine($"    public static void {csEvent.CSharpName}<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel>> action) where TComponent: {cSharpComponent.ClassName}");
            codeBuilder.AppendLine("    {");
            codeBuilder.AppendLine($"        b.OnEventAction(\"on{csEvent.OriginalName}\", action);");
            codeBuilder.AppendLine("    }");

            codeBuilder.AppendComments(csEvent.Comments, 1);
            codeBuilder.AppendLine($"    public static void {csEvent.CSharpName}<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action) where TComponent: {cSharpComponent.ClassName}");
            codeBuilder.AppendLine("    {");
            codeBuilder.AppendLine($"        b.OnEventAction(\"on{csEvent.OriginalName}\", b.MakeAction(action));");
            codeBuilder.AppendLine("    }");
        }
        else
        {
            codeBuilder.AppendComments(csEvent.Comments, 1);
            codeBuilder.AppendLine($"    public static void {csEvent.CSharpName}<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel, {csEvent.TypeName}>> action) where TComponent: {cSharpComponent.ClassName}");
            codeBuilder.AppendLine("    {");
            codeBuilder.AppendLine($"        b.OnEventAction(\"on{csEvent.OriginalName}\", action{detailPath});");
            codeBuilder.AppendLine("    }");

            codeBuilder.AppendComments(csEvent.Comments, 1);
            codeBuilder.AppendLine($"    public static void {csEvent.CSharpName}<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<{csEvent.TypeName}>, Var<TModel>> action) where TComponent: {cSharpComponent.ClassName}");
            codeBuilder.AppendLine("    {");
            codeBuilder.AppendLine($"        b.OnEventAction(\"on{csEvent.OriginalName}\", b.MakeAction(action){detailPath});");
            codeBuilder.AppendLine("    }");
        }

        return codeBuilder.ToString();
    }
}