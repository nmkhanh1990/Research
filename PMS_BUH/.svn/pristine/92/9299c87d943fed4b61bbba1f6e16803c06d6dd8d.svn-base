using DevExpress.Common.Grid;
using DevExpress.XtraEditors;
using PMS.BLL;
using PMS.Entities;
using PMS.Services;
using System;
using System.Windows.Forms;

namespace PMS.UI.Forms.NghiepVu
{
    public partial class frmDoiLoaiBacLuong : DevExpress.XtraEditors.XtraForm
    {
        #region Variable
        public int MaGiangVien;
        ViewGiangVien vGiangVien = new ViewGiangVien();
        string strLoaiBLHT = string.Empty;
        #endregion
        public frmDoiLoaiBacLuong()
        {
            InitializeComponent();
            
        }
        public frmDoiLoaiBacLuong(int maGiangVien)
        {
            MaGiangVien = maGiangVien;
            InitializeComponent();
        }

        private void frmDoiLoaiGiangVien_Load(object sender, EventArgs e)
        {
            vGiangVien = DataServices.ViewGiangVien.Get("MaGiangVien = " + MaGiangVien, "MaGiangVien")[0];
            txtMaGiangVien.Text = vGiangVien.MaQuanLy;
            txtHoTen.Text = vGiangVien.HoTen;
            txtLoaiBLHienTai.Text = vGiangVien.TenBacLuong;
            strLoaiBLHT = vGiangVien.MaBacLuong;

            AppGridLookupEdit.InitGridLookUp(cboLoaiBacLuongMoi, true, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboLoaiBacLuongMoi, new string[] { "MaBacLuong", "TenBacLuong" }, new string[] { "Mã loại bậc lương", "Tên loại bậc lương" });
            cboLoaiBacLuongMoi.Properties.ValueMember = "MaBacLuong";
            cboLoaiBacLuongMoi.Properties.DisplayMember = "TenBacLuong";
            cboLoaiBacLuongMoi.Properties.NullText = string.Empty;
            bindingSourceLoaiGiangVien.DataSource = DataServices.BacLuong.GetAll();

            dateEditNgayHieuLuc.Text = DateTime.Now.ToShortDateString();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                if (cboLoaiBacLuongMoi.EditValue == null)
                {
                    XtraMessageBox.Show("Hãy chọn loại bậc lương mới cho giảng viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (XtraMessageBox.Show("Bạn có muốn lưu các thay đổi không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Cursor.Current = Cursors.WaitCursor;
                    int kq = 0;
                    DataServices.GiangVienThayDoiBacLuong.Luu(vGiangVien.MaGiangVien, int.Parse(vGiangVien.MaBacLuong), int.Parse(cboLoaiBacLuongMoi.EditValue.ToString()), dateEditNgayHieuLuc.DateTime, DateTime.Now, UserInfo.UserName, ref kq);
                    if (kq == 0)
                    {
                        XtraMessageBox.Show("Thay đổi loại bậc lương thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình lưu thay đổi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    Cursor.Current = Cursors.Default;
                }
            }
            catch (Exception ex)
            {
                PMS.Common.XuLyGiaoDien.ThongBaoLoi(ex, true);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cboLoaiGiangVienMoi_EditValueChanged(object sender, EventArgs e)
        {
            if (cboLoaiBacLuongMoi.EditValue != null)
            {
                if (cboLoaiBacLuongMoi.EditValue.ToString() == strLoaiBLHT)
                {
                    XtraMessageBox.Show("Loại bậc lương thay đổi giống bậc lương hiện tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
        }
    }
}