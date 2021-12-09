
namespace IHYAOtomasyon.Views.ProductForms
{
    partial class AddStockForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddStockForm));
            this.tileNavPane1 = new DevExpress.XtraBars.Navigation.TileNavPane();
            this.navButton1 = new DevExpress.XtraBars.Navigation.NavButton();
            this.navButton3 = new DevExpress.XtraBars.Navigation.NavButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.textProductFeatures = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.buttonSelectReferance = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.textProductID = new DevExpress.XtraEditors.TextEdit();
            this.textProductName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.textCount = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.textWhoPurchase = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.tileNavPane1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textProductFeatures.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textProductID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textProductName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textCount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textWhoPurchase.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // tileNavPane1
            // 
            this.tileNavPane1.Buttons.Add(this.navButton1);
            this.tileNavPane1.Buttons.Add(this.navButton3);
            // 
            // tileNavCategory1
            // 
            this.tileNavPane1.DefaultCategory.Name = "tileNavCategory1";
            // 
            // 
            // 
            this.tileNavPane1.DefaultCategory.Tile.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            this.tileNavPane1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tileNavPane1.Location = new System.Drawing.Point(0, 0);
            this.tileNavPane1.Name = "tileNavPane1";
            this.tileNavPane1.Size = new System.Drawing.Size(365, 40);
            this.tileNavPane1.TabIndex = 1;
            // 
            // navButton1
            // 
            this.navButton1.Alignment = DevExpress.XtraBars.Navigation.NavButtonAlignment.Left;
            this.navButton1.Caption = "Ekle";
            this.navButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("navButton1.ImageOptions.Image")));
            this.navButton1.Name = "navButton1";
            this.navButton1.ElementClick += new DevExpress.XtraBars.Navigation.NavElementClickEventHandler(this.navButton1_ElementClick);
            // 
            // navButton3
            // 
            this.navButton3.Alignment = DevExpress.XtraBars.Navigation.NavButtonAlignment.Left;
            this.navButton3.Caption = "İptal";
            this.navButton3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("navButton3.ImageOptions.Image")));
            this.navButton3.Name = "navButton3";
            this.navButton3.ElementClick += new DevExpress.XtraBars.Navigation.NavElementClickEventHandler(this.navButton3_ElementClick);
            // 
            // groupControl1
            // 
            this.groupControl1.Appearance.BorderColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary;
            this.groupControl1.Appearance.Options.UseBorderColor = true;
            this.groupControl1.Controls.Add(this.textProductFeatures);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.buttonSelectReferance);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.textProductID);
            this.groupControl1.Controls.Add(this.textProductName);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(12, 46);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(341, 172);
            this.groupControl1.TabIndex = 4;
            this.groupControl1.Text = "Ürün";
            // 
            // textProductFeatures
            // 
            this.textProductFeatures.Location = new System.Drawing.Point(5, 141);
            this.textProductFeatures.Name = "textProductFeatures";
            this.textProductFeatures.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.textProductFeatures.Properties.Appearance.Options.UseFont = true;
            this.textProductFeatures.Properties.ReadOnly = true;
            this.textProductFeatures.Size = new System.Drawing.Size(331, 26);
            this.textProductFeatures.TabIndex = 56;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(5, 119);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(64, 16);
            this.labelControl2.TabIndex = 55;
            this.labelControl2.Text = "Özellikleri :";
            // 
            // buttonSelectReferance
            // 
            this.buttonSelectReferance.Location = new System.Drawing.Point(162, 29);
            this.buttonSelectReferance.Name = "buttonSelectReferance";
            this.buttonSelectReferance.Size = new System.Drawing.Size(30, 23);
            this.buttonSelectReferance.TabIndex = 1;
            this.buttonSelectReferance.Text = "Seç";
            this.buttonSelectReferance.Click += new System.EventHandler(this.buttonSelectReferance_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(5, 33);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(25, 16);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "ID : ";
            // 
            // textProductID
            // 
            this.textProductID.Location = new System.Drawing.Point(46, 27);
            this.textProductID.Name = "textProductID";
            this.textProductID.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.textProductID.Properties.Appearance.Options.UseFont = true;
            this.textProductID.Properties.ReadOnly = true;
            this.textProductID.Size = new System.Drawing.Size(110, 26);
            this.textProductID.TabIndex = 4;
            this.textProductID.EditValueChanged += new System.EventHandler(this.textProductID_EditValueChanged);
            // 
            // textProductName
            // 
            this.textProductName.Location = new System.Drawing.Point(5, 86);
            this.textProductName.Name = "textProductName";
            this.textProductName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.textProductName.Properties.Appearance.Options.UseFont = true;
            this.textProductName.Properties.ReadOnly = true;
            this.textProductName.Size = new System.Drawing.Size(331, 26);
            this.textProductName.TabIndex = 54;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(5, 64);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(27, 16);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Adı :";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(17, 231);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(44, 16);
            this.labelControl4.TabIndex = 57;
            this.labelControl4.Text = "Miktar :";
            // 
            // textCount
            // 
            this.textCount.EditValue = "1";
            this.textCount.Location = new System.Drawing.Point(17, 253);
            this.textCount.Name = "textCount";
            this.textCount.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.textCount.Properties.Appearance.Options.UseFont = true;
            this.textCount.Properties.BeepOnError = false;
            this.textCount.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.textCount.Properties.MaskSettings.Set("mask", "d");
            this.textCount.Properties.MaskSettings.Set("valueAfterDelete", DevExpress.Data.Mask.NumericMaskManager.ValueAfterDelete.ZeroThenNull);
            this.textCount.Properties.UseMaskAsDisplayFormat = true;
            this.textCount.Size = new System.Drawing.Size(151, 26);
            this.textCount.TabIndex = 58;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(17, 285);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(71, 16);
            this.labelControl5.TabIndex = 59;
            this.labelControl5.Text = "Alınan Kişi : ";
            // 
            // textWhoPurchase
            // 
            this.textWhoPurchase.Location = new System.Drawing.Point(17, 307);
            this.textWhoPurchase.Name = "textWhoPurchase";
            this.textWhoPurchase.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.textWhoPurchase.Properties.Appearance.Options.UseFont = true;
            this.textWhoPurchase.Size = new System.Drawing.Size(331, 26);
            this.textWhoPurchase.TabIndex = 60;
            // 
            // AddStockForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 345);
            this.Controls.Add(this.textWhoPurchase);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.textCount);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.tileNavPane1);
            this.MaximizeBox = false;
            this.Name = "AddStockForm";
            this.Text = "Stok Ekle";
            ((System.ComponentModel.ISupportInitialize)(this.tileNavPane1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textProductFeatures.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textProductID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textProductName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textCount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textWhoPurchase.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Navigation.TileNavPane tileNavPane1;
        private DevExpress.XtraBars.Navigation.NavButton navButton1;
        private DevExpress.XtraBars.Navigation.NavButton navButton3;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit textProductFeatures;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton buttonSelectReferance;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit textProductID;
        private DevExpress.XtraEditors.TextEdit textProductName;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit textCount;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit textWhoPurchase;
    }
}