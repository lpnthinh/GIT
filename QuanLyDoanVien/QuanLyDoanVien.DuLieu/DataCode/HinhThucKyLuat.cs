using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
namespace QuanLyDoanVien.DuLieu
{

    public partial class HinhThucKyLuat
    {
        public HinhThucKyLuat(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}
