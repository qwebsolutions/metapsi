//using System;
//using System.Collections.Generic;
//using System.Text.Json;
//using System.Text.Json.Serialization;

//namespace Metapsi.Syntax
//{
//    public static class JsonExtensions
//    {
//        public static string ToJson(this Module module, Action<JsonSerializerOptions> extraOptions = null)
//        {

//            var options = new JsonSerializerOptions();
//            options.Converters.Add(new SyntaxNodeConverter());
//            options.Converters.Add(new JsonStringEnumConverter());
//            if (extraOptions != null)
//            {
//                extraOptions(options);
//            }
//            var moduleJson = System.Text.Json.JsonSerializer.Serialize(module, options);
//            return moduleJson;
//        }

//        public static Module FromJson(string json, Action<JsonSerializerOptions> extraOptions = null)
//        {
//            var options = new JsonSerializerOptions();
//            options.Converters.Add(new SyntaxNodeConverter());
//            options.Converters.Add(new JsonStringEnumConverter());
//            if (extraOptions != null)
//            {
//                extraOptions(options);
//            }
//            var module = System.Text.Json.JsonSerializer.Deserialize<Module>(json, options);
//            return module;
//        }
//    }

//    public class SyntaxNodeConverter : JsonConverter<ISyntaxNode>
//    {
//        public override ISyntaxNode Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
//        {
//            if (reader.TokenType != JsonTokenType.StartObject)
//            {
//                throw new JsonException("Expected StartObject token");
//            }

//            reader.Read();
//            if (reader.TokenType != JsonTokenType.PropertyName)
//            {
//                throw new JsonException("Expected PropertyName token");
//            }

//            var propertyName = reader.GetString();

//            if (propertyName != "Type")
//            {
//                throw new JsonException("Expected Type property name");
//            }

//            reader.Read();

//            var nodeType = reader.GetString();

//            ISyntaxNode outNode = null;

//            switch ((NodeType)Enum.Parse(typeof(NodeType), nodeType))
//            {
//                case NodeType.Literal:
//                    {
//                        outNode = new LiteralNode()
//                        {
//                            Value = ReadProperty<LiteralNode>(x => x.Value, ref reader, options)
//                        };
//                    }
//                    break;
//                case NodeType.Identifier:
//                    {
//                        outNode = new IdentifierNode()
//                        {
//                            Name = ReadProperty<IdentifierNode>(x => x.Name, ref reader, options)
//                        };
//                    }
//                    break;
//                case NodeType.Assignment:
//                    {
//                        outNode = new AssignmentNode()
//                        {
//                            Name = ReadProperty<AssignmentNode>(x => x.Name, ref reader, options),
//                            Node = ReadProperty<AssignmentNode>(x => x.Node, ref reader, options)
//                        };
//                    }
//                    break;
//                case NodeType.Fn:
//                    {
//                        outNode = new FnNode()
//                        {
//                            Parameters = ReadProperty<FnNode>(x => x.Parameters, ref reader, options),
//                            Body = ReadProperty<FnNode>(x => x.Body, ref reader, options),
//                            Return = ReadProperty<FnNode>(x => x.Return, ref reader, options)
//                        };
//                    }
//                    break;
//                case NodeType.Call:
//                    {
//                        outNode = new CallNode()
//                        {
//                            Fn = ReadProperty<CallNode>(x => x.Fn, ref reader, options),
//                            Arguments = ReadProperty<CallNode>(x => x.Arguments, ref reader, options),
//                        };
//                    }
//                    break;
//                case NodeType.Linq:
//                    {
//                        outNode = new LinqNode()
//                        {
//                            Expr = ReadProperty<LinqNode>(x => x.Expr, ref reader, options)
//                        };
//                    }
//                    break;
//                case NodeType.Comment:
//                    {
//                        outNode = new CommentNode()
//                        {
//                            Comment = ReadProperty<CommentNode>(x => x.Comment, ref reader, options)
//                        };
//                    }
//                    break;
//            }

//            reader.Read();
//            if (reader.TokenType != JsonTokenType.EndObject)
//            {
//                throw new JsonException("Expected EndObject");
//            }

//            return outNode;
//        }

//        public override void Write(Utf8JsonWriter writer, ISyntaxNode value, JsonSerializerOptions options)
//        {
//            switch (value.Type)
//            {
//                case NodeType.Literal:
//                    ((JsonConverter<LiteralNode>)options.GetConverter(typeof(LiteralNode))).Write(writer, value as LiteralNode, options);
//                    break;
//                case NodeType.Identifier:
//                    ((JsonConverter<IdentifierNode>)options.GetConverter(typeof(IdentifierNode))).Write(writer, value as IdentifierNode, options);
//                    break;
//                case NodeType.Assignment:
//                    ((JsonConverter<AssignmentNode>)options.GetConverter(typeof(AssignmentNode))).Write(writer, value as AssignmentNode, options);
//                    break;
//                case NodeType.Fn:
//                    ((JsonConverter<FnNode>)options.GetConverter(typeof(FnNode))).Write(writer, value as FnNode, options);
//                    break;
//                case NodeType.Call:
//                    ((JsonConverter<CallNode>)options.GetConverter(typeof(CallNode))).Write(writer, value as CallNode, options);
//                    break;
//                case NodeType.Linq:
//                    ((JsonConverter<LinqNode>)options.GetConverter(typeof(LinqNode))).Write(writer, value as LinqNode, options);
//                    break;
//                case NodeType.Comment:
//                    ((JsonConverter<CommentNode>)options.GetConverter(typeof(CommentNode))).Write(writer, value as CommentNode, options);
//                    break;
//            }
//        }

//        private void ReadProperty(string propertyName, ref Utf8JsonReader reader, JsonSerializerOptions options)
//        {
//            reader.Read();
//            if (reader.TokenType != JsonTokenType.PropertyName)
//            {
//                throw new JsonException("Property name expected!");
//            }

//            var nextPropertyName = reader.GetString();
//            if (nextPropertyName != propertyName)
//                throw new JsonException($"{propertyName} property expected!");

//            reader.Read();
//        }

//        private string ReadProperty<T>(System.Linq.Expressions.Expression<Func<T, string>> property, ref Utf8JsonReader reader, JsonSerializerOptions options)
//        {
//            ReadProperty(property.PropertyName(), ref reader, options);
//            return reader.GetString();
//        }

//        private List<string> ReadProperty<T>(System.Linq.Expressions.Expression<Func<T, List<string>>> property, ref Utf8JsonReader reader, JsonSerializerOptions options)
//        {
//            List<string> outList = new List<string>();
//            ReadProperty(property.PropertyName(), ref reader, options);
//            if (reader.TokenType != JsonTokenType.StartArray)
//            {
//                throw new JsonException("Array expected!");
//            }
//            while (true)
//            {
//                reader.Read();
//                if (reader.TokenType != JsonTokenType.EndArray)
//                {
//                    outList.Add(reader.GetString());
//                }
//                else break;
//            }
//            return outList;
//        }

//        private List<ISyntaxNode> ReadProperty<T>(System.Linq.Expressions.Expression<Func<T, List<ISyntaxNode>>> property, ref Utf8JsonReader reader, JsonSerializerOptions options)
//        {
//            List<ISyntaxNode> outList = new List<ISyntaxNode>();
//            ReadProperty(property.PropertyName(), ref reader, options);
//            if (reader.TokenType != JsonTokenType.StartArray)
//            {
//                throw new JsonException("Array expected!");
//            }
//            while (true)
//            {
//                reader.Read();
//                if (reader.TokenType != JsonTokenType.EndArray)
//                {
//                    outList.Add(this.Read(ref reader, typeof(ISyntaxNode), options));
//                }
//                else break;
//            }
//            return outList;
//        }

//        private ISyntaxNode ReadProperty<T>(System.Linq.Expressions.Expression<Func<T, ISyntaxNode>> property, ref Utf8JsonReader reader, JsonSerializerOptions options)
//        {
//            ReadProperty(property.PropertyName(), ref reader, options);
//            return this.Read(ref reader, typeof(ISyntaxNode), options);
//        }
//    }
//}