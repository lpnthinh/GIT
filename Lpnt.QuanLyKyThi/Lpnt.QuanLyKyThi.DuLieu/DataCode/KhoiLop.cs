using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
namespace Lpnt.QuanLyKyThi.DuLieu
{

    public partial class KhoiLop
    {
        public KhoiLop(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}
