using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Xml;
using System.Xml.Linq;
using Serenity.TypeScript;

namespace Metapsi.WebComponentGenerator;

public interface ITypeScriptType
{
}

public class TypeScriptCollection : ITypeScriptType
{
    public ITypeScriptType ItemType { get; set; }
}

public class TypeScriptFunctionParameter : ITypeScriptType
{
    public string Name { get; set; }
    public ITypeScriptType Type { get; set; }
}

public class TypeScriptFunction : ITypeScriptType
{
    public List<TypeScriptFunctionParameter> Parameters { get; set; } = new();
    public ITypeScriptType ReturnType { get; set; }
}

public class TypeScriptUnion : ITypeScriptType
{
    public List<ITypeScriptType> Options { get; set; } = new();
}

public class TypeScriptObjectType : ITypeScriptType
{
    public string TypeName { get; set; }
}

public class TypeScriptAnonymousType : ITypeScriptType
{
    public List<(string name, ITypeScriptType type)> properties {  get; set; } = new();
}


public class TypeScriptDictionary : ITypeScriptType
{
    public ITypeScriptType KeyType { get; set; }
    public ITypeScriptType ValueType { get; set; }
}

public class TypeScriptLiteral : ITypeScriptType
{
    public string Type { get; set; } = "string";
    public string Value { get; set; }
}

public static class TypeParser
{
    private static TypeScriptLiteral MatchLiteral(INode node)
    {
        LiteralExpressionBase literalExpression = node as LiteralExpressionBase;

        if (literalExpression != null)
        {
            return new TypeScriptLiteral()
            {
                Type = "string",
                Value = literalExpression.Text
            };
        }

        LiteralTypeNode literalTypeNode = node as LiteralTypeNode;
        if (literalTypeNode != null)
        {
            StringLiteral stringLiteral = literalTypeNode.Literal as StringLiteral;

            if (stringLiteral == null)
                throw new NotImplementedException();

            return new TypeScriptLiteral()
            {
                Type = "string",
                Value = stringLiteral.Text
            };
        }

        return null;
    }

    private static TypeScriptUnion MatchUnion(INode node)
    {
        BinaryExpression binaryExpression = node as BinaryExpression;
        if (binaryExpression != null)
        {
            if (binaryExpression.OperatorToken.Kind == SyntaxKind.BarToken)
            {
                TypeScriptUnion union = new TypeScriptUnion();

                Console.WriteLine("left " + binaryExpression.Left.GetText());
                Console.WriteLine("right " + binaryExpression.Right.GetText());

                List<ITypeScriptType> unionTypes = new List<ITypeScriptType>();

                while (true)
                {
                    unionTypes.Add(GetTypeScriptType(binaryExpression.Right));
                    var leftAsUnion = binaryExpression.Left as BinaryExpression;

                    if (leftAsUnion == null)
                    {
                        IExpression expression = binaryExpression.Left;
                        if(expression is ParenthesizedExpression)
                        {
                            expression = (expression as ParenthesizedExpression).Expression;
                        }
                        unionTypes.Add(GetTypeScriptType(expression));
                        break;
                    }
                    else
                    {
                        if (leftAsUnion.OperatorToken.Kind == SyntaxKind.BarToken)
                        {
                            binaryExpression = leftAsUnion;
                        }
                    }
                }

                union.Options.AddRange(unionTypes.Select(x => x).Reverse());

                return union;

            }
        }

        UnionTypeNode unionTypeNode = node as UnionTypeNode;
        if (unionTypeNode != null)
        {
            TypeScriptUnion union = new TypeScriptUnion();

            foreach (var type in unionTypeNode.Types)
            {
                union.Options.Add(GetTypeScriptType(type));
            }

            return union;
        }

        return null;
    }

    private static TypeScriptCollection MatchCollection(INode node)
    {
        ElementAccessExpression elementAccessExpression = node as ElementAccessExpression;

        if (elementAccessExpression != null)
        {
            IExpression expression = elementAccessExpression.Expression;
            if (expression is ParenthesizedExpression)
            {
                expression = (expression as ParenthesizedExpression).Expression;
            }

            return new TypeScriptCollection()
            {
                ItemType = GetTypeScriptType(expression)
            };
        }

        ArrayTypeNode arrayType = node as ArrayTypeNode;

        if (arrayType != null)
        {
            // ?!

            var restChildren = arrayType.GetRestChildren();

            return new TypeScriptCollection()
            {
                ItemType = GetTypeScriptType(restChildren.Single())
            };
        }

        return null;
    }

    private static TypeScriptFunction MatchArrowFunction(INode node)
    {
        var arrowFunction = node as ArrowFunction;
        if (arrowFunction != null)
        {
            var f = new TypeScriptFunction();

            foreach (var p in arrowFunction.Parameters)
            {
                f.Parameters.Add(new TypeScriptFunctionParameter()
                {
                    Name = p.Name.GetText(),
                    Type = GetTypeScriptType(p.Type)
                });
            }

            f.ReturnType = GetTypeScriptType(arrowFunction.Body);

            return f;
        }

        var functionTypeNode = node as FunctionTypeNode;

        if (functionTypeNode != null)
        {
            var f = new TypeScriptFunction();

            foreach (var p in functionTypeNode.Parameters)
            {
                f.Parameters.Add(new TypeScriptFunctionParameter()
                {
                    Name = p.Name.GetText(),
                    Type = GetTypeScriptType(p.Type)
                });
            }

            f.ReturnType = GetTypeScriptType(functionTypeNode.Type);

            return f;
        }

        return null;
    }

    private static TypeScriptAnonymousType MatchAnonymousType(INode node)
    {
        var typeLiteral = node as TypeLiteralNode;//??
        if (typeLiteral != null)
        {
            if (typeLiteral.Members.All(x => x is PropertySignature))
            {
                var anonymousType = new TypeScriptAnonymousType();
                foreach (var memberProperty in typeLiteral.Members.Cast<PropertySignature>())
                {
                    anonymousType.properties.Add((memberProperty.Name.GetText(), GetTypeScriptType(memberProperty.Type)));
                }

                return anonymousType;
            }
        }
        return null;
    }

    private static TypeScriptObjectType MatchObjectType(INode node)
    {
        var identifierNode = node as Identifier;
        if (identifierNode != null)
        {
            return new TypeScriptObjectType()
            {
                TypeName = identifierNode.Text
            };
        }

        var typeReference = node as TypeReferenceNode;
        if (typeReference != null)
        {
            return new TypeScriptObjectType()
            {
                TypeName = typeReference.GetText()
            };
        }

        var typeNode = node as KeywordTypeNode;
        if (typeNode != null)
        {
            return new TypeScriptObjectType()
            {
                TypeName = typeNode.GetText()
            };
        }

        var objectLiteral = node as ObjectLiteralExpression;
        if (objectLiteral != null)
        {
            return new TypeScriptObjectType()
            {
                TypeName = "DynamicObject"
            };
        }

        var voidExpression = node as VoidExpression;
        if (voidExpression != null)
        {
            return new TypeScriptObjectType()
            {
                TypeName = "void"
            };
        }

        var expressionWithType = node as ExpressionWithTypeArguments;
        if (expressionWithType != null)
        {
            return new TypeScriptObjectType()
            {
                TypeName = "DynamicObject"
            };
        }

        var typeLiteral = node as TypeLiteralNode;
        if (typeLiteral != null)
        {
            if (typeLiteral.Members.All(x => x is IndexSignatureDeclaration))
            {
                return new TypeScriptObjectType()
                {
                    TypeName = "DynamicObject"
                };
            }
        }

        LiteralTypeNode literalTypeNode = node as LiteralTypeNode;
        if (literalTypeNode != null)
        {
            NullLiteral nullLiteral = literalTypeNode.Literal as NullLiteral;

            if (nullLiteral != null)
            {
                return new TypeScriptObjectType()
                {
                    TypeName = "null"
                };
            }
        }

        if (node.Kind == SyntaxKind.NullKeyword)
        {
            return new TypeScriptObjectType()
            {
                TypeName = "null"
            };
        }

        return null;
    }

    private static ITypeScriptType GetTypeScriptType(INode node)
    {
        ITypeScriptType typeScriptType = null;

        if (node is ParenthesizedExpression)
        {
            node = (node as ParenthesizedExpression).Expression;
        }

        if (node is ParenthesizedTypeNode)
        {
            node = (node as ParenthesizedTypeNode).Type;
        }

        if (typeScriptType == null) typeScriptType = MatchObjectType(node);
        if (typeScriptType == null) typeScriptType = MatchArrowFunction(node);
        if (typeScriptType == null) typeScriptType = MatchUnion(node);
        if (typeScriptType == null) typeScriptType = MatchLiteral(node);
        if (typeScriptType == null) typeScriptType = MatchCollection(node);
        if (typeScriptType == null) typeScriptType = MatchAnonymousType(node);

        if (typeScriptType == null)
            throw new NotImplementedException();

        return typeScriptType;
    }

    public static ITypeScriptType GetTypeScriptType(string typeText)
    {
        var ghostInterface = "interface Ghost {\r\n p : " + typeText + "   \r\n}";

        var sourceFile = new Parser().ParseSourceFile("ts.ts", ghostInterface);

        ITypeScriptType type = null;

        var propertyType = ((sourceFile.Statements.Single() as InterfaceDeclaration).Members.Single() as PropertySignature).Type;

        type = GetTypeScriptType(propertyType);

        if (type == null)
        {
            throw new NotImplementedException();
        }

        return type;
    }
}

public static class Utils
{
    public static string SearchUpfolder(string startPath, string folderName)
    {
        if (string.IsNullOrEmpty(startPath))
            return string.Empty;

        var currentDirectories = System.IO.Directory.GetDirectories(startPath);
        var matchingPath = currentDirectories.FirstOrDefault(x => x.Split("\\").LastOrDefault() == folderName);
        if (matchingPath != null)
            return matchingPath;

        matchingPath = currentDirectories.FirstOrDefault(x => x.Split("\\").LastOrDefault() == folderName);
        if (matchingPath != null)
            return matchingPath;

        return SearchUpfolder(System.IO.Path.GetDirectoryName(startPath), folderName);
    }

    public static string Capitalize(string s)
    {
        if (string.IsNullOrWhiteSpace(s))
            return string.Empty;

        return s.Length == 1 ? s.ToUpperInvariant() : s.Substring(0, 1).ToUpperInvariant() + s.Substring(1);
    }

    public static string ToCSharpValidName(string s)
    {
        if (string.IsNullOrWhiteSpace(s))
            return string.Empty;

        return string.Join(null, s.Split(new char[] { '-', '/' }).Select(Capitalize));
    }

    public static string ToParameterName(this string s)
    {
        var capitalized = string.Join(null, s.Split(new char[] { '-', '/' }).Select(Capitalize));
        var parameterName = capitalized.Substring(0, 1).ToLowerInvariant() + capitalized.Substring(1);
        return FixReservedKeyword(parameterName);
    }

    public static string FixReservedKeyword(string s)
    {
        HashSet<string> reservedKeywords = new() { "checked", "readonly", "fixed", "interface", "event" };
        if (reservedKeywords.Contains(s))
            return "@" + s;

        return s;
    }

    public static void SetCsProjDescription(string fullProjectPath, string description)
    {
        var projectContent = System.IO.File.ReadAllText(fullProjectPath);
        var csProjXml = XDocument.Parse(projectContent, LoadOptions.PreserveWhitespace);
        csProjXml.Declaration = null;
        csProjXml.Root.Element("PropertyGroup").Element("Description").Value = description;

        System.IO.File.WriteAllText(fullProjectPath, csProjXml.ToString());
    }

    public static string JsDelivrFileUrl(string project, string package, string version, string filePath)
    {
        return $"https://cdn.jsdelivr.net/npm/@{project}/{package}@{version}/dist/{filePath}";
    }

    public static string SingleLine(string comment)
    {
        return comment.Replace("\r", string.Empty).Replace("\n", " ");
    }

    public static string ReplaceAngleBrackets(string comment)
    {
        return comment.Replace("<", "&lt;").Replace(">", "&gt;");
    }
}