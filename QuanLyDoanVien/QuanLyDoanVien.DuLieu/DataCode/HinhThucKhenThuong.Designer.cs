﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
namespace QuanLyDoanVien.DuLieu
{

    public partial class HinhThucKhenThuong : BaseObject
    {
        string fTen;
        [DevExpress.Xpo.DisplayName(@"Hình thức khen thưởng")]
        public string Ten
        {
            get { return fTen; }
            set { SetPropertyValue<string>("Ten", ref fTen, value); }
        }
    }

}
