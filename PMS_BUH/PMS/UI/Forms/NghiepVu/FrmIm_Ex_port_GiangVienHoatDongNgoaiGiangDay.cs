﻿using DevExpress.Common.Grid;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using PMS.Comon;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using PMS.Services;
using PMS.Entities;
using System.Windows.Forms;
using DevExpress.XtraEditors.Repository;
using DevExpress.Common.CheckedCombo;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Columns;
using PMS.BLL;
using DevExpress.XtraGrid.Views.Grid;

namespace PMS.UI.Forms.NghiepVu
{
    public partial class FrmIm_Ex_port_GiangVienHoatDongNgoaiGiangDay : Form
    {
        #region Variable
        DataTable dt = new DataTable();
        private DataParameter _inputParameter;
        
        int iLoaiHDGD;//0 là hoạt động bình thường,1 là hoạt động clc
        RepositoryItemCheckedComboBoxEdit rItem_ChkMaHoatDong = new RepositoryItemCheckedComboBoxEdit();
        VList<ViewGiangVienHoatDongNgoaiGiangDay> _VListHoatDongNgoaiGiangDay;
        VList<ViewHoatDongNgoaiGiangDayNhomClc> _VListHoatDongNgoaiGiangDayClc;
        #endregion

        public struct DataParameter
        {
            public string NamHoc;
            public string HocKy;
        }

        public string MaHoatDong { get; set; }
        public int OutPut { get; set; }

        public FrmIm_Ex_port_GiangVienHoatDongNgoaiGiangDay(string strNamHoc, string strHocKy, int iLoaiHD)
        {
            InitializeComponent();
            _inputParameter.NamHoc = strNamHoc;
            _inputParameter.HocKy = strHocKy;           
            iLoaiHDGD = iLoaiHD;
            if (iLoaiHDGD == 0) //Cho hoạt động bình thường
            {
                _VListHoatDongNgoaiGiangDay = DataServices.ViewGiangVienHoatDongNgoaiGiangDay.GetAll();
            }
            else
            {
                _VListHoatDongNgoaiGiangDayClc = DataServices.ViewHoatDongNgoaiGiangDayNhomClc.GetAll();
            }
        }

        private void btn_ChonFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog { Filter = PMS.Common.ThongBao.Str_ExcelWorkbook, Multiselect = false, ValidateNames = true };
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                Cursor.Current = Cursors.WaitCursor;
                btn_ChonFile.Text = dialog.FileName;
                using (WaitDialogForm wait = new WaitDialogForm(PMS.Common.ThongBao.Str_LoadData))
                {
                    try
                    {
                        dt = ExcelImport.ReadFromExcel(btn_ChonFile.Text);
                    }
                    catch (Exception ex)
                    {
                        PMS.Common.XuLyGiaoDien.ThongBao(
                            PMS.Common.ThongBao.Str_ThongBao
                            , PMS.Common.ThongBao.Str_LoiImport + "\n" + ex.Message + "\n" + ex.StackTrace
                            , MessageBoxIcon.Error
                            , true);
                        btn_ChonFile.Text = string.Empty;
                    }
                    finally
                    {
                        if (dt.Rows.Count > 0)
                        {
                            dt.Columns.Add("MaHoatDong", typeof(string));
                            foreach (DataRow item in dt.Rows)
                            {
                                item["MaHoatDong"] = MaHoatDong == "-1" ? GetAllMaHoatDong() : MaHoatDong;
                            }
                            bds_ImExGVHDNGD.DataSource = dt;
                            grv_IMEXGVHDNGD.OptionsView.RowAutoHeight = true;
                            wait.Close();
                            PMS.Common.XuLyGiaoDien.ThongBao(PMS.Common.ThongBao.Str_ThongBao, PMS.Common.ThongBao.Str_ImportThanhCong, MessageBoxIcon.None, true);

                        }
                    }
                }

                Cursor.Current = Cursors.Default;
            }

        }

        private string GetAllMaHoatDong()
        {
            string strResult = string.Empty;
            if(iLoaiHDGD==0)
            {
                foreach (ViewGiangVienHoatDongNgoaiGiangDay item in _VListHoatDongNgoaiGiangDay)
                {
                    strResult = strResult + item.MaHoatDong.ToString() + ";";
                }
            }
            else
            {
                foreach (ViewHoatDongNgoaiGiangDayNhomClc item in _VListHoatDongNgoaiGiangDayClc)
                {
                    strResult = strResult + item.MaQuanLy.ToString() + ";";
                }
            }
            return strResult.Substring(0, strResult.Length - 1);
        }

        private void FrmIm_Ex_port_GiangVienHoatDongNgoaiGiangDay_Load(object sender, EventArgs e)
        {
            #region InitGridView
            AppGridView.InitGridView(grv_IMEXGVHDNGD, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, false);
            AppGridView.ShowField(grv_IMEXGVHDNGD, new string[] { "Stt", "TenMonHoc", "MaLopHocPhan", "SiSo", "MaHoatDong", "MaGiangVien" },
                new string[] { "STT", "Tên môn học", "Mã lớp học phần", "Sỉ số", "Loại hoạt động", "Mã giảng viên" }
                , new int[] { 60, 130, 180, 80, 200, 100 });
            AppGridView.AlignHeader(grv_IMEXGVHDNGD, new string[] { "Stt", "TenMonHoc", "MaLopHocPhan", "SiSo", "MaHoatDong", "MaGiangVien" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.ReadOnlyColumn(grv_IMEXGVHDNGD);
            AppGridView.AllowEditColumn(grv_IMEXGVHDNGD, new string[] { "MaHoatDong", "MaGiangVien" });
            AppGridView.RegisterControlField(grv_IMEXGVHDNGD, "MaHoatDong", rItem_ChkMaHoatDong);

            #endregion

            #region Loại Hoạt Động
            LoatItemCheck();
            #endregion
        }

        private void LoatItemCheck()
        {
            List<CheckedListBoxItem> list = new List<CheckedListBoxItem>();
            rItem_ChkMaHoatDong.SelectAllItemCaption = "Tất cả";
            rItem_ChkMaHoatDong.TextEditStyle = TextEditStyles.Standard;
            rItem_ChkMaHoatDong.Items.Clear();

            if (iLoaiHDGD == 0)//Cho hoạt động bình thường
            {               
                foreach (ViewGiangVienHoatDongNgoaiGiangDay item in _VListHoatDongNgoaiGiangDay)
                {
                    list.Add(new CheckedListBoxItem(item.MaHoatDong, item.TenHoatDong, CheckState.Unchecked, true));
                }
            }
            else//Cho hoạt động clc
            {               
                foreach (ViewHoatDongNgoaiGiangDayNhomClc item in _VListHoatDongNgoaiGiangDayClc)
                {
                    list.Add(new CheckedListBoxItem(item.MaQuanLy, item.TenHoatDong, CheckState.Unchecked, true));
                }
            }
            rItem_ChkMaHoatDong.Items.AddRange(list.ToArray());
            rItem_ChkMaHoatDong.SeparatorChar = ';';
            //AppRepositoryItemGridLookUpEdit.InitRepositoryItemCheckedComboBoxEdit(rItem_ChkMaHoatDong);            
        }

        private void btn_Import_Click(object sender, EventArgs e)
        {
            try
            {
                int output = -1;
                Cursor.Current = Cursors.WaitCursor;
                string strXML = "<Root></Root>";
                strXML = PMS.Common.Globals.GetXMLFromTable(PMS.Common.XuLyGiaoDien.GetAllDataGridView(grv_IMEXGVHDNGD), _inputParameter.NamHoc, _inputParameter.HocKy,DateTime.Now.ToString("yyyy-MM-dd"),UserInfo.UserName);
                if (strXML == "<Root></Root>")
                {
                    PMS.Common.XuLyGiaoDien.ThongBao(PMS.Common.ThongBao.Str_ThongBao, PMS.Common.ThongBao.Str_KiemTraFileExcel, MessageBoxIcon.Warning, true);
                    return;
                }
                else
                {
                    DataServices.ChamTayHai.LuuImportExcel(strXML, ref output);
                    if (output == 0)
                    {
                        OutPut = output;
                        PMS.Common.XuLyGiaoDien.ThongBao(PMS.Common.ThongBao.Str_ThongBao, PMS.Common.ThongBao.Str_LuuImportThanhCong, MessageBoxIcon.None, true);
                    }
                    else
                    {
                        PMS.Common.XuLyGiaoDien.ThongBao(PMS.Common.ThongBao.Str_ThongBao, PMS.Common.ThongBao.Str_LuuImportThatBai, MessageBoxIcon.Warning, true);

                    }
                }
                this.Close();
                Cursor.Current = Cursors.Default;
            }
            catch
            {
                PMS.Common.XuLyGiaoDien.ThongBao(PMS.Common.ThongBao.Str_ThongBao,PMS.Common.ThongBao.Str_LuuImportThatBai+".......!",MessageBoxIcon.Error, true);
            }
        }
    }
}
