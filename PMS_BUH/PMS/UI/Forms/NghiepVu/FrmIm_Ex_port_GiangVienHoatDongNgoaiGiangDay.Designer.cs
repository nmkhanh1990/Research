﻿namespace PMS.UI.Forms.NghiepVu
{
    partial class FrmIm_Ex_port_GiangVienHoatDongNgoaiGiangDay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmIm_Ex_port_GiangVienHoatDongNgoaiGiangDay));
            this.img_ImExGVHDNGD = new DevExpress.Utils.ImageCollection(this.components);
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.btn_Import = new DevExpress.XtraEditors.SimpleButton();
            this.btn_ChonFile = new DevExpress.XtraEditors.ButtonEdit();
            this.grc_ImExGVHDNGD = new DevExpress.XtraGrid.GridControl();
            this.bds_ImExGVHDNGD = new System.Windows.Forms.BindingSource(this.components);
            this.grv_IMEXGVHDNGD = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.repositoryItemGridLookUpEditGiangVien = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.repositoryItemGridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.repositoryItemGridLookUpEditHoatDong = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.img_ImExGVHDNGD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_ChonFile.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grc_ImExGVHDNGD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_ImExGVHDNGD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grv_IMEXGVHDNGD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEditGiangVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEditHoatDong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            this.SuspendLayout();
            // 
            // img_ImExGVHDNGD
            // 
            this.img_ImExGVHDNGD.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("img_ImExGVHDNGD.ImageStream")));
            this.img_ImExGVHDNGD.Images.SetKeyName(0, "reload.png");
            this.img_ImExGVHDNGD.Images.SetKeyName(1, "undo.png");
            this.img_ImExGVHDNGD.Images.SetKeyName(2, "save.png");
            this.img_ImExGVHDNGD.Images.SetKeyName(3, "printer.png");
            this.img_ImExGVHDNGD.Images.SetKeyName(4, "delete.png");
            this.img_ImExGVHDNGD.Images.SetKeyName(5, "excel.png");
            this.img_ImExGVHDNGD.Images.SetKeyName(6, "if_document_import_64094.png");
            this.img_ImExGVHDNGD.Images.SetKeyName(7, "if_export_excel_64174.png");
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.btn_Import);
            this.layoutControl1.Controls.Add(this.btn_ChonFile);
            this.layoutControl1.Controls.Add(this.grc_ImExGVHDNGD);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(779, 440);
            this.layoutControl1.TabIndex = 4;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // btn_Import
            // 
            this.btn_Import.Location = new System.Drawing.Point(664, 406);
            this.btn_Import.Name = "btn_Import";
            this.btn_Import.Size = new System.Drawing.Size(103, 22);
            this.btn_Import.StyleController = this.layoutControl1;
            this.btn_Import.TabIndex = 10;
            this.btn_Import.Text = "Import";
            this.btn_Import.Click += new System.EventHandler(this.btn_Import_Click);
            // 
            // btn_ChonFile
            // 
            this.btn_ChonFile.Location = new System.Drawing.Point(125, 33);
            this.btn_ChonFile.Name = "btn_ChonFile";
            this.btn_ChonFile.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.btn_ChonFile.Size = new System.Drawing.Size(642, 20);
            this.btn_ChonFile.StyleController = this.layoutControl1;
            this.btn_ChonFile.TabIndex = 9;
            this.btn_ChonFile.Click += new System.EventHandler(this.btn_ChonFile_Click);
            // 
            // grc_ImExGVHDNGD
            // 
            this.grc_ImExGVHDNGD.DataSource = this.bds_ImExGVHDNGD;
            this.grc_ImExGVHDNGD.Location = new System.Drawing.Point(12, 57);
            this.grc_ImExGVHDNGD.MainView = this.grv_IMEXGVHDNGD;
            this.grc_ImExGVHDNGD.Name = "grc_ImExGVHDNGD";
            this.grc_ImExGVHDNGD.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemGridLookUpEditGiangVien,
            this.repositoryItemGridLookUpEditHoatDong});
            this.grc_ImExGVHDNGD.Size = new System.Drawing.Size(755, 345);
            this.grc_ImExGVHDNGD.TabIndex = 8;
            this.grc_ImExGVHDNGD.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grv_IMEXGVHDNGD});
            // 
            // grv_IMEXGVHDNGD
            // 
            this.grv_IMEXGVHDNGD.GridControl = this.grc_ImExGVHDNGD;
            this.grv_IMEXGVHDNGD.Name = "grv_IMEXGVHDNGD";
            // 
            // repositoryItemGridLookUpEditGiangVien
            // 
            this.repositoryItemGridLookUpEditGiangVien.AutoHeight = false;
            this.repositoryItemGridLookUpEditGiangVien.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpEditGiangVien.Name = "repositoryItemGridLookUpEditGiangVien";
            this.repositoryItemGridLookUpEditGiangVien.View = this.repositoryItemGridLookUpEdit1View;
            // 
            // repositoryItemGridLookUpEdit1View
            // 
            this.repositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit1View.Name = "repositoryItemGridLookUpEdit1View";
            this.repositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // repositoryItemGridLookUpEditHoatDong
            // 
            this.repositoryItemGridLookUpEditHoatDong.AutoHeight = false;
            this.repositoryItemGridLookUpEditHoatDong.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpEditHoatDong.Name = "repositoryItemGridLookUpEditHoatDong";
            this.repositoryItemGridLookUpEditHoatDong.View = this.gridView2;
            // 
            // gridView2
            // 
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.emptySpaceItem1,
            this.layoutControlItem2,
            this.emptySpaceItem2,
            this.layoutControlItem3});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(779, 440);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.grc_ImExGVHDNGD;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 45);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(759, 349);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 0);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(759, 21);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.btn_ChonFile;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 21);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(759, 24);
            this.layoutControlItem2.Text = "Chọn file excel import :";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(110, 13);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 394);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(652, 26);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.btn_Import;
            this.layoutControlItem3.Location = new System.Drawing.Point(652, 394);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(107, 26);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // FrmIm_Ex_port_GiangVienHoatDongNgoaiGiangDay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 440);
            this.Controls.Add(this.layoutControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmIm_Ex_port_GiangVienHoatDongNgoaiGiangDay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NX-Giảng viên hoạt động ngoài giảng dạy";
            this.Load += new System.EventHandler(this.FrmIm_Ex_port_GiangVienHoatDongNgoaiGiangDay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.img_ImExGVHDNGD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_ChonFile.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grc_ImExGVHDNGD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_ImExGVHDNGD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grv_IMEXGVHDNGD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEditGiangVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEditHoatDong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraGrid.GridControl grc_ImExGVHDNGD;
        private DevExpress.XtraGrid.Views.Grid.GridView grv_IMEXGVHDNGD;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEditGiangVien;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit1View;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEditHoatDong;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.Utils.ImageCollection img_ImExGVHDNGD;
        private System.Windows.Forms.BindingSource bds_ImExGVHDNGD;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraEditors.ButtonEdit btn_ChonFile;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraEditors.SimpleButton btn_Import;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
    }
}