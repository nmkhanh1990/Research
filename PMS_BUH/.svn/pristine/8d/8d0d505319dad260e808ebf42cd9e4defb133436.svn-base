using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.XtraEditors;
using PMS.Services;
using PMS.Entities;
using DevExpress.XtraEditors.Controls;
using PMS.UI.Forms.BaoCao;
using DevExpress.Common.Grid;
using System.Windows.Forms;

namespace PMS.PMS_Control
{
    public partial class NamHocHocKy : GridLookUpEdit
    {
        TList<CauHinhChung> _cauHinhChung = DataServices.CauHinhChung.GetAll();
        GridLookUpEdit cboNamHoc, cboHocKy;
        BindingSource BindingSourceNamHoc, BindingSourceHocKy;

        public NamHocHocKy()
        {
            InitializeComponent();
            cboNamHoc = new GridLookUpEdit();
            cboHocKy = new GridLookUpEdit();
            BindingSourceNamHoc = new BindingSource();
            BindingSourceHocKy = new BindingSource();
            this.EditValueChanged += new EventHandler(cboNamHoc_EditValueChanged);
        }

        void ShowColumnsData()
        {
            #region Nam hoc
            AppGridLookupEdit.InitGridLookUp(cboNamHoc, true, TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboNamHoc, new string[] { "NamHoc" }, new string[] { "Năm học" });
            cboNamHoc.Properties.ValueMember = "NamHoc";
            cboNamHoc.Properties.DisplayMember = "NamHoc";
            cboNamHoc.Properties.NullText = string.Empty;
            cboNamHoc.EditValue = PMS.Common.Globals.GetMaTruong(_cauHinhChung, "Năm học hiện tại");

            #endregion

            #region Hoc ky
            AppGridLookupEdit.InitGridLookUp(cboHocKy, true, TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboHocKy, new string[] { "MaHocKy", "TenHocKy" }, new string[] { "Mã học kỳ", "Tên học kỳ" });
            cboHocKy.Properties.ValueMember = "MaHocKy";
            cboHocKy.Properties.DisplayMember = "TenHocKy";
            cboHocKy.Properties.NullText = string.Empty;
            cboHocKy.EditValue = PMS.Common.Globals.GetMaTruong(_cauHinhChung, "Học kỳ hiện tại");
            #endregion
        }

        void ShowDataBase()
        {
            BindingSourceNamHoc.DataSource = DataServices.ViewNamHoc.GetAll();
            if (cboNamHoc.EditValue != null)
                BindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
            cboNamHoc.Properties.DataSource = BindingSourceNamHoc;
            cboHocKy.Properties.DataSource = BindingSourceHocKy;


        }

        private void cboNamHoc_EditValueChanged(object sender, EventArgs e)
        {
            if (cboNamHoc.EditValue != null)
                BindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
            
        }

        public NamHocHocKy(IContainer container)
        {
            container.Add(this);
            InitializeComponent();
            
        }
    }
}
