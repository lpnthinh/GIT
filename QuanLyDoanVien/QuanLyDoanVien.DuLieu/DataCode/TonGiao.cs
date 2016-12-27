using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
namespace QuanLyDoanVien.DuLieu
{

    public partial class TonGiao
    {
        public TonGiao(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}
