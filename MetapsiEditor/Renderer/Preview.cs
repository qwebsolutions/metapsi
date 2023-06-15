//using Microsoft.CodeAnalysis;
//using System.Collections.Generic;
//using System.Linq;
////using Metapsi.Hyperapp;
////using Metapsi.JavaScript;
//using Metapsi;
//using Metapsi.Ui;


//public class PreviewPage : HtmlPage<PreviewHandler.Model>
//{
//    public override HtmlPage GetHtml(PreviewHandler.Model dataModel)
//    {
//        HtmlPage htmlPage = new HtmlPage();

//        htmlPage.Html.Add(
//            new HtmlTag()
//            {
//                Tag = "head",
//                Children = new List<IHtmlNode>()
//                {
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
//                }
//            });
//        htmlPage.Html.Add(
//            new HtmlTag()
//            {
//                Tag = "body",
//                Children = new List<IHtmlNode>()
//                {
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
//                }
//            });

//        return htmlPage;
//    }
//}