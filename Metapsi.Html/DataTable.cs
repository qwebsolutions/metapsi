using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Metapsi.Html
{
    public class DataTableBuilder<TRow>
    {
        public Action<PropsBuilder<HtmlTable>> SetTableProps { get; set; } = b => { };
        public Action<PropsBuilder<HtmlThead>> SetTheadProps { get; set; } = b => { };
        public Action<PropsBuilder<HtmlTh>, Var<string>> SetThProps { get; set; } = (b, column) => { };
        public Action<PropsBuilder<HtmlTbody>> SetTbodyProps { get; set; } = b => { };
        public Action<PropsBuilder<HtmlTr>, Var<TRow>> SetTrProps { get; set; } = (b, row) => { };
        public Action<PropsBuilder<HtmlTd>, Var<TRow>, Var<string>> SetTdProps { get; set; } = (b, row, column) => { };

        public Func<LayoutBuilder, Var<string>, Var<IVNode>> CreateHeaderCell { get; set; } = (b, column) => b.HtmlSpanText(b => { }, column);
        public Func<LayoutBuilder, Var<TRow>, Var<string>, Var<IVNode>> CreateDataCell { get; set; } = (b, row, column) => b.HtmlSpanText(b => { }, b.GetProperty<string>(row, column));

        public DataTableBuilder<TRow> Clone()
        {
            return new DataTableBuilder<TRow>()
            {
                CreateDataCell = CreateDataCell,
                CreateHeaderCell = CreateHeaderCell,
                SetTableProps = SetTableProps,
                SetTbodyProps = SetTbodyProps,
                SetTdProps = SetTdProps,
                SetTheadProps = SetTheadProps,
                SetThProps = SetThProps,
                SetTrProps = SetTrProps
            };
        }
    }

    public class DataTable
    {
        public static List<string> GetColumns<TRow>()
        {
            var properties = typeof(TRow).GetProperties(System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Instance);
            return properties.Select(x => x.Name).ToList();
        }
    }

    public static class DataTableControl
    {
        public static Var<IVNode> DataTable<TRow>(this LayoutBuilder b, DataTableBuilder<TRow> tableBuilder, Var<List<TRow>> rows, Var<List<string>> columns = null)
        {
            if (columns == null)
                columns = b.Const(Metapsi.Html.DataTable.GetColumns<TRow>());

            return b.HtmlTable(
                tableBuilder.SetTableProps,
                b.HtmlThead(
                    tableBuilder.SetTheadProps,
                    b.Map(
                        columns,
                        (b, column) => b.HtmlTh(
                            b => tableBuilder.SetThProps(b, column),
                            b.Call(tableBuilder.CreateHeaderCell, column)))),
                b.HtmlTbody(
                    tableBuilder.SetTbodyProps,
                    b.Map(
                        rows, (b, row) =>
                        b.HtmlTr(
                            b => tableBuilder.SetTrProps(b, row),
                            b.Map(
                                columns, (b, column) =>
                                b.HtmlTd(
                                    b => tableBuilder.SetTdProps(b, row, column),
                                    b.Call(tableBuilder.CreateDataCell, row, column)))))));
        }

        public static Var<IVNode> DataTable<TRow>(this LayoutBuilder b, DataTableBuilder<TRow> tableBuilder, Var<List<TRow>> rows, params string[] columns)
        {
            return b.DataTable(tableBuilder, rows, b.Const(columns.ToList()));
        }

        public static void OverrideHeaderCell<TRow>(this DataTableBuilder<TRow> tableBuilder, string columnName, Func<LayoutBuilder, Var<IVNode>> cellBuilder)
        {
            var prevBuilder = tableBuilder.CreateHeaderCell;
            tableBuilder.CreateHeaderCell = (LayoutBuilder b, Var<string> column) =>
            {
                return b.If(
                    b.AreEqual(column, b.Const(columnName)),
                    b =>
                    {
                        return b.Call(cellBuilder);
                    },
                    b => b.Call(prevBuilder, column));
            };
        }

        public static void OverrideDataCell<TRow>(this DataTableBuilder<TRow> tableBuilder, string columnName, Func<LayoutBuilder, Var<TRow>, Var<IVNode>> cellBuilder)
        {
            var prevBuilder = tableBuilder.CreateDataCell;
            tableBuilder.CreateDataCell = (LayoutBuilder b, Var<TRow> row, Var<string> column) =>
            {
                return b.If(
                    b.AreEqual(column, b.Const(columnName)),
                    b =>
                    {
                        return b.Call(cellBuilder, row);
                    },
                    b => b.Call(prevBuilder, row, column));
            };
        }

        public static void AddTrProps<TRow>(this DataTableBuilder<TRow> tableBuilder, Action<PropsBuilder<HtmlTr>, Var<TRow>> setProps)
        {
            var prevProps = tableBuilder.SetTrProps;
            tableBuilder.SetTrProps = (b, row) =>
            {
                prevProps(b, row);
                setProps(b, row);
            };
        }

        public static void AddTdProps<TRow>(this DataTableBuilder<TRow> tableBuilder, Action<PropsBuilder<HtmlTd>, Var<TRow>, Var<string>> setProps)
        {
            var prevProps = tableBuilder.SetTdProps;
            tableBuilder.SetTdProps = (b, row, column) =>
            {
                prevProps(b, row, column);
                setProps(b, row, column);
            };
        }
    }
}

