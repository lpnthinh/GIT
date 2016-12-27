using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using DevExpress.XtraEditors.DXErrorProvider;

namespace QuanLyDoanVien.DuLieu
{

    public partial class DonVi
    {
        public DonVi(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
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

        [DevExpress.Xpo.DisplayName("Đơn vị")]
        public string MaVaTen { get { return string.Format("{0} - {1}", Ma, Ten); } }
    }

}
