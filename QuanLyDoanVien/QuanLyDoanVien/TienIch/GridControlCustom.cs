using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using DevExpress.Data.Async.Helpers;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Registrator;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using QuanLyDoanVien.DuLieu;

namespace QuanLyDoanVien.TienIch
{
    [ToolboxItem(true)]
    public class GridControlCustom : GridControl
    {
        public GridControlCustom()
        {
            Load += GridControlCustom_Load;
        }
        private void GridControlCustom_Load(object sender, EventArgs e)
        {
            var view = MainView as GridViewCustom;
            if (view == null) return;

            foreach (GridColumn c in view.Columns)
            {
                c.OptionsFilter.AutoFilterCondition = AutoFilterCondition.Contains;
                if (c.ColumnType == typeof (DateTime) || c.FieldName == view.KeyColumn)
                {
                    c.AppearanceCell.Options.UseTextOptions = true;
                    c.AppearanceCell.TextOptions.HAlignment = HorzAlignment.Center;
                }
            }
        }
        protected override BaseView CreateDefaultView()
        {
            return CreateView("GridViewCustom");
        }
        protected override void RegisterAvailableViewsCore(InfoCollection collection)
        {
            base.RegisterAvailableViewsCore(collection);
            collection.Add(new GridViewCustomInfoRegistrator());
        }
    }
    public class GridViewCustom : GridView
    {
        public GridViewCustom() : this(null)
        {
        }
        public GridViewCustom(GridControl grid)
            : base(grid)
        {
            BeginInit();
            OptionsFind.AlwaysVisible = false;
            OptionsFind.FindMode = FindMode.Always;
            OptionsFind.HighlightFindResults = true;
            OptionsView.ShowAutoFilterRow = true;
            OptionsView.ShowFooter = false;
            OptionsView.ShowGroupPanel = false;
            OptionsView.ColumnAutoWidth = true;
            OptionsBehavior.AllowIncrementalSearch = false;
            OptionsView.EnableAppearanceEvenRow = true;
            OptionsDetail.EnableMasterViewMode = false;

            AppearancePrint.HeaderPanel.Options.UseTextOptions = true;
            AppearancePrint.HeaderPanel.TextOptions.HAlignment = HorzAlignment.Center;
            AppearancePrint.HeaderPanel.TextOptions.VAlignment = VertAlignment.Center;

            Appearance.HeaderPanel.Options.UseTextOptions = true;
            Appearance.HeaderPanel.TextOptions.HAlignment = HorzAlignment.Center;
            Appearance.HeaderPanel.TextOptions.VAlignment = VertAlignment.Center;

            Appearance.FooterPanel.ForeColor = Color.Blue;
            Appearance.FooterPanel.Options.UseForeColor = true;

            GroupFormat = "[#image]{1} {2}";
            IndicatorWidth = 40;
            FixedLineWidth = 1;

            OptionsSelection.MultiSelect = true;
            OptionsSelection.InvertSelection = true;
            OptionsSelection.CheckBoxSelectorColumnWidth = 40;
            OptionsSelection.ResetSelectionClickOutsideCheckboxSelector = true;

            OptionsBehavior.AutoExpandAllGroups = true;

            CustomDrawRowIndicator += GridViewCustom_CustomDrawRowIndicator;
            FocusedRowChanged += GridView_FocusedRowChanged;
            EndInit();
        }
        /// <summary>
        ///     FieldName của cột Khóa, có tác dụng không cho sửa dữ liệu đã nhập của cột đó
        /// </summary>
        [Description("FieldName của cột Khóa, có tác dụng không cho sửa dữ liệu đã nhập của cột đó")]
        public string KeyColumn { get; set; }
        protected override string ViewName
        {
            get { return "GridViewCustom"; }
        }
        private void GridView_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
            if (string.IsNullOrEmpty(KeyColumn)) return;
            if (Columns[KeyColumn] == null) return;
            Columns[KeyColumn].OptionsColumn.AllowEdit = e.FocusedRowHandle < 0;

            var gw = sender as GridViewCustom;
            if (gw == null) return;
            var obj = gw.GetFocusedRow() as BaseObject;
            if (obj == null) return;
            Columns[KeyColumn].OptionsColumn.AllowEdit = obj.IsNewObject;
        }
        /// <summary>
        ///     Hàm lấy một đối tượng T đang focus
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public T GetFocusObjectFromFeedBackSource<T>()
        {
            var obj = GetFocusedRow() as ReadonlyThreadSafeProxyForObjectFromAnotherThread;
            if (obj == null) return default(T);
            return (T) obj.OriginalRow;
        }
        /// <summary>
        ///     Hàm lấy về 1 list các đối tượng T đang focus
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns>List<T></returns>
        public List<T> GetFocusManyObjectFromFeedBackSource<T>()
        {
            var idx = GetSelectedRows();
            var list = new List<T>();
            for (var i = 0; i < idx.Length; i++)
            {
                var obj = GetRow(idx[i]) as ReadonlyThreadSafeProxyForObjectFromAnotherThread;
                if (obj == null) continue;
                if (obj.OriginalRow == null) continue;

                list.Add((T) obj.OriginalRow);
            }

            return list;
        }
        private void GridViewCustom_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator && e.RowHandle >= 0)
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
        }
        private void GridViewCustom_CustomDrawCell(object sender, RowCellCustomDrawEventArgs e)
        {
            if (e.Column.ColumnType == typeof (DateTime))
            {
                e.Appearance.TextOptions.HAlignment = HorzAlignment.Center;
                if (e.Column.ColumnEdit != null)
                    e.Column.ColumnEdit.Appearance.TextOptions.HAlignment = HorzAlignment.Center;
            }
        }
        public bool HasError()
        {
            for (var i = 0; i < RowCount; i++)
                foreach (GridColumn col in Columns)
                    if (GetColumnError(i, col) != string.Empty
                        && GetColumnErrorType(i, col) == DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
                        return true;

            return false;
        }
        public bool HasWarning()
        {
            for (var i = 0; i < RowCount; i++)
                foreach (GridColumn col in Columns)
                    if (GetColumnErrorType(i, col) == DevExpress.XtraEditors.DXErrorProvider.ErrorType.Warning)
                        return true;

            return false;
        }
        public string GetWarningText()
        {
            for (var i = 0; i < RowCount; i++)
                foreach (GridColumn col in Columns)
                    if (GetColumnErrorType(i, col) == DevExpress.XtraEditors.DXErrorProvider.ErrorType.Warning)
                        return GetColumnError(i, col);

            return string.Empty;
        }
    }
    public class GridViewCustomInfoRegistrator : GridInfoRegistrator
    {
        public override string ViewName
        {
            get { return "GridViewCustom"; }
        }
        public override BaseView CreateView(GridControl grid)
        {
            return new GridViewCustom(grid);
        }
    }
}