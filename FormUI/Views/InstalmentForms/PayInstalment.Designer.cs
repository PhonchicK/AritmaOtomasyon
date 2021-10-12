
namespace FormUI.Views.InstalmentForms
{
    partial class PayInstalment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PayInstalment));
            this.tileNavPane1 = new DevExpress.XtraBars.Navigation.TileNavPane();
            this.navButton1 = new DevExpress.XtraBars.Navigation.NavButton();
            this.navButton3 = new DevExpress.XtraBars.Navigation.NavButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.labelCustomerID = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.textCustomerPhone = new DevExpress.XtraEditors.TextEdit();
            this.textCustomerName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.labelLastDelayInstalment = new DevExpress.XtraEditors.LabelControl();
            this.labelControl14 = new DevExpress.XtraEditors.LabelControl();
            this.labelPayableInstalmentsCount = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.labelRemainderMonths = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelRemainderPrice = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelPayablePrice = new DevExpress.XtraEditors.LabelControl();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.textEditPrice = new DevExpress.XtraEditors.TextEdit();
            this.labelControl15 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl18 = new DevExpress.XtraEditors.LabelControl();
            this.datePaidDate = new DevExpress.XtraEditors.DateEdit();
            this.labelControl16 = new DevExpress.XtraEditors.LabelControl();
            this.labelPaymentDate = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.tileNavPane1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textCustomerPhone.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textCustomerName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEditPrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datePaidDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datePaidDate.Properties)).BeginInit();
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
            this.tileNavPane1.Size = new System.Drawing.Size(599, 44);
            this.tileNavPane1.TabIndex = 0;
            // 
            // navButton1
            // 
            this.navButton1.Alignment = DevExpress.XtraBars.Navigation.NavButtonAlignment.Left;
            this.navButton1.Caption = "Öde";
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
            this.groupControl1.AppearanceCaption.BorderColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary;
            this.groupControl1.AppearanceCaption.Options.UseBorderColor = true;
            this.groupControl1.Controls.Add(this.labelCustomerID);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.textCustomerPhone);
            this.groupControl1.Controls.Add(this.textCustomerName);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Location = new System.Drawing.Point(12, 177);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(246, 179);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "Müşteri";
            // 
            // labelCustomerID
            // 
            this.labelCustomerID.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelCustomerID.Appearance.Options.UseFont = true;
            this.labelCustomerID.Location = new System.Drawing.Point(101, 38);
            this.labelCustomerID.Name = "labelCustomerID";
            this.labelCustomerID.Size = new System.Drawing.Size(9, 19);
            this.labelCustomerID.TabIndex = 17;
            this.labelCustomerID.Text = "0";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(67, 38);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(28, 19);
            this.labelControl1.TabIndex = 11;
            this.labelControl1.Text = "İD :";
            // 
            // textCustomerPhone
            // 
            this.textCustomerPhone.Location = new System.Drawing.Point(4, 144);
            this.textCustomerPhone.Name = "textCustomerPhone";
            this.textCustomerPhone.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.textCustomerPhone.Properties.Appearance.Options.UseFont = true;
            this.textCustomerPhone.Properties.ReadOnly = true;
            this.textCustomerPhone.Size = new System.Drawing.Size(238, 26);
            this.textCustomerPhone.TabIndex = 16;
            // 
            // textCustomerName
            // 
            this.textCustomerName.Location = new System.Drawing.Point(4, 95);
            this.textCustomerName.Name = "textCustomerName";
            this.textCustomerName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.textCustomerName.Properties.Appearance.Options.UseFont = true;
            this.textCustomerName.Properties.ReadOnly = true;
            this.textCustomerName.Size = new System.Drawing.Size(238, 26);
            this.textCustomerName.TabIndex = 15;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(7, 125);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(90, 13);
            this.labelControl3.TabIndex = 14;
            this.labelControl3.Text = "Telefon Numarası :";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(7, 76);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(22, 13);
            this.labelControl2.TabIndex = 13;
            this.labelControl2.Text = "Adı :";
            // 
            // groupControl2
            // 
            this.groupControl2.AppearanceCaption.BorderColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary;
            this.groupControl2.AppearanceCaption.Options.UseBorderColor = true;
            this.groupControl2.Controls.Add(this.labelLastDelayInstalment);
            this.groupControl2.Controls.Add(this.labelControl14);
            this.groupControl2.Controls.Add(this.labelPayableInstalmentsCount);
            this.groupControl2.Controls.Add(this.labelControl10);
            this.groupControl2.Controls.Add(this.labelRemainderMonths);
            this.groupControl2.Controls.Add(this.labelControl8);
            this.groupControl2.Controls.Add(this.labelRemainderPrice);
            this.groupControl2.Controls.Add(this.labelControl6);
            this.groupControl2.Location = new System.Drawing.Point(332, 177);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(246, 179);
            this.groupControl2.TabIndex = 18;
            this.groupControl2.Text = "Taksit Bilgileri";
            // 
            // labelLastDelayInstalment
            // 
            this.labelLastDelayInstalment.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelLastDelayInstalment.Appearance.Options.UseFont = true;
            this.labelLastDelayInstalment.Location = new System.Drawing.Point(172, 141);
            this.labelLastDelayInstalment.Name = "labelLastDelayInstalment";
            this.labelLastDelayInstalment.Size = new System.Drawing.Size(9, 19);
            this.labelLastDelayInstalment.TabIndex = 23;
            this.labelLastDelayInstalment.Text = "0";
            // 
            // labelControl14
            // 
            this.labelControl14.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl14.Appearance.Options.UseFont = true;
            this.labelControl14.Location = new System.Drawing.Point(5, 140);
            this.labelControl14.Name = "labelControl14";
            this.labelControl14.Size = new System.Drawing.Size(161, 19);
            this.labelControl14.TabIndex = 22;
            this.labelControl14.Text = "Son Taksit Gecikmesi :";
            // 
            // labelPayableInstalmentsCount
            // 
            this.labelPayableInstalmentsCount.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelPayableInstalmentsCount.Appearance.Options.UseFont = true;
            this.labelPayableInstalmentsCount.Location = new System.Drawing.Point(172, 103);
            this.labelPayableInstalmentsCount.Name = "labelPayableInstalmentsCount";
            this.labelPayableInstalmentsCount.Size = new System.Drawing.Size(9, 19);
            this.labelPayableInstalmentsCount.TabIndex = 21;
            this.labelPayableInstalmentsCount.Text = "0";
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl10.Appearance.Options.UseFont = true;
            this.labelControl10.Location = new System.Drawing.Point(5, 102);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(161, 19);
            this.labelControl10.TabIndex = 20;
            this.labelControl10.Text = "Ödenmemiş Taksitler :";
            // 
            // labelRemainderMonths
            // 
            this.labelRemainderMonths.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelRemainderMonths.Appearance.Options.UseFont = true;
            this.labelRemainderMonths.Location = new System.Drawing.Point(172, 65);
            this.labelRemainderMonths.Name = "labelRemainderMonths";
            this.labelRemainderMonths.Size = new System.Drawing.Size(9, 19);
            this.labelRemainderMonths.TabIndex = 19;
            this.labelRemainderMonths.Text = "0";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(5, 64);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(73, 19);
            this.labelControl8.TabIndex = 18;
            this.labelControl8.Text = "Kalan Ay :";
            // 
            // labelRemainderPrice
            // 
            this.labelRemainderPrice.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelRemainderPrice.Appearance.Options.UseFont = true;
            this.labelRemainderPrice.Location = new System.Drawing.Point(172, 27);
            this.labelRemainderPrice.Name = "labelRemainderPrice";
            this.labelRemainderPrice.Size = new System.Drawing.Size(9, 19);
            this.labelRemainderPrice.TabIndex = 17;
            this.labelRemainderPrice.Text = "0";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(5, 26);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(144, 19);
            this.labelControl6.TabIndex = 11;
            this.labelControl6.Text = "Kalan Toplam Borç :";
            // 
            // labelPayablePrice
            // 
            this.labelPayablePrice.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelPayablePrice.Appearance.Options.UseFont = true;
            this.labelPayablePrice.Location = new System.Drawing.Point(141, 34);
            this.labelPayablePrice.Name = "labelPayablePrice";
            this.labelPayablePrice.Size = new System.Drawing.Size(9, 19);
            this.labelPayablePrice.TabIndex = 23;
            this.labelPayablePrice.Text = "0";
            // 
            // labelControl12
            // 
            this.labelControl12.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl12.Appearance.Options.UseFont = true;
            this.labelControl12.Location = new System.Drawing.Point(12, 34);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(123, 19);
            this.labelControl12.TabIndex = 22;
            this.labelControl12.Text = "Ödenecek Tutar :";
            // 
            // textEditPrice
            // 
            this.textEditPrice.Location = new System.Drawing.Point(307, 31);
            this.textEditPrice.Name = "textEditPrice";
            this.textEditPrice.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.textEditPrice.Properties.Appearance.Options.UseFont = true;
            this.textEditPrice.Properties.BeepOnError = false;
            this.textEditPrice.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.textEditPrice.Properties.MaskSettings.Set("MaskManagerSignature", "allowNull=False");
            this.textEditPrice.Properties.MaskSettings.Set("mask", "c");
            this.textEditPrice.Size = new System.Drawing.Size(251, 26);
            this.textEditPrice.TabIndex = 26;
            // 
            // labelControl15
            // 
            this.labelControl15.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl15.Appearance.Options.UseFont = true;
            this.labelControl15.Location = new System.Drawing.Point(252, 34);
            this.labelControl15.Name = "labelControl15";
            this.labelControl15.Size = new System.Drawing.Size(49, 19);
            this.labelControl15.TabIndex = 25;
            this.labelControl15.Text = "Tutar :";
            // 
            // groupControl3
            // 
            this.groupControl3.AppearanceCaption.BorderColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary;
            this.groupControl3.AppearanceCaption.Options.UseBorderColor = true;
            this.groupControl3.Controls.Add(this.labelControl18);
            this.groupControl3.Controls.Add(this.datePaidDate);
            this.groupControl3.Controls.Add(this.labelControl16);
            this.groupControl3.Controls.Add(this.labelPaymentDate);
            this.groupControl3.Controls.Add(this.textEditPrice);
            this.groupControl3.Controls.Add(this.labelControl12);
            this.groupControl3.Controls.Add(this.labelControl15);
            this.groupControl3.Controls.Add(this.labelPayablePrice);
            this.groupControl3.Location = new System.Drawing.Point(12, 57);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(566, 105);
            this.groupControl3.TabIndex = 18;
            this.groupControl3.Text = "Ödeme";
            // 
            // labelControl18
            // 
            this.labelControl18.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl18.Appearance.Options.UseFont = true;
            this.labelControl18.Location = new System.Drawing.Point(252, 70);
            this.labelControl18.Name = "labelControl18";
            this.labelControl18.Size = new System.Drawing.Size(103, 19);
            this.labelControl18.TabIndex = 30;
            this.labelControl18.Text = "ÖdenenTarih :";
            // 
            // datePaidDate
            // 
            this.datePaidDate.EditValue = null;
            this.datePaidDate.Location = new System.Drawing.Point(380, 67);
            this.datePaidDate.Name = "datePaidDate";
            this.datePaidDate.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.datePaidDate.Properties.Appearance.Options.UseFont = true;
            this.datePaidDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.datePaidDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.datePaidDate.Size = new System.Drawing.Size(178, 26);
            this.datePaidDate.TabIndex = 29;
            // 
            // labelControl16
            // 
            this.labelControl16.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl16.Appearance.Options.UseFont = true;
            this.labelControl16.Location = new System.Drawing.Point(12, 70);
            this.labelControl16.Name = "labelControl16";
            this.labelControl16.Size = new System.Drawing.Size(122, 19);
            this.labelControl16.TabIndex = 27;
            this.labelControl16.Text = "Ödenecek Tarih :";
            // 
            // labelPaymentDate
            // 
            this.labelPaymentDate.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelPaymentDate.Appearance.Options.UseFont = true;
            this.labelPaymentDate.Location = new System.Drawing.Point(141, 70);
            this.labelPaymentDate.Name = "labelPaymentDate";
            this.labelPaymentDate.Size = new System.Drawing.Size(9, 19);
            this.labelPaymentDate.TabIndex = 28;
            this.labelPaymentDate.Text = "0";
            // 
            // PayInstalment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 373);
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.tileNavPane1);
            this.MaximizeBox = false;
            this.Name = "PayInstalment";
            this.Text = "Taksit Ödeme";
            this.Load += new System.EventHandler(this.PayInstalment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tileNavPane1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textCustomerPhone.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textCustomerName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEditPrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.groupControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datePaidDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datePaidDate.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Navigation.TileNavPane tileNavPane1;
        private DevExpress.XtraBars.Navigation.NavButton navButton1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelCustomerID;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit textCustomerPhone;
        private DevExpress.XtraEditors.TextEdit textCustomerName;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.LabelControl labelLastDelayInstalment;
        private DevExpress.XtraEditors.LabelControl labelControl14;
        private DevExpress.XtraEditors.LabelControl labelPayableInstalmentsCount;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LabelControl labelRemainderMonths;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelRemainderPrice;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelPayablePrice;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.TextEdit textEditPrice;
        private DevExpress.XtraEditors.LabelControl labelControl15;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.DateEdit datePaidDate;
        private DevExpress.XtraEditors.LabelControl labelControl16;
        private DevExpress.XtraEditors.LabelControl labelPaymentDate;
        private DevExpress.XtraEditors.LabelControl labelControl18;
        private DevExpress.XtraBars.Navigation.NavButton navButton3;
    }
}