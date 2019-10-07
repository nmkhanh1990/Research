namespace PMS.UI.Forms.HeThong
{
    partial class frmPhanQuyenTaiKhoanTheoKhoa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPhanQuyenTaiKhoanTheoKhoa));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.gridControlPQTKTheoKhoa = new DevExpress.XtraGrid.GridControl();
            this.bindingSourcePhanQuyenTheoKhoa = new System.Windows.Forms.BindingSource(this.components);
            this.gridViewPhanQuyenTaiKhoanTheoKhoa = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.repositoryItemcbo_editKhoa = new DevExpress.XtraEditors.Repository.RepositoryItemCheckedComboBoxEdit();
            this.repositoryItemchkcbo_ChucNang = new DevExpress.XtraEditors.Repository.RepositoryItemCheckedComboBoxEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnLamTuoi = new DevExpress.XtraBars.BarButtonItem();
            this.btnLuu = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.imageCollection = new DevExpress.Utils.ImageCollection(this.components);
            this.bindingSourceDanhSachKhoa = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSourceIdChucNang = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlPQTKTheoKhoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourcePhanQuyenTheoKhoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPhanQuyenTaiKhoanTheoKhoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemcbo_editKhoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemchkcbo_ChucNang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceDanhSachKhoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceIdChucNang)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.gridControlPQTKTheoKhoa);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 31);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(775, 361);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // gridControlPQTKTheoKhoa
            // 
            this.gridControlPQTKTheoKhoa.DataSource = this.bindingSourcePhanQuyenTheoKhoa;
            this.gridControlPQTKTheoKhoa.Location = new System.Drawing.Point(12, 12);
            this.gridControlPQTKTheoKhoa.MainView = this.gridViewPhanQuyenTaiKhoanTheoKhoa;
            this.gridControlPQTKTheoKhoa.Name = "gridControlPQTKTheoKhoa";
            this.gridControlPQTKTheoKhoa.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemcbo_editKhoa,
            this.repositoryItemchkcbo_ChucNang});
            this.gridControlPQTKTheoKhoa.Size = new System.Drawing.Size(751, 337);
            this.gridControlPQTKTheoKhoa.TabIndex = 4;
            this.gridControlPQTKTheoKhoa.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewPhanQuyenTaiKhoanTheoKhoa});
            // 
            // gridViewPhanQuyenTaiKhoanTheoKhoa
            // 
            this.gridViewPhanQuyenTaiKhoanTheoKhoa.GridControl = this.gridControlPQTKTheoKhoa;
            this.gridViewPhanQuyenTaiKhoanTheoKhoa.Name = "gridViewPhanQuyenTaiKhoanTheoKhoa";
            this.gridViewPhanQuyenTaiKhoanTheoKhoa.ShowingEditor += new System.ComponentModel.CancelEventHandler(this.gridViewPhanQuyenTaiKhoanTheoKhoa_ShowingEditor);
            // 
            // repositoryItemcbo_editKhoa
            // 
            this.repositoryItemcbo_editKhoa.AutoHeight = false;
            this.repositoryItemcbo_editKhoa.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemcbo_editKhoa.Name = "repositoryItemcbo_editKhoa";
            // 
            // repositoryItemchkcbo_ChucNang
            // 
            this.repositoryItemchkcbo_ChucNang.AutoHeight = false;
            this.repositoryItemchkcbo_ChucNang.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemchkcbo_ChucNang.Name = "repositoryItemchkcbo_ChucNang";
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(775, 361);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gridControlPQTKTheoKhoa;
            this.layoutControlItem1.CustomizationFormText = "layoutControlItem1";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(755, 341);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
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
            this.barManager1.Images = this.imageCollection;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnLamTuoi,
            this.btnLuu});
            this.barManager1.MaxItemId = 3;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnLamTuoi, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnLuu, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.Text = "Tools";
            // 
            // btnLamTuoi
            // 
            this.btnLamTuoi.Caption = "Làm tươi";
            this.btnLamTuoi.Id = 0;
            this.btnLamTuoi.ImageIndex = 2;
            this.btnLamTuoi.Name = "btnLamTuoi";
            this.btnLamTuoi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLamTuoi_ItemClick);
            // 
            // btnLuu
            // 
            this.btnLuu.Caption = "Lưu";
            this.btnLuu.Id = 2;
            this.btnLuu.ImageIndex = 0;
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLuu_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(775, 31);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 392);
            this.barDockControlBottom.Size = new System.Drawing.Size(775, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 31);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 361);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(775, 31);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 361);
            // 
            // imageCollection
            // 
            this.imageCollection.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection.ImageStream")));
            this.imageCollection.Images.SetKeyName(0, "save.png");
            this.imageCollection.Images.SetKeyName(1, "delete.png");
            this.imageCollection.Images.SetKeyName(2, "reload.png");
            this.imageCollection.Images.SetKeyName(3, "undo.png");
            this.imageCollection.Images.SetKeyName(4, "printer.png");
            this.imageCollection.Images.SetKeyName(5, "add.png");
            // 
            // frmPhanQuyenTaiKhoanTheoKhoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 392);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPhanQuyenTaiKhoanTheoKhoa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Phân quyền chức năng theo khoa";
            this.Load += new System.EventHandler(this.frmPhanQuyenTaiKhoanTheoKhoa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlPQTKTheoKhoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourcePhanQuyenTheoKhoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPhanQuyenTaiKhoanTheoKhoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemcbo_editKhoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemchkcbo_ChucNang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceDanhSachKhoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceIdChucNang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraGrid.GridControl gridControlPQTKTheoKhoa;
        private System.Windows.Forms.BindingSource bindingSourcePhanQuyenTheoKhoa;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewPhanQuyenTaiKhoanTheoKhoa;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnLamTuoi;
        private DevExpress.XtraBars.BarButtonItem btnLuu;
        private DevExpress.Utils.ImageCollection imageCollection;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckedComboBoxEdit repositoryItemcbo_editKhoa;
        private System.Windows.Forms.BindingSource bindingSourceDanhSachKhoa;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckedComboBoxEdit repositoryItemchkcbo_ChucNang;
        private System.Windows.Forms.BindingSource bindingSourceIdChucNang;
    }
}