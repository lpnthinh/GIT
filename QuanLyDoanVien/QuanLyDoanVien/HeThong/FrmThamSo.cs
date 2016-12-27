using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using QuanLyDoanVien.TienIch;
using QuanLyDoanVien.DuLieu;
using DevExpress.Data.Filtering;
using DevExpress.Utils;

namespace QuanLyDoanVien.HeThong
{
    public partial class FrmThamSo : FrmBaseDialog
    {
        private ParamCategory paramCategory;
        public FrmThamSo()
        {
            InitializeComponent();
        }
        public FrmThamSo(ParamCategory category)
        {
            InitializeComponent();

            paramCategory = category;
            xpcParam.Criteria = CriteriaOperator.Parse("[ParamCategory] = ?", category);

            colParamCategory.Visible = false;
            colParamCategory.OptionsColumn.ShowInCustomizationForm = false;
        }
        private void FrmThamSo_Load(object sender, EventArgs e)
        {
            ricbDataType.Items.AddEnum(typeof(DataType));
            ricbCategory.Items.AddEnum(typeof(ParamCategory));
        }
        protected override void OnNap()
        {
            base.OnNap();
            xpcParam.Reload();
        }
        protected override bool OnLuu()
        {
            gvParam.CloseEditor();
            gvParam.UpdateCurrentRow();

            return base.OnLuu();
        }
        protected override void OnDong()
        {
            object tmp;
            Param.GetValue("Khởi động cùng Windows", out tmp);
            KeyRegistry.RegisterInStartup((bool)tmp);

            base.OnDong();
        }
        private void gvParam_CustomRowCellEdit(object sender, DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs e)
        {
            if (e.RowHandle < 0) return;

            if (e.Column.FieldName != colOptionValue.FieldName) return;

            var p = gvParam.GetRow(e.RowHandle) as Param;
            if (p == null) return;

            switch (p.ValueType)
            {
                case DataType.Bool:
                    e.RepositoryItem = rCheckEdit;
                    break;
                case DataType.DateTime:
                    e.RepositoryItem = rDateEdit;
                    break;
                case DataType.Decimal:
                    e.RepositoryItem = rSpinEdit;
                    rSpinEdit.IsFloatValue = true;
                    break;
                case DataType.Int32:
                    e.RepositoryItem = rSpinEdit;
                    rSpinEdit.IsFloatValue = false;
                    break;
                default:
                    e.RepositoryItem = null;
                    break;
            }
        }
        private void gvParam_RowCellDefaultAlignment(object sender, DevExpress.XtraGrid.Views.Base.RowCellAlignmentEventArgs e)
        {
            if (e.Column.FieldName != colOptionValue.FieldName) return;
            if (e.RowHandle < 0) return;
            var p = gvParam.GetRow(e.RowHandle) as Param;
            if (p == null) return;

            switch (p.ValueType)
            {
                case DataType.Decimal:
                case DataType.Int32:
                    e.HorzAlignment = HorzAlignment.Far;
                    break;
            }
        }
        private void gvParam_FocusedColumnChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedColumnChangedEventArgs e)
        {
            if (e.PrevFocusedColumn == null) return;
            if (e.PrevFocusedColumn.FieldName == colAllowChange.FieldName)
            {
                var param = gvParam.GetFocusedRow() as Param;
                if (param == null) return;

                colOptionValue.OptionsColumn.AllowEdit = param.AllowChange;
            }
        }
        private void gvParam_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            var param = gvParam.GetFocusedRow() as Param;
            if (param == null) return;

            colOptionValue.OptionsColumn.AllowEdit = param.AllowChange;
        }
    }
}