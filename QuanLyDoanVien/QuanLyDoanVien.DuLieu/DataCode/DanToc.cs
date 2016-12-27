using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
namespace QuanLyDoanVien.DuLieu
{

    public partial class DanToc
    {
        public DanToc(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}
