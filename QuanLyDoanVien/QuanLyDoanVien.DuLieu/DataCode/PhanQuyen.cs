using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
namespace QuanLyDoanVien.DuLieu
{

    public partial class PhanQuyen
    {
        public PhanQuyen(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
        public static PhanQuyen FindAndNew(Session s, NhomNguoiDung nhom, ChucNang chucnang)
        {
            if (s == null) s = XpoDefault.Session;
            var pq = s.FindObject<PhanQuyen>(CriteriaOperator.Parse("[NhomNguoiDung.Id] = ? and [ChucNang.Id] = ?"
                                                , nhom.Id, chucnang.Id));
            if (pq == null)
            {
                pq = new PhanQuyen(s);

                if (nhom.QuanTri)
                {
                    pq.TruyCap = pq.Them = pq.Sua = pq.Xoa = true;
                }
                pq.NhomNguoiDung = nhom;
                pq.ChucNang = chucnang;
                pq.Save();
            }
            return pq;
        }
        public static PhanQuyen Find(NhomNguoiDung nhom, ChucNang chucnang)
        {
            if (chucnang == null || nhom == null) return null;
            var pq = XpoDefault.Session.FindObject<PhanQuyen>(CriteriaOperator.Parse("[NhomNguoiDung.Id] = ? and [ChucNang.Id] = ?"
                                                 , nhom.Id, chucnang.Id));

            return pq;
        }
    }

}
