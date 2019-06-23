﻿using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.Common.Grid;
using PMS.Entities;
using DevExpress.XtraTreeList.Nodes;
using DevExpress.XtraTreeList;
using PMS.Services;
using PMS.BLL;


namespace PMS.UI.Forms.HeThong
{
    public partial class frmPhanQuyenEx : XtraForm
    {
        private TList<ChucNang> listChucNang;
        int i_NhomQuyen = 0;

        public frmPhanQuyenEx()
        {
            InitializeComponent();
        }

        private void frmPhanQuyenEx_Load(object sender, EventArgs e)
        {
            #region GridLookupEdit NhomQuyen
            AppGridLookupEdit.InitGridLookUp(cboNhomQuyen, true, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboNhomQuyen, new string[] { "TenNhomQuyen", "GhiChu" }, new string[] { "Tên nhóm", "Khoa" });
            cboNhomQuyen.Properties.DisplayMember = "TenNhomQuyen";
            cboNhomQuyen.Properties.ValueMember = "MaNhomQuyen";
            cboNhomQuyen.Properties.NullText = "[Chọn nhóm quyền]";
            #endregion

            #region Init Datasource            
            treeListChucNang.ParentFieldName = "ParentId";
            treeListChucNang.KeyFieldName = "Id";
            ShowDataTreeList(true);
            ShowDataNhomQuyen((Int32)UserInfo.GroupID);

            #endregion
        }

        private void ShowDataNhomQuyen(int groupID)
        {
            try
            {
                cboNhomQuyen.DataBindings.Clear();
                bindingSourceNhomQuyen.DataSource = DataServices.NhomQuyen.GetByMaNhomQuyen(groupID);
                cboNhomQuyen.DataBindings.Add("EditValue", bindingSourceNhomQuyen, "MaNhomQuyen", true, DataSourceUpdateMode.Never);
                ChonNhomQuyen(groupID);
            }
            catch (Exception ex)
            {
                PMS.Common.XuLyGiaoDien.ThongBaoLoi(ex, true);
            }
        }

        private void ChonNhomQuyen(int iNhomQuyen)
        {
            TList<NhomChucNang> listNhomChucNang = DataServices.NhomChucNang.GetByMaNhomQuyen(iNhomQuyen);
            foreach (ChucNang c in listChucNang)
            {
                TreeListNode node = treeListChucNang.FindNodeByFieldValue("Id", c.Id);
                if (listNhomChucNang.Exists(p => p.MaChucNang == c.Id))
                {
                    if (node != null)
                        node.CheckState = CheckState.Checked;
                }
                else
                    node.CheckState = CheckState.Unchecked;
                //Init CheckState
                AppTreeList.SetCheckedParentNodes(node, node.CheckState);
            }
        }

        private void ShowDataTreeList(bool v)
        {
            listChucNang = DataServices.ChucNang.GetByTrangThai(v);
            treeListChucNang.DataSource = listChucNang;
            treeListChucNang.ExpandAll();
        }

        private void treeListChucNang_AfterCheckNode(object sender, NodeEventArgs e)
        {
            AppTreeList.SetCheckedChildNodes(e.Node, e.Node.CheckState);
            AppTreeList.SetCheckedParentNodes(e.Node, e.Node.CheckState);
        }

        private void treeListChucNang_BeforeCheckNode(object sender, CheckNodeEventArgs e)
        {
            e.State = (e.PrevState == CheckState.Checked ? CheckState.Unchecked : CheckState.Checked);
        }

        private void btnLamTuoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            ShowDataTreeList(true);
            ShowDataNhomQuyen((Int32)UserInfo.GroupID);
            Cursor.Current = Cursors.Default;
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (i_NhomQuyen == 0)
            {
                XtraMessageBox.Show("Bạn chưa chọn nhóm cần phân quyền !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboNhomQuyen.Focus();
                return;
            }
            if (XtraMessageBox.Show("Bạn có muốn lưu các thay đổi không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Cursor.Current = Cursors.WaitCursor;
                try
                {
                    TList<NhomChucNang> listNhomChucNang = DataServices.NhomChucNang.GetByMaNhomQuyen(i_NhomQuyen);
                    foreach (ChucNang c in listChucNang)
                    {
                        TreeListNode node = treeListChucNang.FindNodeByFieldValue("Id", c.Id);


                        if ((node.CheckState == CheckState.Checked) || (node.CheckState == CheckState.Indeterminate))
                        {
                            NhomChucNang objNhomChucNang = listNhomChucNang.Find(p => p.MaChucNang == c.Id);
                            if (objNhomChucNang != null)
                            {
                                objNhomChucNang.MaChucNang = c.Id;
                                objNhomChucNang.MaNhomQuyen = (int)cboNhomQuyen.EditValue;
                            }
                            else
                                objNhomChucNang = new NhomChucNang { MaNhomQuyen = (int)cboNhomQuyen.EditValue, MaChucNang = c.Id };
                            objNhomChucNang.Validate();
                            if (objNhomChucNang.IsValid)
                            {
                                DataServices.NhomChucNang.Save(objNhomChucNang);
                            }
                        }
                        else
                        {
                            NhomChucNang objNhomChucNang = DataServices.NhomChucNang.GetByMaChucNangMaNhomQuyen(c.Id, (int)cboNhomQuyen.EditValue);
                            if (objNhomChucNang != null)
                                DataServices.NhomChucNang.Delete(objNhomChucNang);
                        }
                    }
                    XtraMessageBox.Show("Bạn đã lưu các thay đổi thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình lưu các thay đổi." + ex.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                Cursor.Current = Cursors.Default;
            }
        }

        private void ChonNhomQuyen()
        {
            NhomQuyen objNhomQuyen = bindingSourceNhomQuyen.Current as NhomQuyen;
            if (objNhomQuyen != null)
            {
                //Init
                TList<NhomChucNang> listNhomChucNang = DataServices.NhomChucNang.GetByMaNhomQuyen(objNhomQuyen.MaNhomQuyen);
                foreach (ChucNang c in listChucNang)
                {
                    TreeListNode node = treeListChucNang.FindNodeByFieldValue("Id", c.Id);
                    if (listNhomChucNang.Exists(p => p.MaChucNang == c.Id))
                    {
                        if (node != null)
                            node.CheckState = CheckState.Checked;
                    }
                    else
                        node.CheckState = CheckState.Unchecked;
                    //Init CheckState
                    AppTreeList.SetCheckedParentNodes(node, node.CheckState);
                }
            }
        }

        private void frmPhanQuyen_FormClosing(object sender, FormClosingEventArgs e)
        {
            cboNhomQuyen.Dispose();
            treeListChucNang.Dispose();
        }

        private void cboNhomQuyen_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            if (e.Value != null)
            {
                NhomQuyen objNhomQuyen = cboNhomQuyen.Properties.GetRowByKeyValue(e.Value) as NhomQuyen;
                if (objNhomQuyen != null)
                {
                    //Init
                    ChonNhomQuyen(objNhomQuyen.MaNhomQuyen);
                }
            }
        }

        private void treeListChucNang_DoubleClick(object sender, EventArgs e)
        {
            ChucNang objChucNang = treeListChucNang.GetDataRecordByNode(treeListChucNang.Nodes.TreeList.FocusedNode) as ChucNang;
            if (objChucNang != null)
            {
                if (objChucNang.PhanLoai == "Item" || objChucNang.PhanLoai == "Module")
                {

                }
            }
        }

        private void cboNhomQuyen_EditValueChanged(object sender, EventArgs e)
        {
            if (cboNhomQuyen.EditValue != null)
            {
                Cursor.Current = Cursors.WaitCursor;
                i_NhomQuyen = int.Parse(cboNhomQuyen.EditValue.ToString());
                ChonNhomQuyen(i_NhomQuyen);
                Cursor.Current = Cursors.Default;
            }
        }
    }
}