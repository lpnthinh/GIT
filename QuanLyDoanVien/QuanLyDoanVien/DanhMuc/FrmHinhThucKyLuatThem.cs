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

namespace QuanLyDoanVien.DanhMuc
{
    public partial class FrmHinhThucKyLuatThem : FrmBaseDialog
    {
        HinhThucKyLuat _obj;
        public FrmHinhThucKyLuatThem()
        {
            InitializeComponent();

            _obj = new HinhThucKyLuat(UOW);
            txtTen.DataBindings.Add("EditValue", _obj, "Ten");

            dxErrorProvider1.DataSource = _obj;
        }
        public int Id
        {
            get
            {
                return _obj.Id;
            }
        }
        protected override bool OnLuu()
        {
            layoutControl1.Validate();
            if (dxErrorProvider1.HasErrors) return false;
            if (base.OnLuu()) DialogResult = DialogResult.OK;

            return true;
        }
    }
}