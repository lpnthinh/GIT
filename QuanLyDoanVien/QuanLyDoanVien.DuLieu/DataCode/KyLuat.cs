using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using DevExpress.XtraEditors.DXErrorProvider;

namespace QuanLyDoanVien.DuLieu
{

    public partial class KyLuat
    {
        public KyLuat(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
        public override void GetPropertyError(string propertyName, ErrorInfo info)
        {
            base.GetPropertyError(propertyName, info);
            switch (propertyName)
            {
                case "NhanSu!Key":
                    if (NhanSu == null)
                    {
                        info.ErrorType = ErrorType.Critical;
                        info.ErrorText = "Nhân sự không được rỗng";
                    }
                    break;
            }
        }
    }

}
