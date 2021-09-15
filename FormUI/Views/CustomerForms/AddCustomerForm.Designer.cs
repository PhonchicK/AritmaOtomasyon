
namespace FormUI.Views.CustomerForms
{
    partial class AddCustomerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddCustomerForm));
            this.tileNavPane1 = new DevExpress.XtraBars.Navigation.TileNavPane();
            this.navButton1 = new DevExpress.XtraBars.Navigation.NavButton();
            this.TextName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.TextPhoneNumber = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.TextAddress = new System.Windows.Forms.TextBox();
            this.navButton3 = new DevExpress.XtraBars.Navigation.NavButton();
            ((System.ComponentModel.ISupportInitialize)(this.tileNavPane1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextPhoneNumber.Properties)).BeginInit();
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
            this.tileNavPane1.Size = new System.Drawing.Size(393, 59);
            this.tileNavPane1.TabIndex = 0;
            // 
            // navButton1
            // 
            this.navButton1.Alignment = DevExpress.XtraBars.Navigation.NavButtonAlignment.Left;
            this.navButton1.Caption = "Onay";
            this.navButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("navButton1.ImageOptions.Image")));
            this.navButton1.Name = "navButton1";
            this.navButton1.ElementClick += new DevExpress.XtraBars.Navigation.NavElementClickEventHandler(this.navButton1_ElementClick);
            // 
            // TextName
            // 
            this.TextName.Location = new System.Drawing.Point(115, 90);
            this.TextName.Name = "TextName";
            this.TextName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TextName.Properties.Appearance.Options.UseFont = true;
            this.TextName.Size = new System.Drawing.Size(266, 32);
            this.TextName.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(12, 93);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(54, 25);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "İsim :";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(12, 146);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(83, 25);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "Telefon :";
            // 
            // TextPhoneNumber
            // 
            this.TextPhoneNumber.Location = new System.Drawing.Point(115, 143);
            this.TextPhoneNumber.Name = "TextPhoneNumber";
            this.TextPhoneNumber.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TextPhoneNumber.Properties.Appearance.Options.UseFont = true;
            this.TextPhoneNumber.Size = new System.Drawing.Size(266, 32);
            this.TextPhoneNumber.TabIndex = 3;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(12, 199);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(67, 25);
            this.labelControl3.TabIndex = 6;
            this.labelControl3.Text = "Adres :";
            // 
            // TextAddress
            // 
            this.TextAddress.Font = new System.Drawing.Font("Tahoma", 15.75F);
            this.TextAddress.Location = new System.Drawing.Point(12, 230);
            this.TextAddress.Multiline = true;
            this.TextAddress.Name = "TextAddress";
            this.TextAddress.Size = new System.Drawing.Size(369, 183);
            this.TextAddress.TabIndex = 7;
            // 
            // navButton3
            // 
            this.navButton3.Alignment = DevExpress.XtraBars.Navigation.NavButtonAlignment.Left;
            this.navButton3.Caption = "İptal";
            this.navButton3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("navButton3.ImageOptions.Image")));
            this.navButton3.Name = "navButton3";
            this.navButton3.ElementClick += new DevExpress.XtraBars.Navigation.NavElementClickEventHandler(this.navButton3_ElementClick);
            // 
            // AddCustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 425);
            this.Controls.Add(this.TextAddress);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.TextPhoneNumber);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.TextName);
            this.Controls.Add(this.tileNavPane1);
            this.Name = "AddCustomerForm";
            this.Text = "AddCustomerForm";
            ((System.ComponentModel.ISupportInitialize)(this.tileNavPane1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextPhoneNumber.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Navigation.TileNavPane tileNavPane1;
        private DevExpress.XtraBars.Navigation.NavButton navButton1;
        private DevExpress.XtraBars.Navigation.NavButton navButton3;
        private DevExpress.XtraEditors.TextEdit TextName;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit TextPhoneNumber;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.TextBox TextAddress;
    }
}