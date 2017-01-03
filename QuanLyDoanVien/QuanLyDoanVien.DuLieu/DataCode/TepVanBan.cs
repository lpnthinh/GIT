using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using DevExpress.XtraEditors.DXErrorProvider;

namespace QuanLyDoanVien.DuLieu
{

    public partial class TepVanBan
    {
        public TepVanBan(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
        public override void GetPropertyError(string propertyName, ErrorInfo info)
        {
            base.GetPropertyError(propertyName, info);
            switch (propertyName)
            {
                case "VanBan!Key":
                    if (VanBan == null)
                    {
                        info.ErrorType = ErrorType.Critical;
                        info.ErrorText = "Văn bản không được trống";
                    }
                    break;
                case "DuongDanTep":
                    if (string.IsNullOrEmpty(DuongDanTep))
                    {
                        info.ErrorType = ErrorType.Critical;
                        info.ErrorText = "Đường dẫn tệp không được trống";
                    }
                    break;
            }
        }
    }

}
