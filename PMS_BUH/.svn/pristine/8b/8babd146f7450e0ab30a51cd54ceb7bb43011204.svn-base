using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.Common.Grid;
using PMS.Entities;
using PMS.Services;

namespace PMS.UI.Forms.NghiepVu
{
    public partial class frmDongBoThongTingGiangVienTuHRM : DevExpress.XtraEditors.XtraForm
    {
        TList<CauHinhChung> _cauHinhChung = DataServices.CauHinhChung.GetAll();
        string _maTruong;

        public frmDongBoThongTingGiangVienTuHRM()
        {
            InitializeComponent();           
            _maTruong =PMS.Common.Globals.GetMaTruong( _cauHinhChung,"Mã trường");
            //if (_maTruong == "IUH")
            //    btnLamTuoi.Caption = "Cập nhật mới";
        }

        private void frmSoSanhChiTietLHPThanhTraVaTKB_Load(object sender, EventArgs e)
        {
            #region InitGrid Thông Tin Giảng Viên PMS
            AppGridView.InitGridView(gridViewTTGV_PMS, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, false);
            AppGridView.ShowField(gridViewTTGV_PMS, new string[] { "XacNhan", "IdHrm", "NameHrm", "IdPms", "NamePms", "LoaiDuLieu", "Stt", "GhiChu"}
                , new string[] { "Chọn", "Mã HRM", "Tên HRM", "Mã PMS", "Tên PMS", "Tên Bảng", "STT", "Ghi chú"}
                , new int[] { 100, 100, 180, 100, 180, 120, 100, 200 });
            AppGridView.AlignHeader(gridViewTTGV_PMS, new string[] { "XacNhan", "IdHrm", "NameHrm", "IdPms", "NamePms", "LoaiDuLieu", "Stt", "GhiChu" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.SummaryField(gridViewTTGV_PMS, "LoaiDuLieu", "{0}", DevExpress.Data.SummaryItemType.Count);
            AppGridView.HideField(gridViewTTGV_PMS, new string[] { "Stt" });
            gridViewTTGV_PMS.Columns["LoaiDuLieu"].GroupIndex = 0;
            #endregion

            InitData();

        }

        void InitData()
        {
            DataTable tbl = new DataTable();
            IDataReader dR = DataServices.GiangVien.LayDuLieuDongBoTuHRM();
            tbl.Load(dR);

            bindingSourceTTGV_PMS.DataSource = CreateTable(tbl);

        }

        private void btnLamTuoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            InitData();
            Cursor.Current = Cursors.Default;
        }

        private void btnLocDuLieu_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            
            Cursor.Current = Cursors.Default;
        }

        #region ToMau
        void ToMauTKB(DataTable list)
        {
            //--Cột khác: 
            //--1 là Khác thời khoá biểu, 
            //--2 là trùng lịch nhưng số tiết ghi nhận ít hơn tiến độ, 
            //--3 là trùng lịch nhưng ghi nhận nhiều hơn tiến độ,
            //--4 là thanh tra giống tkb
            //--0 là chưa thanh tra
            try
            {
                if (list.Rows.Count > 0)
                {
                    foreach (DataRow v in list.Rows)
                    {
                        if (v["Khac"].ToString() == "1")
                        {
                            AppGridView.ConditionsAdjustment(gridViewTTGV_PMS, "Khac", DevExpress.XtraGrid.FormatConditionEnum.Equal, true, Color.Red, v["Khac"]);
                        }
                        if (v["Khac"].ToString() == "2")
                        {
                            AppGridView.ConditionsAdjustment(gridViewTTGV_PMS, "Khac", DevExpress.XtraGrid.FormatConditionEnum.Equal, true, Color.Yellow, v["Khac"]);
                        }
                        if (v["Khac"].ToString() == "3")
                        {
                            AppGridView.ConditionsAdjustment(gridViewTTGV_PMS, "Khac", DevExpress.XtraGrid.FormatConditionEnum.Equal, true, Color.Cyan, v["Khac"]);
                        }
                        if (v["Khac"].ToString() == "4")
                        {
                            AppGridView.ConditionsAdjustment(gridViewTTGV_PMS, "Khac", DevExpress.XtraGrid.FormatConditionEnum.Equal, true, Color.Lime, v["Khac"]);
                        }
                    }
                }
            }
            catch
            { }

        }



        //void ToMauThanhTra(DataTable list)
        //{
        //    try
        //    {
        //        if (list.Rows.Count > 0)
        //        {
        //            foreach (DataRow v in list.Rows)
        //            {
        //                if (v["Khac"].ToString() == "1")
        //                {
        //                    AppGridView.ConditionsAdjustment(gridViewTTGV_HRM, "Khac", DevExpress.XtraGrid.FormatConditionEnum.Equal, true, Color.Red, v["Khac"]);
        //                }
        //                if (v["Khac"].ToString() == "2")
        //                {
        //                    AppGridView.ConditionsAdjustment(gridViewTTGV_HRM, "Khac", DevExpress.XtraGrid.FormatConditionEnum.Equal, true, Color.Yellow, v["Khac"]);
        //                }
        //                if (v["Khac"].ToString() == "3")
        //                {
        //                    AppGridView.ConditionsAdjustment(gridViewTTGV_HRM, "Khac", DevExpress.XtraGrid.FormatConditionEnum.Equal, true, Color.Cyan, v["Khac"]);
        //                }
        //                if (v["Khac"].ToString() == "4")
        //                {
        //                    AppGridView.ConditionsAdjustment(gridViewTTGV_HRM, "Khac", DevExpress.XtraGrid.FormatConditionEnum.Equal, true, Color.Lime, v["Khac"]);
        //                }
        //            }
        //        }
        //    }
        //    catch
        //    { }

        //}
        #endregion

        private void btn_Luu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                gridViewTTGV_PMS.FocusedRowHandle = -1;
                DataTable dt = gridViewTTGV_PMS.DataSource as DataTable;
                if (dt != null)
                {
                    if (XtraMessageBox.Show("Bạn muốn lưu thay đổi?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        string xmlData = "";
                        foreach (DataRow r in dt.Rows)
                        {
                            if (r.RowState == DataRowState.Modified)
                            {
                                xmlData += "<Input XN=\"" + r["XacNhan"]
                                        + "\" IdHrm=\"" + r["IdHrm"]
                                        + "\" NameHrm=\"" + r["NameHrm"]
                                        + "\" IdPms=\"" + r["IdPms"]
                                        + "\" NamePms=\"" + r["NamePms"]
                                        + "\" LoaiDuLieu=\"" + r["LoaiDuLieu"]                                        
                                        + "\" />";
                            }
                        }

                        xmlData = "<Root>" + xmlData + "</Root>";
                        int result = 0;
                        DataServices.GiangVien.LayDuLieuDongBo_Luu(xmlData, ref result);
                        if (result == 0)
                            XtraMessageBox.Show("Lưu thay đổi thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            XtraMessageBox.Show("Đã có lỗi trong quá trình lưu thay đổi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                      
                    }
                }
            }
            catch
            { }
        }

        private DataTable CreateTable(DataTable tblDuLieu)
        {
            DataTable Tbl = new DataTable();
            Tbl.Columns.Add("XacNhan", typeof(Boolean));
            Tbl.Columns.Add("IdHrm", typeof(string));
            Tbl.Columns.Add("NameHrm", typeof(string));
            Tbl.Columns.Add("IdPms", typeof(string));
            Tbl.Columns.Add("NamePms", typeof(string));
            Tbl.Columns.Add("LoaiDuLieu", typeof(string));
            Tbl.Columns.Add("Stt", typeof(int));
            Tbl.Columns.Add("GhiChu", typeof(string));

            foreach (DataRow item in tblDuLieu.Rows)
            {
                DataRow itemRows = Tbl.NewRow();
                itemRows["XacNhan"] = item["XacNhan"];
                itemRows["IdHrm"] = item["IdHrm"];
                itemRows["NameHrm"] = item["NameHrm"];
                itemRows["IdPms"] = item["IdPms"];
                itemRows["NamePms"] = item["NamePms"];
                itemRows["LoaiDuLieu"] = item["LoaiDuLieu"];
                itemRows["Stt"] = item["Stt"];
                itemRows["GhiChu"] = item["GhiChu"];
                Tbl.Rows.Add(itemRows);
            }
            return Tbl;
        }

        private void btn_DongBoDuLieuHRM_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (XtraMessageBox.Show("Bạn muốn đồng bộ dữ liệu giảng viên từ hệ thống Nhân sự HRM?\nQuá trình đồng bộ có thể mất một vài phút...", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Cursor.Current = Cursors.WaitCursor;
                    DataServices.GiangVien.DongBoDuLieuHRM();
                    Cursor.Current = Cursors.Default;
                    XtraMessageBox.Show("Đồng bộ thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                
            }
            catch
            {
                XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình đồng bộ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}