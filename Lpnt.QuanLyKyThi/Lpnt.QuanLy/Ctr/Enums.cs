using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lpnt.QuanLy.Ctr
{
    public enum GioiTinh
    {
        [Description("Nam")]
        Nam = 0,
        [Description("Nữ")]
        Nu = 1
    }
    public enum HinhThucThi
    {
        [Description("Trắc nghiệm")]
        TracNghiem = 0,
        [Description("Tự luận")]
        TuLuan = 1,
        [Description("Trắc nghiệm và tự luận")]
        TracNghiemVaTuLuan = 2
    }
}
