using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using DevExpress.XtraEditors.DXErrorProvider;

namespace QuanLyDoanVien.DuLieu
{

    public enum CapHanhChinh
    {
        [Description("Tỉnh")]
        Tinh = 0,
        [Description("Huyện")]
        Huyen = 1,
        [Description("Xã")]
        Xa = 2
    }
    public partial class HanhChinh
    {
        public HanhChinh(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); fMa = string.Empty; }
        public override void GetPropertyError(string propertyName, ErrorInfo info)
        {
            base.GetPropertyError(propertyName, info);

            switch (propertyName)
            {
                case "Ma":
                    if (string.IsNullOrEmpty(Ma))
                    {
                        info.ErrorType = ErrorType.Critical;
                        info.ErrorText = "Mã không được trống";
                    }
                    else if (Exists(Session, ClassInfo, propertyName, Ma))
                    {
                        info.ErrorType = ErrorType.Critical;
                        info.ErrorText = "Mã không được trùng";
                    }
                    break;

                case "Ten":
                    if (string.IsNullOrEmpty(Ten))
                    {
                        info.ErrorType = ErrorType.Critical;
                        info.ErrorText = "Tên không được trống";
                    }
                    break;
            }
        }
        public string TenHanhChinh
        {
            get
            {
                return Cap == (int)CapHanhChinh.Xa ? string.Format("{0} - {1} - {2}", Ten, Cha.Ten, Cha.Cha.Ten) :
                       Cap == (int)CapHanhChinh.Huyen ? string.Format("{0} - {1}", Ten, Cha.Ten) :
                       Ten;
            }
        }
    }

}
