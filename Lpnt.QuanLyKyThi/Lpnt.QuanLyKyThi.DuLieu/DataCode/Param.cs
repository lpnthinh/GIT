using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
namespace Lpnt.QuanLyKyThi.DuLieu
{

    public enum DataType
    {
        [Description("Chuỗi ký tự")]
        String = 0,
        [Description("Đúng/Sai")]
        Bool = 1,
        [Description("Ngày giờ")]
        DateTime = 2,
        [Description("Số nguyên")]
        Int32 = 3,
        [Description("Số thập phân")]
        Decimal = 4,
        [Description("Hình ảnh")]
        Byarray = 5
    }
    public enum ParamCategory
    {
        [Description("Mặc định")]
        Default = 0,

        [Description("Hệ thống")]
        System = 1,

        [Description("Định dạng ngày giờ")]
        DateTimeFormat = 2,

        [Description("Định dạng số tiền")]
        MoneyFormat = 3,

        [Description("Định dạng số")]
        NumberFormat = 4,

        [Description("Cấu hình")]
        UserConfig = 5,

        [Description("Thông tin đơn vị")]
        CompanyInfo = 6,

        [Description("Nghiệp vụ")]
        Setting = 7,

        [Description("Báo cáo")]
        Report = 8,

        [Description("Phát sinh")]
        Generate = 99
    }
    public partial class Param
    {
        public Param(Session session) : base(session) { }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
            AllowChange = true;
            ValueType = DataType.String;
            ParamCategory = ParamCategory.Default;
        }
        [DevExpress.Xpo.DisplayName("Giá trị")]
        public object OptionValue
        {
            get
            {
                object value;
                switch (ValueType)
                {
                    case DataType.Bool:
                        try
                        {
                            value = Convert.ToBoolean(Value);
                        }
                        catch
                        {
                            value = Value;
                        }
                        break;
                    case DataType.DateTime:
                        try
                        {
                            value = Convert.ToDateTime(Value);
                        }
                        catch
                        {
                            value = Value;
                        }
                        break;
                    case DataType.Decimal:
                        try
                        {
                            value = Convert.ToDecimal(Value);
                        }
                        catch
                        {
                            value = Value;
                        }
                        break;
                    case DataType.Int32:
                        try
                        {
                            value = Convert.ToInt32(Value);
                        }
                        catch
                        {
                            value = Value;
                        }
                        break;
                    default:
                        value = Value;
                        break;
                }
                return value;
            }
            set
            {
                if (AllowChange && value != null)
                    Value = value.ToString();
            }
        }

        /// <summary>
        /// Lấy giá trị tham số bởi displayCode
        /// </summary>
        /// <param name="displayCode"></param>
        /// <param name="value">Giá trị trả về</param>
        public static void GetValue(string displayCode, out object value)
        {
            var c = FindObject<Param>("ParamCode", displayCode);
            if (c == null)
            {
                value = null;
                return;
            }
            switch (c.ValueType)
            {
                case DataType.Bool:
                    value = Convert.ToBoolean(c.OptionValue);
                    break;
                case DataType.DateTime:
                    value = Convert.ToDateTime(c.OptionValue);
                    break;
                case DataType.Decimal:
                    value = Convert.ToDecimal(c.OptionValue);
                    break;
                case DataType.Int32:
                    value = Convert.ToInt32(c.OptionValue);
                    break;
                default:
                    value = c.OptionValue;
                    break;
            }
        }

        /// <summary>
        /// Lấy giá trị tham số bởi tên tham số,  nếu không có -> tạo tham số với giá trị mặc định
        /// </summary>
        /// <param name="paramCode">Tên tham số</param>
        /// <param name="value">Giá trị trả về</param>
        /// <param name="category">Loại tham số</param>
        /// <param name="defaultValue">Giá trị mặc định</param>
        /// <param name="type">Kiểu dữ liệu</param>
        public static void GetValue(string paramCode, out object value, ParamCategory category, object defaultValue, DataType type)
        {
            var c = FindObject<Param>("ParamCode", paramCode);
            if (c == null)
            {
                c = new Param(XpoDefault.Session);
                c.ParamCode = paramCode;
                c.ParamCategory = category;
                c.OptionValue = defaultValue;
                c.ValueType = type;
                c.Save();
            }
            switch (c.ValueType)
            {
                case DataType.Bool:
                    value = Convert.ToBoolean(c.OptionValue);
                    break;
                case DataType.DateTime:
                    value = Convert.ToDateTime(c.OptionValue);
                    break;
                case DataType.Decimal:
                    value = Convert.ToDecimal(c.OptionValue);
                    break;
                case DataType.Int32:
                    value = Convert.ToInt32(c.OptionValue);
                    break;
                default:
                    value = c.OptionValue;
                    break;
            }
        }
        public static void SetValue(string paramCode, object value)
        {
            var c = FindObject<Param>("ParamCode", paramCode);
            if (c == null)
            {
                value = null;
                return;
            }
            c.OptionValue = value;
            c.Save();
        }
    }

}
