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
namespace Lpnt.QuanLyKyThi.DuLieu
{

    public partial class HocSinh : BaseObject
    {
        string fMa;
        [DevExpress.Xpo.DisplayName(@"Mã học sinh")]
        public string Ma
        {
            get { return fMa; }
            set { SetPropertyValue<string>("Ma", ref fMa, value); }
        }
        string fHoDem;
        [DevExpress.Xpo.DisplayName(@"Họ đệm")]
        public string HoDem
        {
            get { return fHoDem; }
            set { SetPropertyValue<string>("HoDem", ref fHoDem, value); }
        }
        string fTen;
        [DevExpress.Xpo.DisplayName(@"Tên")]
        public string Ten
        {
            get { return fTen; }
            set { SetPropertyValue<string>("Ten", ref fTen, value); }
        }
        int fGioiTinh;
        [DevExpress.Xpo.DisplayName(@"Giới tính")]
        public int GioiTinh
        {
            get { return fGioiTinh; }
            set { SetPropertyValue<int>("GioiTinh", ref fGioiTinh, value); }
        }
        DateTime fNgaySinh;
        [DevExpress.Xpo.DisplayName(@"Ngày sinh")]
        public DateTime NgaySinh
        {
            get { return fNgaySinh; }
            set { SetPropertyValue<DateTime>("NgaySinh", ref fNgaySinh, value); }
        }
        string fDanToc;
        [DevExpress.Xpo.DisplayName(@"Dân tộc")]
        public string DanToc
        {
            get { return fDanToc; }
            set { SetPropertyValue<string>("DanToc", ref fDanToc, value); }
        }
        string fDiaChi;
        [DevExpress.Xpo.DisplayName(@"Địa chỉ")]
        public string DiaChi
        {
            get { return fDiaChi; }
            set { SetPropertyValue<string>("DiaChi", ref fDiaChi, value); }
        }
        LopHoc fLopHoc;
        [Association(@"HocSinhReferencesLopHoc")]
        [DevExpress.Xpo.DisplayName(@"Lớp học")]
        public LopHoc LopHoc
        {
            get { return fLopHoc; }
            set { SetPropertyValue<LopHoc>("LopHoc", ref fLopHoc, value); }
        }
        NamHoc fNamHoc;
        [DevExpress.Xpo.DisplayName(@"Năm học")]
        public NamHoc NamHoc
        {
            get { return fNamHoc; }
            set { SetPropertyValue<NamHoc>("NamHoc", ref fNamHoc, value); }
        }
        byte[] fHinhAnh;
        [MemberDesignTimeVisibility(true)]
        [DevExpress.Xpo.DisplayName(@"Hình ảnh")]
        public byte[] HinhAnh
        {
            get { return fHinhAnh; }
            set { SetPropertyValue<byte[]>("HinhAnh", ref fHinhAnh, value); }
        }
    }

}
