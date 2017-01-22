using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
namespace Lpnt.QuanLyKyThi.DuLieu
{

    public partial class GiamThi
    {
        public GiamThi(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}
