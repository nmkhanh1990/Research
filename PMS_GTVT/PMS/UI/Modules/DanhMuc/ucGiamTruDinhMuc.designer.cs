namespace PMS.UI.Modules.DanhMuc
{
    partial class ucGiamTruDinhMuc
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucGiamTruDinhMuc));
            this.bindingSourceGiamTruDinhMuc = new System.Windows.Forms.BindingSource(this.components);
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.gridControlGiamTruDinhMuc = new DevExpress.XtraGrid.GridControl();
            this.gridViewGiamTruDinhMuc = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnChiTiet = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEditChiTiet = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnLamTuoi = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnLuu = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.imageCollection1 = new DevExpress.Utils.ImageCollection(this.components);
            this.repositoryItemGridLookUpEditDonVi = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.bindingSourceDonVi = new System.Windows.Forms.BindingSource(this.components);
            this.repositoryItemGridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.bindingSourceBacDaoTao = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceGiamTruDinhMuc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlGiamTruDinhMuc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewGiamTruDinhMuc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditChiTiet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEditDonVi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceDonVi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceBacDaoTao)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.gridControlGiamTruDinhMuc);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 31);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(685, 404);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // gridControlGiamTruDinhMuc
            // 
            this.gridControlGiamTruDinhMuc.DataSource = this.bindingSourceGiamTruDinhMuc;
            this.gridControlGiamTruDinhMuc.Location = new System.Drawing.Point(12, 12);
            this.gridControlGiamTruDinhMuc.MainView = this.gridViewGiamTruDinhMuc;
            this.gridControlGiamTruDinhMuc.MenuManager = this.barManager1;
            this.gridControlGiamTruDinhMuc.Name = "gridControlGiamTruDinhMuc";
            this.gridControlGiamTruDinhMuc.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemGridLookUpEditDonVi,
            this.repositoryItemButtonEditChiTiet});
            this.gridControlGiamTruDinhMuc.Size = new System.Drawing.Size(661, 380);
            this.gridControlGiamTruDinhMuc.TabIndex = 4;
            this.gridControlGiamTruDinhMuc.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewGiamTruDinhMuc});
            // 
            // gridViewGiamTruDinhMuc
            // 
            this.gridViewGiamTruDinhMuc.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnChiTiet});
            this.gridViewGiamTruDinhMuc.GridControl = this.gridControlGiamTruDinhMuc;
            this.gridViewGiamTruDinhMuc.Name = "gridViewGiamTruDinhMuc";
            this.gridViewGiamTruDinhMuc.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridViewGiamTruDinhMuc_CellValueChanged);
            this.gridViewGiamTruDinhMuc.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.gridViewGiamTruDinhMuc_ValidateRow);
            this.gridViewGiamTruDinhMuc.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gridViewGiamTruDinhMuc_KeyUp);
            this.gridViewGiamTruDinhMuc.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gridViewGiamTruDinhMuc_MouseDown);
            // 
            // gridColumnChiTiet
            // 
            this.gridColumnChiTiet.Caption = "Chi tiết";
            this.gridColumnChiTiet.ColumnEdit = this.repositoryItemButtonEditChiTiet;
            this.gridColumnChiTiet.Name = "gridColumnChiTiet";
            this.gridColumnChiTiet.Visible = true;
            this.gridColumnChiTiet.VisibleIndex = 0;
            // 
            // repositoryItemButtonEditChiTiet
            // 
            this.repositoryItemButtonEditChiTiet.AutoHeight = false;
            this.repositoryItemButtonEditChiTiet.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryItemButtonEditChiTiet.Name = "repositoryItemButtonEditChiTiet";
            this.repositoryItemButtonEditChiTiet.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.repositoryItemButtonEditChiTiet.Click += new System.EventHandler(this.repositoryItemButtonEditChiTiet_Click);
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
            new DevExpress.XtraBars.LinkPersistInfo(this.btnLamTuoi),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnXoa, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnLuu, true)});
            this.bar1.Text = "Tools";
            // 
            // btnLamTuoi
            // 
            this.btnLamTuoi.Caption = "Làm tươi";
            this.btnLamTuoi.Id = 0;
            this.btnLamTuoi.ImageIndex = 0;
            this.btnLamTuoi.Name = "btnLamTuoi";
            this.btnLamTuoi.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnLamTuoi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLamTuoi_ItemClick);
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "Xoá";
            this.btnXoa.Id = 1;
            this.btnXoa.ImageIndex = 4;
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoa_ItemClick);
            // 
            // btnLuu
            // 
            this.btnLuu.Caption = "Lưu";
            this.btnLuu.Id = 2;
            this.btnLuu.ImageIndex = 2;
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnLuu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLuu_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(685, 31);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 435);
            this.barDockControlBottom.Size = new System.Drawing.Size(685, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 31);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 404);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(685, 31);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 404);
            // 
            // imageCollection1
            // 
            this.imageCollection1.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection1.ImageStream")));
            this.imageCollection1.Images.SetKeyName(0, "reload.png");
            this.imageCollection1.Images.SetKeyName(1, "undo.png");
            this.imageCollection1.Images.SetKeyName(2, "save.png");
            this.imageCollection1.Images.SetKeyName(3, "printer.png");
            this.imageCollection1.Images.SetKeyName(4, "delete.png");
            // 
            // repositoryItemGridLookUpEditDonVi
            // 
            this.repositoryItemGridLookUpEditDonVi.AutoHeight = false;
            this.repositoryItemGridLookUpEditDonVi.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpEditDonVi.DataSource = this.bindingSourceDonVi;
            this.repositoryItemGridLookUpEditDonVi.Name = "repositoryItemGridLookUpEditDonVi";
            this.repositoryItemGridLookUpEditDonVi.View = this.repositoryItemGridLookUpEdit1View;
            // 
            // repositoryItemGridLookUpEdit1View
            // 
            this.repositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit1View.Name = "repositoryItemGridLookUpEdit1View";
            this.repositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(685, 404);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gridControlGiamTruDinhMuc;
            this.layoutControlItem1.CustomizationFormText = "layoutControlItem1";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(665, 384);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // ucGiamTruDinhMuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "ucGiamTruDinhMuc";
            this.Size = new System.Drawing.Size(685, 435);
            this.Load += new System.EventHandler(this.ucGiamTruDinhMuc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceGiamTruDinhMuc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlGiamTruDinhMuc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewGiamTruDinhMuc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditChiTiet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEditDonVi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceDonVi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceBacDaoTao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSourceGiamTruDinhMuc;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraGrid.GridControl gridControlGiamTruDinhMuc;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewGiamTruDinhMuc;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem btnLamTuoi;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnLuu;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.Utils.ImageCollection imageCollection1;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEditDonVi;
        private System.Windows.Forms.BindingSource bindingSourceDonVi;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit1View;
        private System.Windows.Forms.BindingSource bindingSourceBacDaoTao;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEditChiTiet;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnChiTiet;
    }
}
