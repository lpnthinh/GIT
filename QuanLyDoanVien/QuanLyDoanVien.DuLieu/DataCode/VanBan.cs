using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using DevExpress.XtraEditors.DXErrorProvider;

namespace QuanLyDoanVien.DuLieu
{

    public partial class VanBan
    {
        public VanBan(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
        public override void GetPropertyError(string propertyName, ErrorInfo info)
        {
            base.GetPropertyError(propertyName, info);
            switch (propertyName)
            {
                case "SoKyHieu":
                    if (string.IsNullOrEmpty(SoKyHieu))
                    {
                        info.ErrorType = ErrorType.Critical;
                        info.ErrorText = "Số ký hiệu không được trống";
                    }
                    else if (Exists(Session, ClassInfo, propertyName, SoKyHieu))
                    {
                        info.ErrorType = ErrorType.Critical;
                        info.ErrorText = "Số ký hiệu không được trùng";
                    }
                    break;

                case "Kieu":
                    if (string.IsNullOrEmpty(Kieu.ToString()))
                    {
                        info.ErrorType = ErrorType.Critical;
                        info.ErrorText = "Số ký hiệu không được trống";
                    }
                    break;
            }
        }

        [DevExpress.Xpo.DisplayName("Năm tháng ban hành")]
        public string NamThangBanHanh
        {
            get
            {
                return string.Format("Năm {0:yyyy} tháng {0:MM}", 
                                     NgayBanHanh != null ? NgayBanHanh : DateTime.MinValue);
            }
        }
    }

}
