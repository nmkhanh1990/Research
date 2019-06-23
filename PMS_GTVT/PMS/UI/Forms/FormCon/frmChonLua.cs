using DevExpress.Common.Grid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PMS.UI.Forms.FormCon
{
    public partial class frmChonLua : Form
    {
        object _dataSource;
        bool _multiSelect;
        bool _duocXacNhan;

        public frmChonLua()
        {
            InitializeComponent();
            _dataSource = null;
            _multiSelect = false;
            _duocXacNhan = false;
        }

        /// <summary>
        /// Khởi tạo form chọn lựa.
        /// </summary>
        /// <param name="danh_sach">Danh sách các mục cho phép chọn.</param>
        /// <param name="chon_nhieu">Cho phép chọn nhiều mục cùng lúc hay không.</param>
        public frmChonLua(object danh_sach, bool chon_nhieu)
        {
            InitializeComponent();
            _dataSource = danh_sach;
            _multiSelect = chon_nhieu;
            _duocXacNhan = false;
        }

        public object DataSource
        {
            get { return _dataSource; }
            set { _dataSource = value; }
        }
        public bool ChonNhieu
        {
            get { return _multiSelect; }
            set { _multiSelect = value; }
        }
        public object CacGiaTriDuocChon
        {
            get { return _duocXacNhan ? checkedListBoxChonNhieu.SelectedValue : null; }
        }

        public string GiaTriDuocChon
        {
            get { return _duocXacNhan ? cboChonMot.EditValue.ToString() : null; }
        }

        private void frmChonLua_Load(object sender, EventArgs e)
        {
            bindingSourceChonMot.DataSource = _multiSelect ? null : _dataSource;
            bindingSourceChonNhieu.DataSource = _multiSelect ? _dataSource : null;
        }

        private void cboChonMot_EditValueChanged(object sender, EventArgs e)
        {
            //checkedListBoxChonNhieu.Items.Add(cboChonMot.EditValue);
            txtDaChon.Text = cboChonMot.EditValue.ToString();
        }

        public void ThietLapViewComboBox(string[] show_field, string[] show_field_name, int[] column_width, string value_member, string display_member, int width, int height)
        {
            AppGridLookupEdit.InitGridLookUp(cboChonMot, show_field, show_field_name, column_width, value_member, display_member, width, height);
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            _duocXacNhan = true;
            this.Hide();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
