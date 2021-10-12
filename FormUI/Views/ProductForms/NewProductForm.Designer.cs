
namespace FormUI.Views.ProductForms
{
    partial class NewProductForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewProductForm));
            this.tileNavPane1 = new DevExpress.XtraBars.Navigation.TileNavPane();
            this.navButton1 = new DevExpress.XtraBars.Navigation.NavButton();
            this.navButton3 = new DevExpress.XtraBars.Navigation.NavButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.textProductName = new DevExpress.XtraEditors.TextEdit();
            this.textFeatures = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.textPrice = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.tileNavPane1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textProductName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textFeatures.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textPrice.Properties)).BeginInit();
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
            this.tileNavPane1.Size = new System.Drawing.Size(270, 40);
            this.tileNavPane1.TabIndex = 0;
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
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(12, 46);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(35, 16);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Adı* :";
            // 
            // textProductName
            // 
            this.textProductName.Location = new System.Drawing.Point(12, 68);
            this.textProductName.Name = "textProductName";
            this.textProductName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.textProductName.Properties.Appearance.Options.UseFont = true;
            this.textProductName.Size = new System.Drawing.Size(246, 26);
            this.textProductName.TabIndex = 2;
            // 
            // textFeatures
            // 
            this.textFeatures.Location = new System.Drawing.Point(12, 126);
            this.textFeatures.Name = "textFeatures";
            this.textFeatures.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.textFeatures.Properties.Appearance.Options.UseFont = true;
            this.textFeatures.Size = new System.Drawing.Size(246, 26);
            this.textFeatures.TabIndex = 4;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(12, 104);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(64, 16);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Özellikleri :";
            // 
            // textPrice
            // 
            this.textPrice.Location = new System.Drawing.Point(12, 180);
            this.textPrice.Name = "textPrice";
            this.textPrice.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.textPrice.Properties.Appearance.Options.UseFont = true;
            this.textPrice.Properties.BeepOnError = false;
            this.textPrice.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.textPrice.Properties.MaskSettings.Set("mask", "c");
            this.textPrice.Size = new System.Drawing.Size(246, 26);
            this.textPrice.TabIndex = 6;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(12, 158);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(36, 16);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "Fiyat :";
            // 
            // NewProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 214);
            this.Controls.Add(this.textPrice);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.textFeatures);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.textProductName);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.tileNavPane1);
            this.MaximizeBox = false;
            this.Name = "NewProductForm";
            this.Text = "Ürün Ekle";
            ((System.ComponentModel.ISupportInitialize)(this.tileNavPane1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textProductName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textFeatures.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textPrice.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Navigation.TileNavPane tileNavPane1;
        private DevExpress.XtraBars.Navigation.NavButton navButton1;
        private DevExpress.XtraBars.Navigation.NavButton navButton3;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit textProductName;
        private DevExpress.XtraEditors.TextEdit textFeatures;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit textPrice;
        private DevExpress.XtraEditors.LabelControl labelControl3;
    }
}