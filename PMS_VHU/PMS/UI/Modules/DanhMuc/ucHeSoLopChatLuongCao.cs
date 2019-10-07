using DevExpress.Common.Grid;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using PMS.Core;
using PMS.Entities;
using PMS.Entities.Validation;
using PMS.Services;
using PMS.UI.Forms.NghiepVu;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PMS.UI.Modules.DanhMuc
{
    public partial class ucHeSoLopChatLuongCao : DevExpress.XtraEditors.XtraUserControl
    {
        #region Phân quyền cập nhật
        public void KhongDuocPhepCapNhat(string value)
        {
            if (value.ToLower() == "true")
            {
                btnLuu.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                btnLuu.ItemShortcut = DevExpress.XtraBars.BarShortcut.Empty;

                btnXoa.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                btnXoa.ItemShortcut = DevExpress.XtraBars.BarShortcut.Empty;
            }
            else
            {
                btnLuu.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                btnXoa.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            }
        }
        #endregion

        #region Variable
        TList<CauHinhChung> _cauHinhChung = DataServices.CauHinhChung.GetAll();
        string _maTruong, _cauHinhHeSoTheoNam;
        #endregion

        public ucHeSoLopChatLuongCao()
        {
            InitializeComponent();
            _maTruong = _cauHinhChung.Find(p => p.TenCauHinh == "Mã trường").GiaTri;
            _cauHinhHeSoTheoNam = _cauHinhChung.Find(p => p.TenCauHinh == "Cấu hình các hệ số tính giờ giảng theo năm").GiaTri;
        }

        private void ucHeSoLopChatLuongCao_Load(object sender, EventArgs e)
        {
            #region Init Gridview
            AppGridView.InitGridView(gridViewHeSoLopChatLuongCao, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, false, "Nhấn vào đây để thêm dòng mới");
            AppGridView.ShowEditor(gridViewHeSoLopChatLuongCao, DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top);
            AppGridView.ShowField(gridViewHeSoLopChatLuongCao, new string[] { "Id", "MaNhomGvTinhDonGia", "HeSoThuong", "HeSoClc" },
                        new string[] { "ID", "Nhóm giảng viên", "Hệ số thêm", "Hệ số CLC" },
                        new int[] { 90, 200, 80, 80 });
            AppGridView.HideField(gridViewHeSoLopChatLuongCao, new string[] { "Id" });
            AppGridView.AlignHeader(gridViewHeSoLopChatLuongCao, new string[] { "MaNhomGvTinhDonGia", "HeSoThuong", "HeSoClc" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.RegisterControlField(gridViewHeSoLopChatLuongCao, "MaNhomGvTinhDonGia", repositoryItemGridLookUpEditNhomGiangVien);
            //AppGridView.RegisterControlField(gridViewHeSoLopChatLuongCao, "MaChucDanh", repositoryItemGridLookUpEditNhomGiangVien);
            if (_cauHinhHeSoTheoNam.ToLower() == "true")
            {
                layoutControlItem3.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                cboHocKy.EditValue = "";
            }
            #endregion

            #region NamHoc
            AppGridLookupEdit.InitGridLookUp(cboNamHoc, true, TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboNamHoc, new string[] { "NamHoc" }, new string[] { "Năm học" });
            cboNamHoc.Properties.ValueMember = "NamHoc";
            cboNamHoc.Properties.DisplayMember = "NamHoc";
            cboNamHoc.Properties.NullText = string.Empty;
            cboNamHoc.EditValue = _cauHinhChung.Find(p => p.TenCauHinh == "Năm học hiện tại").GiaTri;
            #endregion

            #region HocKy
            AppGridLookupEdit.InitGridLookUp(cboHocKy, true, TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboHocKy, new string[] { "MaHocKy", "TenHocKy" }, new string[] { "Mã học kỳ", "Tên học kỳ" });
            cboHocKy.Properties.ValueMember = "MaHocKy";
            cboHocKy.Properties.DisplayMember = "TenHocKy";
            cboHocKy.Properties.NullText = string.Empty;
            cboHocKy.EditValue = _cauHinhChung.Find(p => p.TenCauHinh == "Học kỳ hiện tại").GiaTri;
            #endregion

            #region Nhóm giảng viên lấy đơn giá
            AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(repositoryItemGridLookUpEditNhomGiangVien, TextEditStyles.Standard);
            AppRepositoryItemGridLookUpEdit.ShowField(repositoryItemGridLookUpEditNhomGiangVien, new string[] { "MaNhom", "TenNhom" }
                , new string[] { "Mã nhóm", "Tên nhóm" }, new int[] { 80, 300 });
            repositoryItemGridLookUpEditNhomGiangVien.DisplayMember = "TenNhom";
            repositoryItemGridLookUpEditNhomGiangVien.ValueMember = "MaNhom";
            repositoryItemGridLookUpEditNhomGiangVien.NullText = string.Empty;
            #endregion

            //#region Check CBO BacDaoTao
            //repositoryItemCheckedComboBoxEditBacDaoTao.SelectAllItemCaption = "";
            //repositoryItemCheckedComboBoxEditBacDaoTao.Items.Clear();
            //repositoryItemCheckedComboBoxEditBacDaoTao.SeparatorChar = ';';
            //repositoryItemCheckedComboBoxEditBacDaoTao.TextEditStyle = TextEditStyles.Standard;
            //VList<ViewBacDaoTao> _Tlist = DataServices.ViewBacDaoTao.GetAll();
            //List<CheckedListBoxItem> list = new List<CheckedListBoxItem>();
            //foreach (ViewBacDaoTao v in _Tlist)
            //{
            //    list.Add(new CheckedListBoxItem(v.MaBacDaoTao, v.TenBacDaoTao, CheckState.Unchecked, true));
            //}
            //repositoryItemCheckedComboBoxEditBacDaoTao.Items.AddRange(list.ToArray());
            //#endregion

            InitData();
        }

        #region InitData
        void InitData()
        {
            
            bindingSourceNhomGiangVien.DataSource = DataServices.LoaiGiangVien.GetAll();
            bindingSourceNamHoc.DataSource = DataServices.ViewNamHoc.GetAll();
            bindingSourceNhomGiangVien.DataSource = DataServices.NhomGiangVienTinhDonGia.GetAll();
            if (cboNamHoc.EditValue != null)
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
                bindingSourceHeSoClc.DataSource = DataServices.HeSoChatLuongCao.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
        }
        #endregion

        private void btnLamTuoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            InitData();
            Cursor.Current = Cursors.Default;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AppGridView.DeleteSelectedRows(gridViewHeSoLopChatLuongCao);
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            gridViewHeSoLopChatLuongCao.FocusedRowHandle = -1;
            TList<HeSoChatLuongCao> list = bindingSourceHeSoClc.DataSource as TList<HeSoChatLuongCao>;
            if (list != null)
            {
                if (XtraMessageBox.Show("Bạn có muốn lưu các thay đổi không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        if (list.IsValid)
                        {
                            foreach (HeSoChatLuongCao h in list)
                            {
                                h.NamHoc = cboNamHoc.EditValue.ToString();
                                h.HocKy = cboHocKy.EditValue.ToString();
                            }

                            bindingSourceHeSoClc.EndEdit();
                            DataServices.HeSoChatLuongCao.Save(list);
                            PMS.Common.Globals.SaveLayout(Tag as AppModule, new object[] { gridViewHeSoLopChatLuongCao, barManager1, layoutControl1 });
                            XtraMessageBox.Show("Bạn đã lưu các thay đổi thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                            XtraMessageBox.Show(string.Format("Có {0} dòng chứa dữ liệu không hợp lệ.", list.InvalidItems.Count), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch
                    {
                        XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình lưu các thay đổi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            Cursor.Current = Cursors.Default;
        }

        private void gridViewHeSoChatLuongCao_KeyUp(object sender, KeyEventArgs e)
        {
            AppGridView.DeleteSelectedRows(gridViewHeSoLopChatLuongCao, e);
        }

        private void gridViewHeSoChatLuongCao_KeyDown(object sender, KeyEventArgs e)
        {
            AppGridView.CopyCell(gridViewHeSoLopChatLuongCao, e);
        }

        private void gridViewHeSoChatLuongCao_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            HeSoLuong obj = e.Row as HeSoLuong;
            if (obj != null)
            {
                obj.AddValidationRuleHandler(RuleCheckDuplicate, "Id");
                if (obj.IsValid)
                    e.Valid = true;
                else
                {
                    XtraMessageBox.Show(obj.Error, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    e.Valid = false;
                }
            }
        }

        private bool RuleCheckDuplicate(object target, ValidationRuleArgs e)
        {
            HeSoChatLuongCao obj = target as HeSoChatLuongCao;
            if (obj != null)
            {
                if (((TList<HeSoChatLuongCao>)bindingSourceHeSoClc.DataSource).FindAll(p => p.Id == obj.Id).Count > 1)
                {
                    e.Description = string.Format("Mã quản lý {0} hiện tại đã có.", obj.Id);
                    return false;
                }
            }
            return true;
        }

        private void gridViewHeSoChatLuongCao_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {
            e.ExceptionMode = ExceptionMode.NoAction;
        }

        private void cboNamHoc_EditValueChanged(object sender, EventArgs e)
        {
            if (cboNamHoc.EditValue != null)
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
                bindingSourceHeSoClc.DataSource = DataServices.HeSoChatLuongCao.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
        }

        private void cboHocKy_EditValueChanged(object sender, EventArgs e)
        {
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
                bindingSourceHeSoClc.DataSource = DataServices.HeSoChatLuongCao.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
        }

        private void btnSaoChep_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (_cauHinhHeSoTheoNam.ToLower() == "true")
            {
                using (frmSaoChepNamHoc frm = new frmSaoChepNamHoc(cboNamHoc.EditValue.ToString(), "SaoChepHeSoChatLuongCao"))
                {
                    frm.ShowDialog();
                }
            }
            else
            {
                using (frmSaoChepNamHocHocKy frm = new frmSaoChepNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), "SaoChepHeSoChatLuongCao"))
                {
                    frm.ShowDialog();
                }
            }
            InitData();
        }

    }
}
