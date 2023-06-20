//using Microsoft.CodeAnalysis;
//using System.Collections.Generic;
//using System.Linq;
////using Metapsi.Hyperapp;
////using Metapsi.JavaScript;
//using Metapsi;
//using Metapsi.Ui;

//public static partial class Render
//{
//    public class FocusRenderer : HtmlPage<Handler.FocusRenderer.Model>
//    {
//        public override IHtmlNode GetHtml(Handler.FocusRenderer.Model dataModel)
//        {
//            var htmlPage = new List<IHtmlNode>();

//            htmlPage.Add(
//                new HtmlTag()
//                {
//                    Tag = "head",
//                    Children = new List<IHtmlNode>()
//                    {
//                        new HtmlTag()
//                        {
//                            Tag = "title",
//                            Children = new List<IHtmlNode>()
//                            {
//                                new HtmlText()
//                                {
//                                    Text = "Edit"
//                                }
//                            }
//                        }
//                    }
//                });
//            htmlPage.Add(
//                new HtmlTag()
//                {
//                    Tag = "body",
//                    Children = new List<IHtmlNode>()
//                    {
//                        new HtmlTag()
//                        {
//                            Tag = "div",
//                            Children = new()
//                            {
//                                new HtmlText(){Text = "renderer"}
//                            }
//                        },
//                        new HtmlTag()
//                        {
//                            Tag = "h1",
//                            Children = new()
//                            {
//                                new HtmlText()
//                                {
//                                    Text = dataModel.Renderer.RendererName
//                                }
//                            }
//                        },
//                        new HtmlTag()
//                        {
//                            Tag = "div",
//                            Children = new()
//                            {
//                                new HtmlText()
//                                {
//                                    Text = "Routes"
//                                }
//                            }
//                        },
//                        new HtmlTag()
//                        {
//                            Tag = "div",
//                            Children = dataModel.Routes.Routes.Select(
//                                x=>
//                                new HtmlTag()
//                                {
//                                    Tag =
//                                    "div",
//                                    Children = new()
//                                    {
//                                        new HtmlText(){
//                                            Text = x
//                                        }
//                                    }
//                                } as IHtmlNode).ToList()
//                        },
//                        new HtmlTag()
//                        {
//                            Tag = "div",
//                            Children = new()
//                            {
//                                new HtmlText()
//                                {
//                                    Text = "Renderers"
//                                }
//                            }
//                        },
//                        new HtmlTag()
//                        {
//                            Tag = "div",
//                            Children = dataModel.Renderers.Renderers.Select(
//                                x=>
//                                new HtmlTag()
//                                {
//                                    Tag =
//                                    "div",
//                                    Children = new()
//                                    {
//                                        new HtmlText(){
//                                            Text = x
//                                        }
//                                    }
//                                } as IHtmlNode).ToList()
//                        },
//                        new HtmlTag("div").AddAttribute("id", "app")
//                    }
//                });

//            return new HtmlTag("html") { Children = htmlPage };
//        }
//    }
//}