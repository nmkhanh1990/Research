using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Common.Grid;
using DevExpress.XtraEditors.Controls;
using PMS.Entities;
using PMS.Services;

namespace PMS.PMS_Control
{
    public partial class ucNamHocHocKy : UserControl
    {
        TList<CauHinhChung> _cauHinhChung = DataServices.CauHinhChung.GetAll();
        public ucNamHocHocKy()
        {
            InitializeComponent();
        }

        public string NamHoc { get; set; }
        public string HocKy { get; set; }

        private void ucNamHocHocKy_Load(object sender, EventArgs e)
        {
            ShowNamHoc();
            ShowLoadData();
        }

        private void ShowNamHoc()
        {
            AppGridLookupEdit.InitGridLookUp(cboNamHoc, true, TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboNamHoc, new string[] { "NamHoc" }, new string[] { "Năm học" });
            cboNamHoc.Properties.ValueMember = "NamHoc";
            cboNamHoc.Properties.DisplayMember = "NamHoc";
            cboNamHoc.Properties.NullText = string.Empty;
            cboNamHoc.EditValue = PMS.Common.Globals.GetMaTruong(_cauHinhChung, "Năm học hiện tại");

            AppGridLookupEdit.InitGridLookUp(cboHocky, true, TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboHocky, new string[] { "MaHocKy", "TenHocKy" }, new string[] { "Mã học kỳ", "Tên học kỳ" });
            cboHocky.Properties.ValueMember = "MaHocKy";
            cboHocky.Properties.DisplayMember = "TenHocKy";
            cboHocky.Properties.NullText = string.Empty;
            cboHocky.EditValue = PMS.Common.Globals.GetMaTruong(_cauHinhChung, "Học kỳ hiện tại");
        }

        private void ShowLoadData()
        {
            bindingSourceNamHoc.DataSource = DataServices.ViewNamHoc.GetAll();
            if (cboNamHoc.EditValue != null)
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
            cboNamHoc.Properties.DataSource = bindingSourceNamHoc;
            cboHocky.Properties.DataSource = bindingSourceHocKy;
        }

        private void cboNamHoc_EditValueChanged(object sender, EventArgs e)
        {
            if (cboNamHoc.EditValue != null)
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
        }
    }
}
