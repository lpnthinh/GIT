using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using DevExpress.XtraEditors.DXErrorProvider;
using DevExpress.Xpo.Metadata;
using System.Linq;

namespace QuanLyDoanVien.DuLieu
{

    public partial class BaseObject : IDXDataErrorInfo
    {
        public BaseObject(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
        public const string ATT_TABLE_NAME = "Tên bảng";
        public const string ATT_USER_KEY = "UserKey";
        public static object FindObject(Session s, Type type, string propertiyName, object value)
        {
            if (s == null) s = XpoDefault.Session;
            var strFilter = string.Format("[{0}]=?", propertiyName);
            return s.FindObject(type, CriteriaOperator.Parse(strFilter, value));
        }
        public static T FindObject<T>(string propertiyName, object value)
        {
            return FindObject<T>(null, propertiyName, value);
        }
        public static T FindObject<T>(Session s, string propertiyName, object value)
        {
            if (s == null) s = XpoDefault.Session;
            var strFilter = string.Format("[{0}]=?", propertiyName);
            return s.FindObject<T>(CriteriaOperator.Parse(strFilter, value));
        }
        public static bool Exists(Session s, XPClassInfo clsInfo, string propertiyName, object value)
        {
            try
            {
                if (s == null) s = XpoDefault.Session;
                if (s.IsObjectsLoading || s.IsObjectsSaving) return false;
                var collection = s.GetObjectsInTransaction(clsInfo,
                    CriteriaOperator.Parse(propertiyName + " = ?", value),
                    true);
                var count = collection.Count;
                return count > 1;
            }
            catch
            {
                return false;
            }
        }
        public bool Exists()
        {
            var propertyName = string.Empty;
            object value = null;

            propertyName = ClassInfo.Members.FirstOrDefault(m => m.HasAttribute(ATT_USER_KEY)).Name;
            value = GetMemberValue(propertyName);

            var collection = Session.GetObjectsInTransaction(ClassInfo,
                CriteriaOperator.Parse(propertyName + " = ?", value), true);
            var count = collection.Count;
            return count > 1;
        }
        public bool IsNewObject
        {
            get { return Session.IsNewObject(this); }
        }
        protected override void OnSaving()
        {
            UpdateAt = DateTime.Now;
            UpdateBy = clsDuLieu.NguoiDungDangNhap == null ? "system" : clsDuLieu.NguoiDungDangNhap.TaiKhoan;
            base.OnSaving();
        }
        public void GetError(ErrorInfo info)
        {
        }
        public virtual void GetPropertyError(string propertyName, ErrorInfo info)
        {
            var size = 0;

            if (ClassInfo.Members.Any(m => m.Name == propertyName))
            {
                var mem = ClassInfo.GetMember(propertyName);
                size = mem.MappingFieldSize;
                if (mem.MemberType == typeof(string))
                {
                    var obj = mem.GetValue(this);
                    if (obj != null)
                    {
                        if (obj.ToString().Length > size)
                        {
                            info.ErrorType = ErrorType.Critical;
                            info.ErrorText = string.Format("Dữ liệu không được vượt quá {0} ký tự", size);
                        }
                    }
                }
            }
        }
    }

}
