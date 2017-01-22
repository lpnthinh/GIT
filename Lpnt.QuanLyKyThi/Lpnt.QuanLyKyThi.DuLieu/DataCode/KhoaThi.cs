using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using DevExpress.XtraEditors.DXErrorProvider;

namespace Lpnt.QuanLyKyThi.DuLieu
{

    public partial class KhoaThi
    {
        public KhoaThi(Session session) : base(session) { }
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
                        info.ErrorText = "Mã khóa thi không được trống";
                    }
                    else if (Exists(Session, ClassInfo, propertyName, Ma))
                    {
                        info.ErrorType = ErrorType.Critical;
                        info.ErrorText = "Mã khóa thi không được trùng";
                    }
                    break;

                case "Ten":
                    if (string.IsNullOrEmpty(Ten))
                    {
                        info.ErrorType = ErrorType.Critical;
                        info.ErrorText = "Tên khóa thi không được trống";
                    }
                    else if (Exists(Session, ClassInfo, propertyName, Ten))
                    {
                        info.ErrorType = ErrorType.Critical;
                        info.ErrorText = "Tên khóa thi không được trùng";
                    }
                    break;
            }
        }

        [DevExpress.Xpo.DisplayName("Số lượng giám thị")]
        public int SoLuongGiamThi
        {
            get
            {
                return GiamThis.Count;
            }
        }

        [DevExpress.Xpo.DisplayName("Số lượng thí sinh")]
        public int SoLuongThiSinh
        {
            get
            {
                return ThiSinhs.Count;
            }
        }

        [DevExpress.Xpo.DisplayName("Số lượng môn thi")]
        public int SoLuongMonThi
        {
            get
            {
                return MonThis.Count;
            }
        }
    }

}
