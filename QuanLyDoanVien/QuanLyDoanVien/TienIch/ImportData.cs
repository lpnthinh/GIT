using System;
using System.Data;
using System.Data.OleDb;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using QuanLyDoanVien.DuLieu;

namespace QuanLyDoanVien.TienIch
{
    public class ImportData
    {
        private static DataTable GetExcelTable(string fileName, string sheetName)
        {
            return GetExcelTable(fileName, sheetName, string.Empty);
        }
        private static DataTable GetExcelTable(string fileName, string sheetName, string sql)
        {
            sheetName = sheetName.Replace(".", "#");
            if (sql == string.Empty)
                sql = string.Format("select * from [{0}$]", sheetName);

            var strConn = string.Empty;
            if (fileName.Contains(".xlsx"))
            {
                strConn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source="
                          + fileName + ";Extended Properties=\"Excel 12.0;HDR=YES\";";
            }
            else if (fileName.Contains(".xls"))
            {
                strConn = "Provider=Microsoft.Jet.OLEDB.4.0;" +
                          "Data Source=" + fileName + ";Extended Properties=Excel 8.0;";
            }
            var dt = new DataTable();
            try
            {
                var oleConn = new OleDbConnection(strConn);
                var oleCmd = new OleDbDataAdapter(sql, strConn);
                oleCmd.Fill(dt);
            }
            catch (Exception ex)
            {
                MsgBox.ShowWarningDialog("Không import được file");
                Console.WriteLine(ex.Message);

                return null;
            }
            if (dt != null)
                foreach (DataRow dr in dt.Rows)
                    dr[0] = Convert.ToString(dr[0]).Replace("&", "");

            return dt;
        }

        internal static bool ImportHanhChinhList(string fileName, string sheetName, int caphanhchinh)
        {
            var dtExcel = GetExcelTable(fileName, sheetName);
            if (dtExcel == null) return false;

            try
            {
                dtExcel.Columns[0].Unique = true;
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("contains non-unique values"))
                    MsgBox.ShowWarningDialog(string.Format("Sheet [{0}] có những dòng trùng mã đơn vị h.chính", sheetName));
                else
                    MsgBox.ShowWarningDialog(string.Format("Sheet excel [{0}] dùng để import không hợp lệ", sheetName));
                return false;
            }

            var iCount = 0;

            foreach (DataRow dr in dtExcel.Rows)
            {
                try
                {
                    var ma = Convert.ToString(dr["Mã"]).Trim();
                    var ten = Convert.ToString(dr["Tên"]).Trim();
                    if (string.IsNullOrEmpty(ma) || string.IsNullOrEmpty(ten))
                    {
                        MsgBox.ShowWarningDialog("Mã hoặc tên đơn vị h.chính không được rỗng.\nVui lòng kiểm tra dữ liệu trước khi import");
                        return false;
                    }
                    var hanhchinh = HanhChinh.FindObject<HanhChinh>("Ma", ma);
                    if (hanhchinh == null)
                        hanhchinh = new HanhChinh(XpoDefault.Session);

                    hanhchinh.Ma = ma;
                    hanhchinh.Ten = ten;
                    hanhchinh.Cap = caphanhchinh;

                    string macaptren = Convert.IsDBNull(dr["Mã cấp trên"]) ? string.Empty : dr["Mã cấp trên"].ToString().Trim();
                    if (!string.IsNullOrEmpty(macaptren))
                    {
                        var donvicaptren = HanhChinh.FindObject<HanhChinh>("Ma", macaptren);
                        if (donvicaptren != null)
                            hanhchinh.Cha = donvicaptren;
                    }

                    hanhchinh.Save();
                    iCount++;

                    MsgBox.ShowWaitForm(string.Format("Đang import {0}/{1} đơn vị h.chính", iCount, dtExcel.Rows.Count));
                }
                catch (Exception ex)
                {
                    if (ex.Message.Contains("does not belong to table"))
                    {
                        MsgBox.ShowWarningDialog(string.Format("Sheet excel [{0}] dùng để import không hợp lệ", sheetName));
                        return false;
                    }
                }
            }

            MsgBox.ShowWaitForm(string.Format("Đã import {0}/{1} đơn vị h.chính!", iCount, dtExcel.Rows.Count));

            return true;
        }
        internal static bool ImportDonViList(string fileName, string sheetName)
        {
            var dtExcel = GetExcelTable(fileName, sheetName);
            if (dtExcel == null) return false;

            try
            {
                dtExcel.Columns[1].Unique = true;       // Mã đơn vị
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("contains non-unique values"))
                    MsgBox.ShowWarningDialog(string.Format("Sheet [{0}] có những dòng trùng mã đơn vị", sheetName));
                else
                    MsgBox.ShowWarningDialog(string.Format("Sheet excel [{0}] dùng để import không hợp lệ", sheetName));
                return false;
            }

            var iCount = 0;

            foreach (DataRow dr in dtExcel.Rows)
            {
                try
                {
                    var ten = Convert.ToString(dr["Đơn vị"]).Trim();
                    var ma = Convert.ToString(dr["Mã"]).Trim();
                    var macaptren = Convert.ToString(dr["Mã cấp trên"]).Trim();
                    if (string.IsNullOrEmpty(ma) || string.IsNullOrEmpty(ten))
                    {
                        MsgBox.ShowWarningDialog("Mã hoặc tên đơn vị không được rỗng.\nVui lòng kiểm tra dữ liệu trước khi import");
                        return false;
                    }
                    var donvi = DonVi.FindObject<DonVi>("Ma", ma);
                    if (donvi == null)
                        donvi = new DonVi(XpoDefault.Session);

                    donvi.Ma = ma;
                    donvi.Ten = ten;
                    string cap = Convert.ToString(dr["Cấp"]).Trim();
                    donvi.Cap = cap.Equals("Cấp trung ương") ? (int)CapDonVi.TW :
                                     cap.Equals("Cấp tỉnh") ? (int)CapDonVi.Tinh :
                                     cap.Equals("Cấp huyện") ? (int)CapDonVi.Huyen :
                                     cap.Equals("Cấp đơn vị") ? (int)CapDonVi.DonVi :
                                     (int)CapDonVi.ChiDoan;

                    var cha = DonVi.FindObject<DonVi>("Ma", macaptren);
                    if (cha != null)
                        donvi.Cha = cha;

                    donvi.Save();

                    iCount++;

                    MsgBox.ShowWaitForm(string.Format("Đang import {0}/{1} đơn vị", iCount, dtExcel.Rows.Count));
                }
                catch (Exception ex)
                {
                    if (ex.Message.Contains("does not belong to table"))
                    {
                        MsgBox.ShowWarningDialog(string.Format("Sheet excel [{0}] dùng để import không hợp lệ", sheetName));
                        return false;
                    }
                }
            }

            MsgBox.ShowSuccessfulDialog(string.Format("Đã import {0}/{1} đơn vị!", iCount, dtExcel.Rows.Count));

            return true;
        }
        internal static bool ImportNhanSuList(string fileName, string sheetName)
        {
            var dtExcel = GetExcelTable(fileName, sheetName);
            if (dtExcel == null) return false;

            try
            {
                dtExcel.Columns[4].Unique = true;   // Số hồ sơ
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("contains non-unique values"))
                    MsgBox.ShowWarningDialog(string.Format("Sheet [{0}] có những dòng số hồ sơ", sheetName));
                else
                    MsgBox.ShowWarningDialog(string.Format("Sheet excel [{0}] dùng để import không hợp lệ", sheetName));
                return false;
            }

            var iCount = 0;

            foreach (DataRow dr in dtExcel.Rows)
            {
                try
                {
                    var madonvi = Convert.IsDBNull(dr["Mã đơn vị"]) ? string.Empty : Convert.ToString(dr["Mã đơn vị"]).Trim();
                    var nienkhoa = Convert.IsDBNull(dr["Niên khóa"]) ? string.Empty : Convert.ToString(dr["Niên khóa"]).Trim();
                    var sohoso = Convert.IsDBNull(dr["Số hồ sơ"]) ? string.Empty : Convert.ToString(dr["Số hồ sơ"]).Trim();
                    var hodem = Convert.IsDBNull(dr["Họ đệm"]) ? string.Empty : Convert.ToString(dr["Họ đệm"]).Trim();
                    var ten = Convert.IsDBNull(dr["Tên"]) ? string.Empty : Convert.ToString(dr["Tên"]).Trim();

                    if (string.IsNullOrEmpty(madonvi) || string.IsNullOrEmpty(nienkhoa))
                    {
                        MsgBox.ShowWarningDialog("Đơn vị hoặc niên khóa không được rỗng.\nVui lòng kiểm tra dữ liệu trước khi import");
                        return false;
                    }

                    DonVi _donvi = DonVi.FindObject<DonVi>("Ma", madonvi);
                    if (_donvi == null)
                    {
                        MsgBox.ShowWarningDialog("Đơn vị không tồn tại trong danh sách đơn vị hiện có.\nVui lòng kiểm tra dữ liệu trước khi import");
                        return false;
                    }

                    if (string.IsNullOrEmpty(sohoso) || string.IsNullOrEmpty(hodem) || string.IsNullOrEmpty(ten))
                    {
                        MsgBox.ShowWarningDialog("Số hồ sơ hoặc họ đệm hoặc tên không được rỗng.\nVui lòng kiểm tra dữ liệu trước khi import");
                        return false;
                    }

                    var nhansu = NhanSu.FindObject<NhanSu>("SoHoSo", sohoso);
                    if (nhansu == null) nhansu = new NhanSu(XpoDefault.Session);

                    nhansu.DonVi = _donvi;

                    NienKhoa _nienkhoa = NienKhoa.FindObject<NienKhoa>("Ten", nienkhoa);
                    if (_nienkhoa == null)
                    {
                        _nienkhoa = new NienKhoa(XpoDefault.Session);
                        _nienkhoa.Ten = nienkhoa;
                        _nienkhoa.SuDung = false;
                        _nienkhoa.Save();
                    }
                    nhansu.NienKhoa = _nienkhoa;

                    nhansu.HoatDong = Convert.ToString(dr["Hoạt động"]).Trim().Equals("True") || Convert.ToString(dr["Hoạt động"]).Trim().Equals("TRUE") ? true : false;
                    nhansu.ThuTu = Convert.IsDBNull(dr["Thứ tự"]) ? 1 : Convert.ToInt32(dr["Thứ tự"]);
                    nhansu.SoHoSo = sohoso;
                    nhansu.HoDem = hodem;
                    nhansu.Ten = ten;
                    nhansu.GioiTinh = Convert.ToString(dr["Giới tính"]).Trim().Equals("Nam") ?
                                            (int)GioiTinh.Nam :
                                            (int)GioiTinh.Nu;
                    try { nhansu.NgaySinh = Convert.ToDateTime(dr["Ngày sinh"]); } catch (Exception) { nhansu.NgaySinh = DateTime.MinValue; }
                    nhansu.DienThoai = Convert.ToString(dr["Điện thoại"]).Trim();
                    nhansu.EmailLienHe = Convert.ToString(dr["Email liên hệ"]).Trim();

                    string dantoc = Convert.IsDBNull(dr["Dân tộc"]) ? string.Empty : Convert.ToString(dr["Dân tộc"]).Trim();
                    if (!string.IsNullOrEmpty(dantoc))
                    {
                        DanToc _dantoc = DanToc.FindObject<DanToc>("Ten", dantoc);
                        if (_dantoc == null)
                        {
                            _dantoc = new DanToc(XpoDefault.Session);
                            _dantoc.Ten = dantoc;
                            _dantoc.Save();
                        }
                        nhansu.DanToc = _dantoc;
                    }

                    string tongiao = Convert.IsDBNull(dr["Tôn giáo"]) ? string.Empty : Convert.ToString(dr["Tôn giáo"]).Trim();
                    if (!string.IsNullOrEmpty(tongiao))
                    {
                        TonGiao _tongiao = TonGiao.FindObject<TonGiao>("Ten", tongiao);
                        if (_tongiao == null)
                        {
                            _tongiao = new TonGiao(XpoDefault.Session);
                            _tongiao.Ten = dantoc;
                            _tongiao.Save();
                        }
                        nhansu.TonGiao = _tongiao;
                    }

                    string maxahktt = Convert.IsDBNull(dr["Mã xã (HKTT)"]) ? string.Empty : Convert.ToString(dr["Mã xã (HKTT)"]).Trim();
                    HanhChinh _hkttxa = HanhChinh.FindObject<HanhChinh>("Ma", maxahktt);
                    if (_hkttxa != null) nhansu.HoKhauThuongTru = _hkttxa;

                    nhansu.NoiOHienNay = Convert.ToString(dr["Nơi ở hiện nay"]).Trim();
                    nhansu.NoiHocTapLamViec = Convert.ToString(dr["Nơi học tập, làm việc"]).Trim();
                    nhansu.NgheNghiepBanThan = Convert.ToString(dr["Nghề nghiệp bản thân"]).Trim();

                    string thdv = Convert.IsDBNull(dr["Trình độ học vấn"]) ? string.Empty : Convert.ToString(dr["Trình độ học vấn"]).Trim();
                    if (!string.IsNullOrEmpty(thdv))
                    {
                        TrinhDoHocVan _tdhv = TrinhDoHocVan.FindObject<TrinhDoHocVan>("Ten", thdv);
                        if (_tdhv == null)
                        {
                            _tdhv = new TrinhDoHocVan(XpoDefault.Session);
                            _tdhv.Ten = thdv;
                            _tdhv.Save();
                        }
                        nhansu.TrinhDoHocVan = _tdhv;
                    }

                    string tdcm = Convert.IsDBNull(dr["Trình độ chuyên môn"]) ? string.Empty : Convert.ToString(dr["Trình độ chuyên môn"]).Trim();
                    if (!string.IsNullOrEmpty(tdcm))
                    {
                        TrinhDoChuyenMon _tdcm = TrinhDoChuyenMon.FindObject<TrinhDoChuyenMon>("Ten", tdcm);
                        if (_tdcm == null)
                        {
                            _tdcm = new TrinhDoChuyenMon(XpoDefault.Session);
                            _tdcm.Ten = tdcm;
                            _tdcm.Save();
                        }
                        nhansu.TrinhDoChuyenMon = _tdcm;
                    }

                    string tdllct = Convert.IsDBNull(dr["Trình độ lý luận chính trị"]) ? string.Empty : Convert.ToString(dr["Trình độ lý luận chính trị"]).Trim();
                    if (!string.IsNullOrEmpty(tdllct))
                    {
                        TrinhDoLyLuanChinhTri _tdllct = TrinhDoLyLuanChinhTri.FindObject<TrinhDoLyLuanChinhTri>("Ten", tdllct);
                        if (_tdllct == null)
                        {
                            _tdllct = new TrinhDoLyLuanChinhTri(XpoDefault.Session);
                            _tdllct.Ten = tdllct;
                            _tdllct.Save();
                        }
                        nhansu.TrinhDoLyLuanChinhTri = _tdllct;
                    }

                    string ngoaingu = Convert.IsDBNull(dr["Ngoại ngữ"]) ? string.Empty : Convert.ToString(dr["Ngoại ngữ"]).Trim();
                    if (!string.IsNullOrEmpty(ngoaingu))
                    {
                        NgoaiNgu _ngoaingu = NgoaiNgu.FindObject<NgoaiNgu>("Ten", ngoaingu);
                        if (_ngoaingu == null)
                        {
                            _ngoaingu = new NgoaiNgu(XpoDefault.Session);
                            _ngoaingu.Ten = ngoaingu;
                            _ngoaingu.Save();
                        }
                        nhansu.NgoaiNgu = _ngoaingu;
                    }

                    string tdnn = Convert.IsDBNull(dr["Trình độ ngoại ngữ"]) ? string.Empty : Convert.ToString(dr["Trình độ ngoại ngữ"]).Trim();
                    if (!string.IsNullOrEmpty(tdnn))
                    {
                        TrinhDoNgoaiNgu _tdnn = TrinhDoNgoaiNgu.FindObject<TrinhDoNgoaiNgu>("Ten", tdnn);
                        if (_tdnn == null)
                        {
                            _tdnn = new TrinhDoNgoaiNgu(XpoDefault.Session);
                            _tdnn.Ten = tdnn;
                            _tdnn.Save();
                        }
                        nhansu.TrinhDoNgoaiNgu = _tdnn;
                    }

                    string tdth = Convert.IsDBNull(dr["Trình độ tin học"]) ? string.Empty : Convert.ToString(dr["Trình độ tin học"]).Trim();
                    if (!string.IsNullOrEmpty(tdth))
                    {
                        TrinhDoTinHoc _tdth = TrinhDoTinHoc.FindObject<TrinhDoTinHoc>("Ten", tdth);
                        if (_tdth == null)
                        {
                            _tdth = new TrinhDoTinHoc(XpoDefault.Session);
                            _tdth.Ten = tdth;
                            _tdth.Save();
                        }
                        nhansu.TrinhDoTinHoc = _tdth;
                    }

                    string ttdv = Convert.IsDBNull(dr["Trạng thái đoàn"]) ? string.Empty : Convert.ToString(dr["Trạng thái đoàn"]).Trim();
                    nhansu.TrangThaiDoan = ttdv.Equals("Đoàn viên") ? (int)TrangThaiDoan.DoanVien :
                                               ttdv.Equals("Trưởng thành") ? (int)TrangThaiDoan.TruongThanh :
                                               ttdv.Equals("Xóa tên") ? (int)TrangThaiDoan.XoaTen :
                                               (int)TrangThaiDoan.ThanhNien;

                    try { nhansu.NgayVaoDoan = Convert.ToDateTime(dr["Ngày vào đoàn"]); } catch (Exception) { nhansu.NgayVaoDoan = DateTime.MinValue; }

                    string chucvudoan = Convert.IsDBNull(dr["Chức vụ đoàn"]) ? string.Empty : Convert.ToString(dr["Chức vụ đoàn"]).Trim();
                    if (!string.IsNullOrEmpty(chucvudoan))
                    {
                        ChucVuDoan _chucvudoan = ChucVuDoan.FindObject<ChucVuDoan>("Ten", chucvudoan);
                        if (_chucvudoan == null)
                        {
                            _chucvudoan = new ChucVuDoan(XpoDefault.Session);
                            _chucvudoan.Ten = chucvudoan;
                            _chucvudoan.Save();
                        }
                        nhansu.ChucVuDoan = _chucvudoan;
                    }

                    string ttdangvien = Convert.IsDBNull(dr["Đảng viên"]) ? string.Empty : Convert.ToString(dr["Đảng viên"]).Trim();
                    nhansu.DangVien = ttdangvien.Equals("Dự bị") ? (int)DangVien.DuBi :
                                               ttdv.Equals("Chính thức") ? (int)DangVien.ChinhThuc :
                                               (int)DangVien.Khong;
                    try { nhansu.NgayVaoDang = Convert.ToDateTime(dr["Ngày vào đảng"]); } catch (Exception) { nhansu.NgayVaoDang = DateTime.MinValue; }

                    string chucvudang = Convert.IsDBNull(dr["Chức vụ đảng"]) ? string.Empty : Convert.ToString(dr["Chức vụ đảng"]).Trim();
                    if (!string.IsNullOrEmpty(chucvudang))
                    {
                        ChucVuDang _chucvudang = ChucVuDang.FindObject<ChucVuDang>("Ten", chucvudang);
                        if (_chucvudang == null)
                        {
                            _chucvudang = new ChucVuDang(XpoDefault.Session);
                            _chucvudang.Ten = chucvudang;
                            _chucvudang.Save();
                        }
                        nhansu.ChucVuDang = _chucvudang;
                    }

                    nhansu.GhiChu = Convert.ToString(dr["Ghi chú"]);

                    nhansu.Save();
                    iCount++;
                    MsgBox.ShowWaitForm(string.Format("Đang import {0}/{1} hồ sơ", iCount, dtExcel.Rows.Count));
                }
                catch (Exception ex)
                {
                    if (ex.Message.Contains("does not belong to table"))
                    {
                        MsgBox.ShowWarningDialog(string.Format("Sheet excel [{0}] dùng để import không hợp lệ", sheetName));
                        return false;
                    }
                }
            }

            MsgBox.ShowSuccessfulDialog(string.Format("Đã import {0}/{1} hồ sơ!", iCount, dtExcel.Rows.Count));

            return true;
        }
    }
}