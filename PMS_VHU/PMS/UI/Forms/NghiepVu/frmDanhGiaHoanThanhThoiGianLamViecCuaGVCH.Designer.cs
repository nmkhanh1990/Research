﻿namespace PMS.UI.Forms.NghiepVu
{
    partial class frmDanhGiaHoanThanhThoiGianLamViecCuaGVCH
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDanhGiaHoanThanhThoiGianLamViecCuaGVCH));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.gridControlDanhGia = new DevExpress.XtraGrid.GridControl();
            this.bindingSourceDanhGia = new System.Windows.Forms.BindingSource(this.components);
            this.gridViewDanhGia = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnLamTuoi = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnLuu = new DevExpress.XtraBars.BarButtonItem();
            this.btnExcel = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.imageCollection1 = new DevExpress.Utils.ImageCollection(this.components);
            this.repositoryItemGridLookUpEditNoiDungDanhGia = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.bindingSourceNoiDungDanhGia = new System.Windows.Forms.BindingSource(this.components);
            this.repositoryItemGridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.cboKhoaDonVi = new DevExpress.XtraEditors.GridLookUpEdit();
            this.bindingSourceKhoaDonVi = new System.Windows.Forms.BindingSource(this.components);
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.cboNamHoc = new DevExpress.XtraEditors.GridLookUpEdit();
            this.bindingSourceNamHoc = new System.Windows.Forms.BindingSource(this.components);
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDanhGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceDanhGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDanhGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEditNoiDungDanhGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceNoiDungDanhGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboKhoaDonVi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceKhoaDonVi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboNamHoc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceNamHoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.gridControlDanhGia);
            this.layoutControl1.Controls.Add(this.cboKhoaDonVi);
            this.layoutControl1.Controls.Add(this.cboNamHoc);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 26);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(626, 271);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // gridControlDanhGia
            // 
            this.gridControlDanhGia.DataSource = this.bindingSourceDanhGia;
            this.gridControlDanhGia.Location = new System.Drawing.Point(12, 36);
            this.gridControlDanhGia.MainView = this.gridViewDanhGia;
            this.gridControlDanhGia.MenuManager = this.barManager1;
            this.gridControlDanhGia.Name = "gridControlDanhGia";
            this.gridControlDanhGia.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemGridLookUpEditNoiDungDanhGia});
            this.gridControlDanhGia.Size = new System.Drawing.Size(602, 223);
            this.gridControlDanhGia.TabIndex = 7;
            this.gridControlDanhGia.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewDanhGia});
            // 
            // gridViewDanhGia
            // 
            this.gridViewDanhGia.GridControl = this.gridControlDanhGia;
            this.gridViewDanhGia.Name = "gridViewDanhGia";
            this.gridViewDanhGia.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridViewDanhGia_CellValueChanged);
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Images = this.imageCollection1;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnLamTuoi,
            this.btnXoa,
            this.btnLuu,
            this.btnExcel,
            this.barButtonItem1});
            this.barManager1.MaxItemId = 6;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnLamTuoi, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXoa, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnLuu, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnExcel, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem1, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.Text = "Tools";
            // 
            // btnLamTuoi
            // 
            this.btnLamTuoi.Caption = "Làm tươi";
            this.btnLamTuoi.Id = 0;
            this.btnLamTuoi.ImageIndex = 0;
            this.btnLamTuoi.Name = "btnLamTuoi";
            this.btnLamTuoi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLamTuoi_ItemClick);
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "Xoá";
            this.btnXoa.Id = 1;
            this.btnXoa.ImageIndex = 2;
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.btnXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoa_ItemClick);
            // 
            // btnLuu
            // 
            this.btnLuu.Caption = "Lưu";
            this.btnLuu.Id = 2;
            this.btnLuu.ImageIndex = 3;
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLuu_ItemClick);
            // 
            // btnExcel
            // 
            this.btnExcel.Caption = "Xuất Excel";
            this.btnExcel.Id = 3;
            this.btnExcel.ImageIndex = 4;
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnExcel_ItemClick);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Đồng bộ";
            this.barButtonItem1.Id = 5;
            this.barButtonItem1.ImageIndex = 7;
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(626, 26);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 297);
            this.barDockControlBottom.Size = new System.Drawing.Size(626, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 26);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 271);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(626, 26);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 271);
            // 
            // imageCollection1
            // 
            this.imageCollection1.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection1.ImageStream")));
            this.imageCollection1.Images.SetKeyName(0, "reload.png");
            this.imageCollection1.Images.SetKeyName(1, "add.png");
            this.imageCollection1.Images.SetKeyName(2, "delete.png");
            this.imageCollection1.Images.SetKeyName(3, "save.png");
            this.imageCollection1.Images.SetKeyName(4, "Excel16.png");
            this.imageCollection1.Images.SetKeyName(5, "4f140fcc-d9f8-41de-b189-468b5fd37f42.png");
            this.imageCollection1.Images.SetKeyName(6, "print_icon.gif");
            this.imageCollection1.Images.SetKeyName(7, "import-export-icon.png");
            // 
            // repositoryItemGridLookUpEditNoiDungDanhGia
            // 
            this.repositoryItemGridLookUpEditNoiDungDanhGia.AutoHeight = false;
            this.repositoryItemGridLookUpEditNoiDungDanhGia.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpEditNoiDungDanhGia.DataSource = this.bindingSourceNoiDungDanhGia;
            this.repositoryItemGridLookUpEditNoiDungDanhGia.Name = "repositoryItemGridLookUpEditNoiDungDanhGia";
            this.repositoryItemGridLookUpEditNoiDungDanhGia.View = this.repositoryItemGridLookUpEdit1View;
            // 
            // repositoryItemGridLookUpEdit1View
            // 
            this.repositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit1View.Name = "repositoryItemGridLookUpEdit1View";
            this.repositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // cboKhoaDonVi
            // 
            this.cboKhoaDonVi.Location = new System.Drawing.Point(188, 12);
            this.cboKhoaDonVi.MenuManager = this.barManager1;
            this.cboKhoaDonVi.Name = "cboKhoaDonVi";
            this.cboKhoaDonVi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboKhoaDonVi.Properties.DataSource = this.bindingSourceKhoaDonVi;
            this.cboKhoaDonVi.Properties.View = this.gridView2;
            this.cboKhoaDonVi.Size = new System.Drawing.Size(90, 20);
            this.cboKhoaDonVi.StyleController = this.layoutControl1;
            this.cboKhoaDonVi.TabIndex = 6;
            this.cboKhoaDonVi.EditValueChanged += new System.EventHandler(this.cboKhoaDonVi_EditValueChanged);
            // 
            // gridView2
            // 
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // cboNamHoc
            // 
            this.cboNamHoc.Location = new System.Drawing.Point(62, 12);
            this.cboNamHoc.MenuManager = this.barManager1;
            this.cboNamHoc.Name = "cboNamHoc";
            this.cboNamHoc.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboNamHoc.Properties.DataSource = this.bindingSourceNamHoc;
            this.cboNamHoc.Properties.View = this.gridLookUpEdit1View;
            this.cboNamHoc.Size = new System.Drawing.Size(50, 20);
            this.cboNamHoc.StyleController = this.layoutControl1;
            this.cboNamHoc.TabIndex = 4;
            this.cboNamHoc.EditValueChanged += new System.EventHandler(this.cboNamHoc_EditValueChanged);
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem3,
            this.layoutControlItem2,
            this.emptySpaceItem1});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(626, 271);
            this.layoutControlGroup1.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroup1.Text = "layoutControlGroup1";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.cboNamHoc;
            this.layoutControlItem1.CustomizationFormText = "Năm học:";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(104, 24);
            this.layoutControlItem1.Text = "Năm học:";
            this.layoutControlItem1.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(45, 13);
            this.layoutControlItem1.TextToControlDistance = 5;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.cboKhoaDonVi;
            this.layoutControlItem3.CustomizationFormText = "Khoa - đơn vị:";
            this.layoutControlItem3.Location = new System.Drawing.Point(104, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(166, 24);
            this.layoutControlItem3.Text = "Khoa - đơn vị:";
            this.layoutControlItem3.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.layoutControlItem3.TextSize = new System.Drawing.Size(67, 13);
            this.layoutControlItem3.TextToControlDistance = 5;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.gridControlDanhGia;
            this.layoutControlItem2.CustomizationFormText = "layoutControlItem2";
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(606, 227);
            this.layoutControlItem2.Text = "layoutControlItem2";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextToControlDistance = 0;
            this.layoutControlItem2.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1";
            this.emptySpaceItem1.Location = new System.Drawing.Point(270, 0);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(336, 24);
            this.emptySpaceItem1.Text = "emptySpaceItem1";
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // frmDanhGiaHoanThanhThoiGianLamViecCuaGVCH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 297);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmDanhGiaHoanThanhThoiGianLamViecCuaGVCH";
            this.Text = "frmDanhGiaHoanThanhThoiGianLamViecCuaGVCH";
            this.Load += new System.EventHandler(this.frmDanhGiaHoanThanhThoiGianLamViecCuaGVCH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDanhGia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceDanhGia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDanhGia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEditNoiDungDanhGia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceNoiDungDanhGia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboKhoaDonVi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceKhoaDonVi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboNamHoc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceNamHoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraGrid.GridControl gridControlDanhGia;
        private System.Windows.Forms.BindingSource bindingSourceDanhGia;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewDanhGia;
        private DevExpress.XtraBars.BarButtonItem btnLamTuoi;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnLuu;
        private DevExpress.XtraBars.BarButtonItem btnExcel;
        private DevExpress.Utils.ImageCollection imageCollection1;
        private DevExpress.XtraEditors.GridLookUpEdit cboKhoaDonVi;
        private System.Windows.Forms.BindingSource bindingSourceKhoaDonVi;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.GridLookUpEdit cboNamHoc;
        private System.Windows.Forms.BindingSource bindingSourceNamHoc;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEditNoiDungDanhGia;
        private System.Windows.Forms.BindingSource bindingSourceNoiDungDanhGia;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit1View;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
    }
}