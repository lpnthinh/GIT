using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
namespace QuanLyDoanVien.DuLieu
{

    public partial class NhanSu
    {
        public NhanSu(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
        [DevExpress.Xpo.DisplayName("Họ và tên")]
        public string HoVaTen
        {
            get
            {
                return string.Format("{0} {1}", HoDem, Ten);
            }
        }

        [DevExpress.Xpo.DisplayName("Thông tin nhân sự")]
        public string ThongTinNhanSu
        {
            get
            {
                return string.Format("{0} - {1} {2}", SoHoSo, HoDem, Ten);
            }
        }
    }

}
