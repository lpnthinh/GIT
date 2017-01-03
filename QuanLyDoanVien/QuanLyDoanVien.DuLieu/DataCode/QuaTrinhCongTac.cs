using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using DevExpress.XtraEditors.DXErrorProvider;

namespace QuanLyDoanVien.DuLieu
{

    public partial class QuaTrinhCongTac
    {
        public QuaTrinhCongTac(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
        public override void GetPropertyError(string propertyName, ErrorInfo info)
        {
            base.GetPropertyError(propertyName, info);
            switch (propertyName)
            {
                case "TuThangNam":
                    if (string.IsNullOrEmpty(TuThangNam))
                    {
                        info.ErrorType = ErrorType.Critical;
                        info.ErrorText = "Nhập mốc thời gian bắt đầu";
                    }
                    break;
            }
        }
    }

}
