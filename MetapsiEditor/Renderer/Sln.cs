//using Microsoft.CodeAnalysis;
//using System.Collections.Generic;
//using System.Linq;
////using Metapsi.Hyperapp;
////using Metapsi.JavaScript;
//using Metapsi;
//using Metapsi.Ui;
//using Microsoft.AspNetCore.Components.RenderTree;

//public static partial class Render
//{
//    public class Sln : HtmlPage<Handler.Sln.Model>
//    {
//        public override IHtmlNode GetHtml(Handler.Sln.Model dataModel)
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
//                                new HtmlText(){Text = "Projects"}
//                            }
//                        },
//                        new HtmlTag()
//                        {
//                            Tag = "div",
//                            Children = dataModel.Projects.Projects.Select(
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
//                                        new HtmlTag()
//                                        {
//                                            Tag = "a",
//                                            Attributes = new(
//                                                new List<KeyValuePair<string, string>>()
//                                            {
//                                                new KeyValuePair<string, string>(
//                                                    "href",Metapsi.Route.Path<Metapsi.Live.Route.FocusRenderer,string>(x))
//                                            }),
//                                            Children = new ()
//                                            {
//                                                new HtmlText()
//                                                {
//                                                    Text = x
//                                                }
//                                            }
//                                        }
//                                    }
//                                } as IHtmlNode).ToList()
//                        },
//                    }
//                });

//            return new HtmlTag("html") { Children = htmlPage };
//        }
//    }
//}