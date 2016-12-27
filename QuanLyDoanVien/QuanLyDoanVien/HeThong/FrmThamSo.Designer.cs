namespace QuanLyDoanVien.HeThong
{
    partial class FrmThamSo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmThamSo));
            this.xpcParam = new DevExpress.Xpo.XPCollection(this.components);
            this.gcParam = new QuanLyDoanVien.TienIch.GridControlCustom();
            this.gvParam = new QuanLyDoanVien.TienIch.GridViewCustom();
            this.colParamCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colValueType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOptionValue = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAllowChange = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colParamCategory = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ricbDataType = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.ricbCategory = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.rCheckEdit = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.rDateEdit = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.rSpinEdit = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            ((System.ComponentModel.ISupportInitialize)(this.UOW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpcParam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcParam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvParam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ricbDataType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ricbCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rCheckEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rDateEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rDateEdit.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rSpinEdit)).BeginInit();
            this.SuspendLayout();
            // 
            // TB
            // 
            this.TB.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnLuu, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnDong, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.TB.OptionsBar.AllowQuickCustomization = false;
            this.TB.OptionsBar.DrawBorder = false;
            this.TB.OptionsBar.DrawDragBorder = false;
            this.TB.OptionsBar.UseWholeRow = true;
            // 
            // btnThem
            // 
            this.btnThem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.Image")));
            this.btnThem.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.LargeImage")));
            // 
            // btnSua
            // 
            this.btnSua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.ImageOptions.Image")));
            this.btnSua.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnSua.ImageOptions.LargeImage")));
            // 
            // btnXoa
            // 
            this.btnXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.Image")));
            this.btnXoa.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.LargeImage")));
            // 
            // btnLuu
            // 
            this.btnLuu.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.btnLuu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.ImageOptions.Image")));
            this.btnLuu.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnLuu.ImageOptions.LargeImage")));
            // 
            // btnDong
            // 
            this.btnDong.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.btnDong.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDong.ImageOptions.Image")));
            this.btnDong.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDong.ImageOptions.LargeImage")));
            // 
            // btnXuatExcel
            // 
            this.btnXuatExcel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXuatExcel.ImageOptions.Image")));
            this.btnXuatExcel.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnXuatExcel.ImageOptions.LargeImage")));
            // 
            // btnXemVaIn
            // 
            this.btnXemVaIn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXemVaIn.ImageOptions.Image")));
            this.btnXemVaIn.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnXemVaIn.ImageOptions.LargeImage")));
            // 
            // btnNap
            // 
            this.btnNap.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnNap.ImageOptions.Image")));
            this.btnNap.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnNap.ImageOptions.LargeImage")));
            // 
            // xpcParam
            // 
            this.xpcParam.DisplayableProperties = "ParamCode;ValueType;OptionValue;AllowChange;ParamCategory";
            this.xpcParam.ObjectType = typeof(QuanLyDoanVien.DuLieu.Param);
            this.xpcParam.Session = this.UOW;
            // 
            // gcParam
            // 
            this.gcParam.DataSource = this.xpcParam;
            this.gcParam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcParam.Location = new System.Drawing.Point(0, 0);
            this.gcParam.MainView = this.gvParam;
            this.gcParam.MenuManager = this.BM;
            this.gcParam.Name = "gcParam";
            this.gcParam.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.ricbDataType,
            this.ricbCategory,
            this.rCheckEdit,
            this.rDateEdit,
            this.rSpinEdit});
            this.gcParam.Size = new System.Drawing.Size(584, 333);
            this.gcParam.TabIndex = 4;
            this.gcParam.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvParam});
            // 
            // gvParam
            // 
            this.gvParam.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Blue;
            this.gvParam.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gvParam.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gvParam.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvParam.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gvParam.AppearancePrint.HeaderPanel.Options.UseTextOptions = true;
            this.gvParam.AppearancePrint.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvParam.AppearancePrint.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gvParam.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colParamCode,
            this.colValueType,
            this.colOptionValue,
            this.colAllowChange,
            this.colParamCategory});
            this.gvParam.FixedLineWidth = 1;
            this.gvParam.GridControl = this.gcParam;
            this.gvParam.GroupCount = 1;
            this.gvParam.GroupFormat = "[#image]{1} {2}";
            this.gvParam.IndicatorWidth = 40;
            this.gvParam.KeyColumn = null;
            this.gvParam.Name = "gvParam";
            this.gvParam.OptionsBehavior.AutoExpandAllGroups = true;
            this.gvParam.OptionsDetail.EnableMasterViewMode = false;
            this.gvParam.OptionsFind.FindMode = DevExpress.XtraEditors.FindMode.Always;
            this.gvParam.OptionsSelection.CheckBoxSelectorColumnWidth = 40;
            this.gvParam.OptionsSelection.InvertSelection = true;
            this.gvParam.OptionsSelection.MultiSelect = true;
            this.gvParam.OptionsSelection.ResetSelectionClickOutsideCheckboxSelector = true;
            this.gvParam.OptionsView.EnableAppearanceEvenRow = true;
            this.gvParam.OptionsView.ShowAutoFilterRow = true;
            this.gvParam.OptionsView.ShowGroupPanel = false;
            this.gvParam.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colParamCategory, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gvParam.CustomRowCellEdit += new DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventHandler(this.gvParam_CustomRowCellEdit);
            this.gvParam.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gvParam_FocusedRowChanged);
            this.gvParam.FocusedColumnChanged += new DevExpress.XtraGrid.Views.Base.FocusedColumnChangedEventHandler(this.gvParam_FocusedColumnChanged);
            this.gvParam.RowCellDefaultAlignment += new DevExpress.XtraGrid.Views.Base.RowCellAlignmentEventHandler(this.gvParam_RowCellDefaultAlignment);
            // 
            // colParamCode
            // 
            this.colParamCode.FieldName = "ParamCode";
            this.colParamCode.Name = "colParamCode";
            this.colParamCode.OptionsColumn.AllowEdit = false;
            this.colParamCode.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colParamCode.Visible = true;
            this.colParamCode.VisibleIndex = 0;
            this.colParamCode.Width = 184;
            // 
            // colValueType
            // 
            this.colValueType.ColumnEdit = this.ricbDataType;
            this.colValueType.FieldName = "ValueType";
            this.colValueType.Name = "colValueType";
            this.colValueType.OptionsColumn.AllowEdit = false;
            this.colValueType.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colValueType.Visible = true;
            this.colValueType.VisibleIndex = 1;
            this.colValueType.Width = 79;
            // 
            // colOptionValue
            // 
            this.colOptionValue.FieldName = "OptionValue";
            this.colOptionValue.Name = "colOptionValue";
            this.colOptionValue.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colOptionValue.Visible = true;
            this.colOptionValue.VisibleIndex = 2;
            this.colOptionValue.Width = 194;
            // 
            // colAllowChange
            // 
            this.colAllowChange.FieldName = "AllowChange";
            this.colAllowChange.Name = "colAllowChange";
            this.colAllowChange.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colAllowChange.Visible = true;
            this.colAllowChange.VisibleIndex = 3;
            this.colAllowChange.Width = 85;
            // 
            // colParamCategory
            // 
            this.colParamCategory.ColumnEdit = this.ricbCategory;
            this.colParamCategory.FieldName = "ParamCategory";
            this.colParamCategory.Name = "colParamCategory";
            this.colParamCategory.OptionsColumn.AllowEdit = false;
            this.colParamCategory.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colParamCategory.Visible = true;
            this.colParamCategory.VisibleIndex = 4;
            // 
            // ricbDataType
            // 
            this.ricbDataType.AutoHeight = false;
            this.ricbDataType.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ricbDataType.Name = "ricbDataType";
            // 
            // ricbCategory
            // 
            this.ricbCategory.AutoHeight = false;
            this.ricbCategory.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ricbCategory.Name = "ricbCategory";
            // 
            // rCheckEdit
            // 
            this.rCheckEdit.AutoHeight = false;
            this.rCheckEdit.Name = "rCheckEdit";
            // 
            // rDateEdit
            // 
            this.rDateEdit.AutoHeight = false;
            this.rDateEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rDateEdit.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rDateEdit.Name = "rDateEdit";
            // 
            // rSpinEdit
            // 
            this.rSpinEdit.AutoHeight = false;
            this.rSpinEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rSpinEdit.Name = "rSpinEdit";
            // 
            // FrmThamSo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 362);
            this.Controls.Add(this.gcParam);
            this.Name = "FrmThamSo";
            this.Text = "Thiết lập tham số hệ thống";
            this.Load += new System.EventHandler(this.FrmThamSo_Load);
            this.Controls.SetChildIndex(this.gcParam, 0);
            ((System.ComponentModel.ISupportInitialize)(this.UOW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpcParam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcParam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvParam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ricbDataType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ricbCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rCheckEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rDateEdit.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rDateEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rSpinEdit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.Xpo.XPCollection xpcParam;
        private TienIch.GridControlCustom gcParam;
        private TienIch.GridViewCustom gvParam;
        private DevExpress.XtraGrid.Columns.GridColumn colParamCode;
        private DevExpress.XtraGrid.Columns.GridColumn colValueType;
        private DevExpress.XtraGrid.Columns.GridColumn colOptionValue;
        private DevExpress.XtraGrid.Columns.GridColumn colAllowChange;
        private DevExpress.XtraGrid.Columns.GridColumn colParamCategory;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox ricbDataType;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox ricbCategory;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit rCheckEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit rDateEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit rSpinEdit;
    }
}