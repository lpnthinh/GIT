using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using DevExpress.XtraEditors.DXErrorProvider;

namespace Lpnt.QuanLyKyThi.DuLieu
{

    public partial class NhomNguoiDung
    {
        public NhomNguoiDung(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
        public override void GetPropertyError(string propertyName, ErrorInfo info)
        {
            base.GetPropertyError(propertyName, info);

            switch (propertyName)
            {
                case "TenNhom":
                    if (string.IsNullOrEmpty(TenNhom))
                    {
                        info.ErrorType = ErrorType.Critical;
                        info.ErrorText = "Tên nhóm không được trống";
                    }
                    else if (Exists(Session, ClassInfo, propertyName, TenNhom))
                    {
                        info.ErrorType = ErrorType.Critical;
                        info.ErrorText = "Tên nhóm không được trùng";
                    }
                    break;
            }
        }
    }

}
