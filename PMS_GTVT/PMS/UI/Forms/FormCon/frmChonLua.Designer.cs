namespace PMS.UI.Forms.FormCon
{
    partial class frmChonLua
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
            this.btnXacNhan = new DevExpress.XtraEditors.SimpleButton();
            this.checkedListBoxChonNhieu = new DevExpress.XtraEditors.CheckedListBoxControl();
            this.bindingSourceChonNhieu = new System.Windows.Forms.BindingSource(this.components);
            this.txtDaChon = new DevExpress.XtraEditors.TextEdit();
            this.cboChonMot = new DevExpress.XtraEditors.GridLookUpEdit();
            this.bindingSourceChonMot = new System.Windows.Forms.BindingSource(this.components);
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItemChonMot = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItemDaChon = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.btnHuy = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkedListBoxChonNhieu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceChonNhieu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDaChon.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboChonMot.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceChonMot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemChonMot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemDaChon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.btnHuy);
            this.layoutControl1.Controls.Add(this.btnXacNhan);
            this.layoutControl1.Controls.Add(this.checkedListBoxChonNhieu);
            this.layoutControl1.Controls.Add(this.txtDaChon);
            this.layoutControl1.Controls.Add(this.cboChonMot);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(484, 461);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.Location = new System.Drawing.Point(244, 427);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(228, 22);
            this.btnXacNhan.StyleController = this.layoutControl1;
            this.btnXacNhan.TabIndex = 7;
            this.btnXacNhan.Text = "Xác nhận";
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // checkedListBoxChonNhieu
            // 
            this.checkedListBoxChonNhieu.DataSource = this.bindingSourceChonNhieu;
            this.checkedListBoxChonNhieu.Location = new System.Drawing.Point(12, 60);
            this.checkedListBoxChonNhieu.MultiColumn = true;
            this.checkedListBoxChonNhieu.Name = "checkedListBoxChonNhieu";
            this.checkedListBoxChonNhieu.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.checkedListBoxChonNhieu.Size = new System.Drawing.Size(460, 363);
            this.checkedListBoxChonNhieu.SortOrder = System.Windows.Forms.SortOrder.Ascending;
            this.checkedListBoxChonNhieu.StyleController = this.layoutControl1;
            this.checkedListBoxChonNhieu.TabIndex = 6;
            // 
            // txtDaChon
            // 
            this.txtDaChon.Location = new System.Drawing.Point(65, 36);
            this.txtDaChon.Name = "txtDaChon";
            this.txtDaChon.Size = new System.Drawing.Size(407, 20);
            this.txtDaChon.StyleController = this.layoutControl1;
            this.txtDaChon.TabIndex = 5;
            // 
            // cboChonMot
            // 
            this.cboChonMot.Location = new System.Drawing.Point(65, 12);
            this.cboChonMot.Name = "cboChonMot";
            this.cboChonMot.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboChonMot.Properties.DataSource = this.bindingSourceChonMot;
            this.cboChonMot.Properties.View = this.gridLookUpEdit1View;
            this.cboChonMot.Size = new System.Drawing.Size(407, 20);
            this.cboChonMot.StyleController = this.layoutControl1;
            this.cboChonMot.TabIndex = 4;
            this.cboChonMot.EditValueChanged += new System.EventHandler(this.cboChonMot_EditValueChanged);
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
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItemChonMot,
            this.layoutControlItemDaChon,
            this.layoutControlItem4,
            this.layoutControlItem1,
            this.layoutControlItem3});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(484, 461);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItemChonMot
            // 
            this.layoutControlItemChonMot.Control = this.cboChonMot;
            this.layoutControlItemChonMot.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItemChonMot.Name = "layoutControlItemChonMot";
            this.layoutControlItemChonMot.Size = new System.Drawing.Size(464, 24);
            this.layoutControlItemChonMot.Text = "Chọn một:";
            this.layoutControlItemChonMot.TextSize = new System.Drawing.Size(50, 13);
            // 
            // layoutControlItemDaChon
            // 
            this.layoutControlItemDaChon.Control = this.txtDaChon;
            this.layoutControlItemDaChon.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItemDaChon.Name = "layoutControlItemDaChon";
            this.layoutControlItemDaChon.Size = new System.Drawing.Size(464, 24);
            this.layoutControlItemDaChon.Text = "Đã chọn:";
            this.layoutControlItemDaChon.TextSize = new System.Drawing.Size(50, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.checkedListBoxChonNhieu;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(464, 367);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.btnXacNhan;
            this.layoutControlItem1.Location = new System.Drawing.Point(232, 415);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(232, 26);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 91);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(214, 25);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(50, 20);
            // 
            // btnHuy
            // 
            this.btnHuy.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnHuy.Location = new System.Drawing.Point(12, 427);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(228, 22);
            this.btnHuy.StyleController = this.layoutControl1;
            this.btnHuy.TabIndex = 8;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.btnHuy;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 415);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(232, 26);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // frmChonLua
            // 
            this.AcceptButton = this.btnXacNhan;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelButton = this.btnHuy;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.ControlBox = false;
            this.Controls.Add(this.layoutControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmChonLua";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Tùy chọn";
            this.Load += new System.EventHandler(this.frmChonLua_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.checkedListBoxChonNhieu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceChonNhieu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDaChon.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboChonMot.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceChonMot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemChonMot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemDaChon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.CheckedListBoxControl checkedListBoxChonNhieu;
        private DevExpress.XtraEditors.TextEdit txtDaChon;
        private DevExpress.XtraEditors.GridLookUpEdit cboChonMot;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItemChonMot;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItemDaChon;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private System.Windows.Forms.BindingSource bindingSourceChonMot;
        private System.Windows.Forms.BindingSource bindingSourceChonNhieu;
        private DevExpress.XtraEditors.SimpleButton btnXacNhan;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.SimpleButton btnHuy;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
    }
}