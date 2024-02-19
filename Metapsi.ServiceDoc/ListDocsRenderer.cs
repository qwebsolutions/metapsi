using Metapsi.Hyperapp;
using Metapsi.Syntax;
using Microsoft.AspNetCore.Http;
using Metapsi.Shoelace;
using Metapsi.Dom;
using System;
using System.Linq;
using System.Collections.Generic;
using Metapsi.Ui;
using static Metapsi.Hyperapp.HyperType;
using System.Linq.Expressions;
using MdsCommon.Controls;
using MdsCommon.HtmlControls;

namespace Metapsi
{
    public class ServerModel<T>
    {
        public Expression<Func<T, string>> IdProperty { get; set; }
        public string DescriptionHtml { get; set; } = string.Empty;
    }

    public class ListDocsPageModel<T>
    {
        public ServerModel<T> ServerModel { get; set; } = new();
        public ServiceDoc.ListDocsPage<T> ClientModel { get; set; } = new();
    }

    public class ListDocsRenderer<T> : HtmlPage<ListDocsPageModel<T>>
    {
        private const string IdEditDocument = "id-edit-document";
        private const string IdRemoveDocument = "id-remove-document";
        private string EntityName = typeof(T).Name;

        public override void FillHtml(ListDocsPageModel<T> dataModel, DocumentTag document)
        {
            document.Head.AddModuleStylesheet();

            var huhNode = document.Body.AddChild(new DivTag().SetAttribute("id", "huh"));

            document.Body.WithClass("fixed top-0 right-0 left-0 bottom-0");

            document.Body.AddChild(
                new HyperAppNode<ServiceDoc.ListDocsPage<T>>()
                {
                    Model = dataModel.ClientModel,
                    Render = (b,model) => OnRender(b, model, dataModel.ServerModel),
                    TakeoverNode = huhNode
                });
        }

        public Var<IVNode> OnRender(LayoutBuilder b, Var<ServiceDoc.ListDocsPage<T>> model, ServerModel<T> serverModel)
        {
            b.AddModuleStylesheet();

            var rows = b.Get(model, x => x.Documents);

            return b.Div(
                "",
                b.Div(
                    "flex relative flex-row items-center justify-center py-4 text-lg bg-gray-100 text-gray-700",
                    b.T(b.Concat(b.FormatLabel(b.Const(EntityName)), b.Const(" Service Overview"))),
                    b.H(
                        "sl-button",
                        (b, props) =>
                        {
                            b.SetDynamic(props, DynamicProperty.String("variant"), b.Const("text"));
                            b.AddClass(props, "absolute right-2 text-2xl ");//text-[color:var(--sl-color-primary-600)] hover:text-[color:var(--sl-color-primary-500)]

                            b.OnClickAction(props, b.MakeAction((SyntaxBuilder b, Var<ServiceDoc.ListDocsPage<T>> model) =>
                            {
                                return InitDocument(b, model);
                            }));
                        },
                        b.H(
                            "div",
                            (b, props) =>
                            {
                                b.AddClass(props, "flex w-6 h-6");
                                b.SetDynamic(props, Html.innerHTML, b.Const(Metapsi.Heroicons.Solid.PlusCircle));
                                b.SetDynamic(props, DynamicProperty.String("slot"), b.Const("prefix"));
                            }))),
                !string.IsNullOrEmpty(serverModel.DescriptionHtml)? this.DocDescriptionPanel(b, b.Const( serverModel.DescriptionHtml)) : b.VoidNode().As<IVNode>(),
                this.EditDocumentPopup(b, model, serverModel.IdProperty),
                this.RemoveDocumentPopup(b, serverModel.IdProperty),
                b.DataGrid<T>(b =>
                {
                    b.OnTable(b =>
                    {
                        b.FillFrom(
                            rows,
                            exceptColumns: new()
                            {
                                "Id"
                            });

                        b.SetData((b, data) =>
                        {
                            var autoColumns = b.Get(data, x => x.Columns);
                            var outColumns = b.NewCollection<ColumnData>();
                            b.Push(outColumns, b.NewObj<ColumnData>(b=>
                            {
                                b.Set(x => x.Name, "__actions__");
                                b.Set(x => x.TypeName, typeof(string).Name);
                            }));

                            b.PushRange(outColumns, autoColumns);

                            b.Set(data, x => x.Columns, outColumns);
                        });

                        b.Control.HeaderCell.OverrideChild((b, data, previous) =>
                        {
                            return b.If(
                                b.Get(data, x => x.Name == "__actions__"),
                                b => b.T(string.Empty),
                                b => previous(b, data));
                        });

                        b.Control.TableCell.OverrideChild(
                            (b, data, baseRenderer) =>
                            {
                                return
                                    b.If(
                                        b.Get(data, x => x.Column.Name == "__actions__"),
                                        b =>
                                        {
                                            return b.H("div",
                                                (b, props) =>
                                                {
                                                    b.AddClass(props, "flex flex-row items-center gap-2");
                                                },
                                                EditDocumentButton(b, b.Get(data, x=>x.Row), serverModel.IdProperty),
                                                DeleteDocumentButton(b, b.Get(data, x=>x.Row), serverModel.IdProperty));
                                        },
                                        b => baseRenderer(b, data));
                            });

                        b.Control.TableCell.EditProps((b, props) =>
                        {
                            b.AddClass(props, "border border-gray-200 p-4");
                        });

                        b.Control.HeaderCell.EditProps((b, props) =>
                        {
                            b.AddClass(props, "border border-gray-200 p-4");
                        });
                    });
                }));
        }

        Var<Func<T, string>> DefineGetId(SyntaxBuilder b, Expression<Func<T, string>> IdProperty)
        {
            return b.Def((SyntaxBuilder b, Var<T> item) =>
            {
                return b.If(
                    b.HasObject(item),
                    b => b.Get(item, IdProperty),
                    b => b.Const(string.Empty));
            });
        }

        public Var<IVNode> EditDocumentButton(LayoutBuilder b, Var<T> document, Expression<Func<T, string>> IdProperty)
        {
            return b.SlNode(
                "sl-icon-button",
                (b, props) =>
                {
                    b.OnClickAction(
                        props,
                        b.MakeAction((SyntaxBuilder b, Var<ServiceDoc.ListDocsPage<T>> model) =>
                        {
                            var editDocReference = b.Get(
                                model,
                                b.Get(document, IdProperty),
                                DefineGetId(b, IdProperty),
                                (model, id, getId) => model.Documents.Single(x => getId(x) == id));

                            b.Set(model, x => x.EditDocument, b.Clone(editDocReference));

                            var popup = b.GetElementById(b.Const(IdEditDocument));
                            b.SetDynamic(popup, DynamicProperty.Bool("open"), b.Const(true));
                            return b.Clone(model);

                        }));
                    b.SetDynamic(props, DynamicProperty.String("name"), b.Const("pencil-square"));
                });
        }

        public Var<IVNode> DeleteDocumentButton(LayoutBuilder b, Var<T> document, Expression<Func<T, string>> idProperty)
        {
            return b.SlNode(
                "sl-icon-button",
                (b, props) =>
                {
                    b.OnClickAction(
                        props,
                        b.MakeAction((SyntaxBuilder b, Var<ServiceDoc.ListDocsPage<T>> model) =>
                        {
                            var getId = DefineGetId(b, idProperty);
                            var editDocReference =
                            b.Get(
                                model,
                                b.Call(getId, document),
                                getId,
                                (model, id, getId) => model.Documents.Single(x => getId(x) == id));

                            b.Set(model, x => x.EditDocument, b.Clone(editDocReference));

                            var popup = b.GetElementById(b.Const(IdRemoveDocument));
                            b.SetDynamic(popup, DynamicProperty.Bool("open"), b.Const(true));
                            return b.Clone(model);

                        }));
                    b.SetDynamic(props, DynamicProperty.String("name"), b.Const("trash"));
                });
        }

        public Var<IVNode> DocDescriptionPanel(
            LayoutBuilder b,
            Var<string> summaryHtml)
        {
            return b.SlNode(
                "sl-details",
                (b, props) =>
                {
                    b.SetDynamic(props, DynamicProperty.String("summary"), b.Const("Description"));
                },
                b.H(
                    "span",
                    (b, props) =>
                    {
                        b.SetDynamic(props, Html.innerHTML, summaryHtml);
                    }));
        }

        public Var<IVNode> EditDocumentPopup(
            LayoutBuilder b,
            Var<ServiceDoc.ListDocsPage<T>> model,
            Expression<Func<T, string>> idProperty)
        {
            var getId = DefineGetId(b, idProperty);
            var isNew = b.Get(model, getId, (model, getId) => model.EditDocument == null || !model.Documents.Any(x => getId(x) == getId(model.EditDocument)));
            var caption = b.If(isNew, x => b.Const("Create new "), b => b.Const("Edit "));

            var buildContent = (LayoutBuilder b) => 
            b.Div(
                "flex flex-col gap-4",
                b.AutoEditForm(b.GetDataContext(model, x => x.EditDocument)),
                b.H(
                    "div",
                    (b, props) =>
                    {
                        // To make the buttons smaller at end
                        b.AddClass(props, "flex flex-row gap-2 justify-end");
                    },
                    b.H(
                        "sl-button",
                        (b, props) =>
                        {
                            b.SetDynamic(props, DynamicProperty.String("slot"), b.Const("footer"));
                            b.SetDynamic(props, DynamicProperty.String("variant"), b.Const("primary"));

                            b.OnClickAction(props, b.MakeAction((SyntaxBuilder b, Var<ServiceDoc.ListDocsPage<T>> model) =>
                            {
                                return SaveNewDocument(b, model);
                            }));
                        },
                        b.T("Save")))
                );

            return b.SlNode(
                "sl-dialog",
                (b, props) =>
                {
                    b.SetDynamic(props, DynamicProperty.String("label"), b.Concat(caption, b.ToLowercase(b.FormatLabel(b.Const(EntityName)))));
                    b.SetDynamic(props, Html.id, b.Const(IdEditDocument));
                },
                b.Optional(
                    b.HasObject(b.Get(model, x => x.EditDocument)),
                    b=> b.Call(buildContent)));
        }

        public Var<IVNode> RemoveDocumentPopup(
            LayoutBuilder b,
            Expression<Func<T, string>> idProperty)
        {
            var content =
                b.Div(
                "flex flex-col gap-4",
                b.T(
                    b.Concat(
                        b.Const("Are you sure you want to remove this "),
                        b.ToLowercase(b.FormatLabel(b.Const(EntityName))),
                        b.Const(" ?"))),
                b.H(
                    "div",
                    (b, props) =>
                    {
                        // To make the buttons smaller at end
                        b.AddClass(props, "flex flex-row gap-2 justify-end");
                    },
                    b.H(
                        "sl-button",
                        (b, props) =>
                        {
                            b.SetDynamic(props, DynamicProperty.String("slot"), b.Const("footer"));
                            b.SetDynamic(props, DynamicProperty.String("variant"), b.Const("danger"));
                            b.OnClickAction(props, b.MakeAction((SyntaxBuilder b, Var<ServiceDoc.ListDocsPage<T>> model) =>
                            {
                                //b.Remove(b.Get(model, x => x.Documents), b.Get(model, model => model.Documents.Single(x => x.Id == model.EditDocument.Id)));
                                return RemoveDocument(b, model, idProperty);
                            }));
                        },
                        b.T("Remove")))
                );

            return b.SlNode(
                "sl-dialog",
                (b, props) =>
                {
                    b.SetDynamic(props, DynamicProperty.String("label"), b.Concat(b.Const("Remove "), b.ToLowercase(b.FormatLabel(b.Const(EntityName)))));
                    b.SetDynamic(props, Html.id, b.Const(IdRemoveDocument));
                },
                content);
        }

        public Var<HyperType.StateWithEffects> RemoveDocument(
            SyntaxBuilder b,
            Var<ServiceDoc.ListDocsPage<T>> model,
            Expression<Func<T, string>> idProperty)
        {
            var getId = DefineGetId(b, idProperty);

            var onResult = b.MakeAction(
                        (SyntaxBuilder b, Var<ServiceDoc.ListDocsPage<T>> model, Var<ServiceDoc.DeleteResult<T>> result) =>
                        {
                            var editPopup = b.GetElementById(b.Const(IdEditDocument));
                            b.SetDynamic(editPopup, DynamicProperty.Bool("open"), b.Const(false));

                            var removePopup = b.GetElementById(b.Const(IdRemoveDocument));
                            b.SetDynamic(removePopup, DynamicProperty.Bool("open"), b.Const(false));

                            var editedDoc = b.Get(model, getId, (model, getId) => model.Documents.Single(x => getId(x) == getId(model.EditDocument)));

                            b.Remove(b.Get(model, x => x.Documents), editedDoc);

                            return RefreshAllDocuments(b);
                        });

            var onError = b.MakeAction(
                        (SyntaxBuilder b, Var<ServiceDoc.ListDocsPage<T>> model, Var<ApiError> apiError) =>
                        {
                            var editPopup = b.GetElementById(b.Const(IdEditDocument));
                            b.SetDynamic(editPopup, DynamicProperty.Bool("open"), b.Const(false));

                            var removePopup = b.GetElementById(b.Const(IdRemoveDocument));
                            b.SetDynamic(removePopup, DynamicProperty.Bool("open"), b.Const(false));
                            return RefreshAllDocuments(b);
                        });

            var callApi = b.CallApi<ServiceDoc.ListDocsPage<T>, ServiceDoc.DeleteResult<T>, string>(
                    ServiceDoc.GetDocApi<T>().Delete,
                    b.Call(getId, b.Get(model, x => x.EditDocument)),
                    onResult,
                    onError);

            return b.MakeStateWithEffects(
                model,
                b.MakeEffect<ServiceDoc.ListDocsPage<T>>(b.Def(callApi)));
        }

        public Var<HyperType.StateWithEffects> SaveNewDocument(SyntaxBuilder b, Var<ServiceDoc.ListDocsPage<T>> model)
        {
            var onResult = b.MakeAction(
                        (SyntaxBuilder b, Var<ServiceDoc.ListDocsPage<T>> model, Var<ServiceDoc.SaveResult<T>> result) =>
                        {
                            var editPopup = b.GetElementById(b.Const(IdEditDocument));
                            b.SetDynamic(editPopup, DynamicProperty.Bool("open"), b.Const(false));

                            var removePopup = b.GetElementById(b.Const(IdRemoveDocument));
                            b.SetDynamic(removePopup, DynamicProperty.Bool("open"), b.Const(false));

                            b.Push(b.Get(model, x => x.Documents), b.Get(model, x => x.EditDocument));
                            return RefreshAllDocuments(b);
                        });

            var onError = b.MakeAction(
                        (SyntaxBuilder b, Var<ServiceDoc.ListDocsPage<T>> model, Var<ApiError> apiError) =>
                        {
                            var editPopup = b.GetElementById(b.Const(IdEditDocument));
                            b.SetDynamic(editPopup, DynamicProperty.Bool("open"), b.Const(false));

                            var removePopup = b.GetElementById(b.Const(IdRemoveDocument));
                            b.SetDynamic(removePopup, DynamicProperty.Bool("open"), b.Const(false));
                            return RefreshAllDocuments(b);
                        });

            var callApi = b.CallApi<ServiceDoc.ListDocsPage<T>, ServiceDoc.SaveResult<T>, T>(
                    ServiceDoc.GetDocApi<T>().Save,
                    b.Get(model, x => x.EditDocument),
                    onResult,
                    onError);

            return b.MakeStateWithEffects(
                model,
                b.MakeEffect<ServiceDoc.ListDocsPage<T>>(b.Def(callApi)));
        }


        public Var<HyperType.StateWithEffects> InitDocument(SyntaxBuilder b, Var<ServiceDoc.ListDocsPage<T>> model)
        {
            var onResult = b.MakeAction(
                        (SyntaxBuilder b, Var<ServiceDoc.ListDocsPage<T>> model, Var<T> result) =>
                        {
                            b.Set(model, x => x.EditDocument, result);
                            var popup = b.GetElementById(b.Const(IdEditDocument));
                            b.SetDynamic(popup, DynamicProperty.Bool("open"), b.Const(true));
                            return b.Clone(model);
                        });

            var onError = b.MakeAction(
                        (SyntaxBuilder b, Var<ServiceDoc.ListDocsPage<T>> model, Var<ApiError> apiError) =>
                        {
                            var editPopup = b.GetElementById(b.Const(IdEditDocument));
                            b.SetDynamic(editPopup, DynamicProperty.Bool("open"), b.Const(false));

                            var removePopup = b.GetElementById(b.Const(IdRemoveDocument));
                            b.SetDynamic(removePopup, DynamicProperty.Bool("open"), b.Const(false));
                            return b.Clone(model);
                        });

            var callApi = b.CallApi<ServiceDoc.ListDocsPage<T>, T>(
                Register.InitDocument<T>(),
                onResult,
                onError);

            return b.MakeStateWithEffects(
                model,
                b.MakeEffect<ServiceDoc.ListDocsPage<T>>(b.Def(callApi)));
        }

        public Var<HyperType.Action<ServiceDoc.ListDocsPage<T>>> RefreshAllDocuments(SyntaxBuilder b)
        {
            return b.MakeAction((SyntaxBuilder b, Var<ServiceDoc.ListDocsPage<T>> model) =>
            {
                var onResult = b.MakeAction(
                        (SyntaxBuilder b, Var<ServiceDoc.ListDocsPage<T>> model, Var<List<T>> result) =>
                        {
                            b.Set(model, x => x.Documents, result);
                            return b.Clone(model);
                        });

                var onError = b.MakeAction(
                            (SyntaxBuilder b, Var<ServiceDoc.ListDocsPage<T>> model, Var<ApiError> apiError) =>
                            {
                                return b.Clone(model);
                            });

                var callApi = b.CallApi<ServiceDoc.ListDocsPage<T>, List<T>>(
                    Register.ListDocuments<T>(),
                    onResult,
                    onError);

                return b.MakeStateWithEffects(
                    model,
                    b.MakeEffect<ServiceDoc.ListDocsPage<T>>(b.Def(callApi)));
            });
        }
    }
}