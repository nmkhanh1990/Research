namespace PMS.UI.Forms.NghiepVu.ChucNangCon
{
    partial class frmImportFileExcel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.gridControlCauTruc = new DevExpress.XtraGrid.GridControl();
            this.bindingSourceCauTrucImport = new System.Windows.Forms.BindingSource(this.components);
            this.gridViewCauTruc = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btnXuatFileCauTruc = new DevExpress.XtraEditors.SimpleButton();
            this.cboLoaiDuLieu = new DevExpress.XtraEditors.GridLookUpEdit();
            this.bindingSourceFileName = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btnImport = new DevExpress.XtraEditors.SimpleButton();
            this.btnXemFile = new DevExpress.XtraEditors.SimpleButton();
            this.cboSheet = new DevExpress.XtraEditors.GridLookUpEdit();
            this.bindingSourceSheet = new System.Windows.Forms.BindingSource(this.components);
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btnChonFile = new DevExpress.XtraEditors.ButtonEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem4 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCauTruc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCauTrucImport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCauTruc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboLoaiDuLieu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceFileName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboSheet.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceSheet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnChonFile.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.gridControlCauTruc);
            this.layoutControl1.Controls.Add(this.btnXuatFileCauTruc);
            this.layoutControl1.Controls.Add(this.cboLoaiDuLieu);
            this.layoutControl1.Controls.Add(this.btnImport);
            this.layoutControl1.Controls.Add(this.btnXemFile);
            this.layoutControl1.Controls.Add(this.cboSheet);
            this.layoutControl1.Controls.Add(this.btnChonFile);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(584, 361);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // gridControlCauTruc
            // 
            this.gridControlCauTruc.DataSource = this.bindingSourceCauTrucImport;
            this.gridControlCauTruc.Location = new System.Drawing.Point(12, 84);
            this.gridControlCauTruc.MainView = this.gridViewCauTruc;
            this.gridControlCauTruc.Name = "gridControlCauTruc";
            this.gridControlCauTruc.Size = new System.Drawing.Size(560, 239);
            this.gridControlCauTruc.TabIndex = 10;
            this.gridControlCauTruc.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewCauTruc});
            // 
            // gridViewCauTruc
            // 
            this.gridViewCauTruc.GridControl = this.gridControlCauTruc;
            this.gridViewCauTruc.Name = "gridViewCauTruc";
            // 
            // btnXuatFileCauTruc
            // 
            this.btnXuatFileCauTruc.Location = new System.Drawing.Point(473, 12);
            this.btnXuatFileCauTruc.Name = "btnXuatFileCauTruc";
            this.btnXuatFileCauTruc.Size = new System.Drawing.Size(99, 44);
            this.btnXuatFileCauTruc.StyleController = this.layoutControl1;
            this.btnXuatFileCauTruc.TabIndex = 9;
            this.btnXuatFileCauTruc.Text = "Xuất file cấu trúc";
            this.btnXuatFileCauTruc.Click += new System.EventHandler(this.btnXuatFileCauTruc_Click);
            // 
            // cboLoaiDuLieu
            // 
            this.cboLoaiDuLieu.Location = new System.Drawing.Point(90, 12);
            this.cboLoaiDuLieu.Name = "cboLoaiDuLieu";
            this.cboLoaiDuLieu.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboLoaiDuLieu.Properties.DataSource = this.bindingSourceFileName;
            this.cboLoaiDuLieu.Properties.View = this.gridView1;
            this.cboLoaiDuLieu.Size = new System.Drawing.Size(379, 20);
            this.cboLoaiDuLieu.StyleController = this.layoutControl1;
            this.cboLoaiDuLieu.TabIndex = 8;
            this.cboLoaiDuLieu.EditValueChanged += new System.EventHandler(this.cboCauTrucImport_EditValueChanged);
            // 
            // gridView1
            // 
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(473, 327);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(99, 22);
            this.btnImport.StyleController = this.layoutControl1;
            this.btnImport.TabIndex = 7;
            this.btnImport.Text = "Import";
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // btnXemFile
            // 
            this.btnXemFile.Location = new System.Drawing.Point(366, 327);
            this.btnXemFile.Name = "btnXemFile";
            this.btnXemFile.Size = new System.Drawing.Size(93, 22);
            this.btnXemFile.StyleController = this.layoutControl1;
            this.btnXemFile.TabIndex = 6;
            this.btnXemFile.Text = "Xem file";
            this.btnXemFile.Click += new System.EventHandler(this.btnXemFile_Click);
            // 
            // cboSheet
            // 
            this.cboSheet.Location = new System.Drawing.Point(91, 60);
            this.cboSheet.Name = "cboSheet";
            this.cboSheet.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboSheet.Properties.DataSource = this.bindingSourceSheet;
            this.cboSheet.Properties.View = this.gridLookUpEdit1View;
            this.cboSheet.Size = new System.Drawing.Size(481, 20);
            this.cboSheet.StyleController = this.layoutControl1;
            this.cboSheet.TabIndex = 5;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // btnChonFile
            // 
            this.btnChonFile.Location = new System.Drawing.Point(91, 36);
            this.btnChonFile.Name = "btnChonFile";
            this.btnChonFile.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.btnChonFile.Size = new System.Drawing.Size(378, 20);
            this.btnChonFile.StyleController = this.layoutControl1;
            this.btnChonFile.TabIndex = 4;
            this.btnChonFile.EditValueChanged += new System.EventHandler(this.btnChonFile_EditValueChanged);
            this.btnChonFile.Click += new System.EventHandler(this.btnChonFile_Click);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.layoutControlItem1,
            this.layoutControlItem7,
            this.emptySpaceItem4,
            this.layoutControlItem3,
            this.emptySpaceItem3,
            this.layoutControlItem6,
            this.layoutControlItem2});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(584, 361);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.btnImport;
            this.layoutControlItem4.CustomizationFormText = "layoutControlItem4";
            this.layoutControlItem4.Location = new System.Drawing.Point(461, 315);
            this.layoutControlItem4.MaxSize = new System.Drawing.Size(103, 26);
            this.layoutControlItem4.MinSize = new System.Drawing.Size(103, 26);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(103, 26);
            this.layoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.cboLoaiDuLieu;
            this.layoutControlItem5.CustomizationFormText = "Loại dữ liệu:";
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem5.MinSize = new System.Drawing.Size(132, 24);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(461, 24);
            this.layoutControlItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem5.Text = "Loại dữ liệu:     ";
            this.layoutControlItem5.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.layoutControlItem5.TextSize = new System.Drawing.Size(73, 13);
            this.layoutControlItem5.TextToControlDistance = 5;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.btnChonFile;
            this.layoutControlItem1.CustomizationFormText = "Chọn file Excel:";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem1.MinSize = new System.Drawing.Size(133, 24);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(461, 24);
            this.layoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem1.Text = "Chọn file Excel:";
            this.layoutControlItem1.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(74, 13);
            this.layoutControlItem1.TextToControlDistance = 5;
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.gridControlCauTruc;
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 72);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(564, 243);
            this.layoutControlItem7.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem7.TextVisible = false;
            // 
            // emptySpaceItem4
            // 
            this.emptySpaceItem4.AllowHotTrack = false;
            this.emptySpaceItem4.Location = new System.Drawing.Point(451, 315);
            this.emptySpaceItem4.MaxSize = new System.Drawing.Size(10, 26);
            this.emptySpaceItem4.MinSize = new System.Drawing.Size(10, 26);
            this.emptySpaceItem4.Name = "emptySpaceItem4";
            this.emptySpaceItem4.Size = new System.Drawing.Size(10, 26);
            this.emptySpaceItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.emptySpaceItem4.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.btnXemFile;
            this.layoutControlItem3.CustomizationFormText = "layoutControlItem3";
            this.layoutControlItem3.Location = new System.Drawing.Point(354, 315);
            this.layoutControlItem3.MaxSize = new System.Drawing.Size(97, 26);
            this.layoutControlItem3.MinSize = new System.Drawing.Size(97, 26);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(97, 26);
            this.layoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            this.layoutControlItem3.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            // 
            // emptySpaceItem3
            // 
            this.emptySpaceItem3.AllowHotTrack = false;
            this.emptySpaceItem3.CustomizationFormText = "emptySpaceItem3";
            this.emptySpaceItem3.Location = new System.Drawing.Point(0, 315);
            this.emptySpaceItem3.Name = "emptySpaceItem3";
            this.emptySpaceItem3.Size = new System.Drawing.Size(354, 26);
            this.emptySpaceItem3.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.btnXuatFileCauTruc;
            this.layoutControlItem6.CustomizationFormText = "layoutControlItem6";
            this.layoutControlItem6.Location = new System.Drawing.Point(461, 0);
            this.layoutControlItem6.MaxSize = new System.Drawing.Size(103, 48);
            this.layoutControlItem6.MinSize = new System.Drawing.Size(103, 48);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(103, 48);
            this.layoutControlItem6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.cboSheet;
            this.layoutControlItem2.CustomizationFormText = "Chọn sheet:";
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem2.MinSize = new System.Drawing.Size(133, 24);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(564, 24);
            this.layoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem2.Text = "Chọn sheet:     ";
            this.layoutControlItem2.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(74, 13);
            this.layoutControlItem2.TextToControlDistance = 5;
            this.layoutControlItem2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            // 
            // frmImportFileExcel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.ControlBox = false;
            this.Controls.Add(this.layoutControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmImportFileExcel";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmImportFileExcel";
            this.Load += new System.EventHandler(this.frmImportFileExcel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCauTruc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCauTrucImport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCauTruc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboLoaiDuLieu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceFileName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboSheet.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceSheet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnChonFile.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.ButtonEdit btnChonFile;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.GridLookUpEdit cboSheet;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private System.Windows.Forms.BindingSource bindingSourceSheet;
        private DevExpress.XtraEditors.SimpleButton btnXemFile;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraEditors.SimpleButton btnImport;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraEditors.SimpleButton btnXuatFileCauTruc;
        private DevExpress.XtraEditors.GridLookUpEdit cboLoaiDuLieu;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private System.Windows.Forms.BindingSource bindingSourceFileName;
        private DevExpress.XtraGrid.GridControl gridControlCauTruc;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewCauTruc;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem4;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private System.Windows.Forms.BindingSource bindingSourceCauTrucImport;
    }
}