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

    public partial class Param : BaseObject
    {
        string fParamCode;
        [DevExpress.Xpo.DisplayName(@"Tham số")]
        public string ParamCode
        {
            get { return fParamCode; }
            set { SetPropertyValue<string>("ParamCode", ref fParamCode, value); }
        }
        QuanLyDoanVien.DuLieu.DataType fValueType;
        [DevExpress.Xpo.DisplayName(@"Kiểu dữ liệu")]
        public QuanLyDoanVien.DuLieu.DataType ValueType
        {
            get { return fValueType; }
            set { SetPropertyValue<QuanLyDoanVien.DuLieu.DataType>("ValueType", ref fValueType, value); }
        }
        string fValue;
        [DevExpress.Xpo.DisplayName(@"Giá trị")]
        public string Value
        {
            get { return fValue; }
            set { SetPropertyValue<string>("Value", ref fValue, value); }
        }
        bool fAllowChange;
        [DevExpress.Xpo.DisplayName(@"Cho phép sửa")]
        public bool AllowChange
        {
            get { return fAllowChange; }
            set { SetPropertyValue<bool>("AllowChange", ref fAllowChange, value); }
        }
        QuanLyDoanVien.DuLieu.ParamCategory fParamCategory;
        public QuanLyDoanVien.DuLieu.ParamCategory ParamCategory
        {
            get { return fParamCategory; }
            set { SetPropertyValue<QuanLyDoanVien.DuLieu.ParamCategory>("ParamCategory", ref fParamCategory, value); }
        }
    }

}
