using Metapsi.Syntax;
using System.Collections.Generic;

namespace Metapsi.Hyperapp
{
    public static class DataTable
    {
        public class Column
        {
            public string Name { get; set; }
            public string Caption { get; set; }
            public string Class { get; set; }
        }

        public class Style
        {
            public string Container { get; set; } = "bg-white p-4 rounded";
            public string Thead { get; set; } = "text-left text-sm text-gray-500 bg-white drop-shadow-sm";
            public string Th { get; set; } = "py-4 border-b border-gray-300 bg-white";
            public string Td { get; set; } = "border-b border-gray-300";
        }

        public class Props<TRow>
        {
            public List<Column> Columns { get; set; } = new();
            public List<TRow> Rows { get; set; } = new();
            public System.Func<TRow, Column, HyperNode> CreateCell { get; set; }
            public System.Func<TRow, HyperNode> CreateRow { get; set; }
            public Style Style { get; set; } = new Style();
        }

        internal static Var<HyperNode> Render<TRow>(BlockBuilder b, Var<Props<TRow>> props)
        {
            var style = b.Get(props, x => x.Style);

            //Function<HyperNode, object, Column> cellBuilder = b.Get<Function<HyperNode, object, Column>>(props, nameof(Props.CreateCell));
            var customCreateRow = b.Get(props, x => x.CreateRow);
            var createRow = b.If(b.IsEmpty(customCreateRow.As<object>()),
                b => b.Def((BlockBuilder b, Var<TRow> row) => b.Node("tr")),
                b => customCreateRow);

            var container = b.Div("w-full");
            b.AddClass(container, b.Get(style, x => x.Container));

            var table = b.Add(container, b.Node("table", "border-collapse w-full overflow-hidden"));
            var thead = b.Add(table, b.Node("thead", ""));
            b.AddClass(thead, b.Get(style, x => x.Thead));

            var columns = b.Get(props, x => x.Columns);

            b.Foreach(columns, (b, col) =>
            {
                var th = b.Add(thead, b.Node("th", b.Get(style, x => x.Th)));
                b.AddClass(th, b.Get(col, x => x.Class));
                var caption = b.Get(col, x => x.Caption);
                var captionRef = b.NewObj<Reference<string>>(x => x.Set(x => x.Value, caption));

                b.If(b.IsEmpty(caption), b => b.Set(captionRef, x=>x.Value, b.Get(col, x => x.Name)));

                b.Add(th, b.Text(b.Get(captionRef, x => x.Value)));
            });

            var tbody = b.Add(table, b.Node("tbody", ""));
            var rows = b.Get(props, x => x.Rows);
            b.Foreach(rows, (b, record) =>
            {
                var tr = b.Add(tbody, b.Call(createRow, record));
                b.AddClass(tr, "group");
                b.Foreach(columns, (b, column) =>
                {
                    var td = b.Add(tr, b.Node("td", b.Get(style, x => x.Td)));
                    var createCell = b.Get(props, x => x.CreateCell);
                    var cellContent = b.Call(createCell, record, column);
                    b.Add(td, cellContent);
                });
            });

            return container;
        }
    }

    public static partial class Controls
    {
        public static Var<HyperNode> DataTable<TRow>(
            this BlockBuilder b,
            Var<DataTable.Props<TRow>> props)
        {
            return b.Call(Hyperapp.DataTable.Render, props);
        }

        public static Var<HyperNode> VPadded4(this BlockBuilder b, Var<HyperNode> content)
        {
            var container = b.Div("py-4");
            b.Add(container, content);
            return container;
        }


        public static void AddColumn<TRow>(
            this Modifier<DataTable.Props<TRow>> props,
            string name,
            System.Action<Modifier<DataTable.Column>> optional = null)
        {
            props.Update(b => b.Columns, b =>
            {
                b.Add(b =>
                {
                    b.Set(x => x.Name, name);
                    b.Update(optional);
                });
            });
        }

        public static void AddColumn<TRow>(
           this Modifier<DataTable.Props<TRow>> props,
           string name,
           string caption,
           System.Action<Modifier<DataTable.Column>> optional = null)
        {
            AddColumn(props, name, b =>
            {
                b.Set(x => x.Caption, caption);
                b.Update(optional);
            });
        }

        public static void SetRows<TRow>(
            this Modifier<DataTable.Props<TRow>> props,
            Var<List<TRow>> rows)
        {
            props.Set(x => x.Rows, rows);
        }

        public static void SetRenderCell<TRow>(
            this Modifier<DataTable.Props<TRow>> props,
            Var<System.Func<TRow, DataTable.Column, HyperNode>> cellBuilder)
        {
            props.Set(x => x.CreateCell, cellBuilder);
        }

        public static Var<System.Func<TRow, DataTable.Column, HyperNode>> RenderCell<TRow>(this BlockBuilder b, System.Func<BlockBuilder, Var<TRow>, Var<DataTable.Column>, Var<HyperNode>> renderer)
        {
            return b.Def(renderer);
        }
    }
}

