
namespace FormUI.Views.MaintenanceForms
{
    partial class NewMaintenanceForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewMaintenanceForm));
            this.tileNavPane1 = new DevExpress.XtraBars.Navigation.TileNavPane();
            this.navButton1 = new DevExpress.XtraBars.Navigation.NavButton();
            this.navButton3 = new DevExpress.XtraBars.Navigation.NavButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.textCustomerAddress = new System.Windows.Forms.TextBox();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.textCustomerPhoneNumber = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.textCustomerName = new DevExpress.XtraEditors.TextEdit();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.textMaintenanceBaseLastDate = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.textMaintenanceBaseDate = new DevExpress.XtraEditors.TextEdit();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.textMaintenanceNote = new System.Windows.Forms.TextBox();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.textMaintenanceProcess = new System.Windows.Forms.TextBox();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.textMaintenancePerson = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.dateMaintenanceDate = new DevExpress.XtraEditors.DateEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.textMaintenanceTakedPrice = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.tileNavPane1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textCustomerPhoneNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textCustomerName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textMaintenanceBaseLastDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textMaintenanceBaseDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textMaintenancePerson.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateMaintenanceDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateMaintenanceDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textMaintenanceTakedPrice.Properties)).BeginInit();
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
            this.tileNavPane1.Size = new System.Drawing.Size(751, 45);
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
            // groupControl1
            // 
            this.groupControl1.Appearance.BorderColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary;
            this.groupControl1.Appearance.Options.UseBorderColor = true;
            this.groupControl1.Controls.Add(this.textCustomerAddress);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.textCustomerPhoneNumber);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.textCustomerName);
            this.groupControl1.Location = new System.Drawing.Point(539, 51);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(200, 212);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "Müşteri";
            // 
            // textCustomerAddress
            // 
            this.textCustomerAddress.Location = new System.Drawing.Point(6, 138);
            this.textCustomerAddress.Multiline = true;
            this.textCustomerAddress.Name = "textCustomerAddress";
            this.textCustomerAddress.ReadOnly = true;
            this.textCustomerAddress.Size = new System.Drawing.Size(189, 69);
            this.textCustomerAddress.TabIndex = 5;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(6, 119);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(35, 13);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Adres :";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(6, 73);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(51, 13);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Numarası :";
            // 
            // textCustomerPhoneNumber
            // 
            this.textCustomerPhoneNumber.Location = new System.Drawing.Point(5, 93);
            this.textCustomerPhoneNumber.Name = "textCustomerPhoneNumber";
            this.textCustomerPhoneNumber.Properties.ReadOnly = true;
            this.textCustomerPhoneNumber.Size = new System.Drawing.Size(190, 20);
            this.textCustomerPhoneNumber.TabIndex = 2;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(6, 30);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(22, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Adı :";
            // 
            // textCustomerName
            // 
            this.textCustomerName.Location = new System.Drawing.Point(5, 50);
            this.textCustomerName.Name = "textCustomerName";
            this.textCustomerName.Properties.ReadOnly = true;
            this.textCustomerName.Size = new System.Drawing.Size(190, 20);
            this.textCustomerName.TabIndex = 0;
            // 
            // groupControl2
            // 
            this.groupControl2.Appearance.BorderColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary;
            this.groupControl2.Appearance.Options.UseBorderColor = true;
            this.groupControl2.Controls.Add(this.labelControl5);
            this.groupControl2.Controls.Add(this.textMaintenanceBaseLastDate);
            this.groupControl2.Controls.Add(this.labelControl6);
            this.groupControl2.Controls.Add(this.textMaintenanceBaseDate);
            this.groupControl2.Location = new System.Drawing.Point(539, 320);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(200, 116);
            this.groupControl2.TabIndex = 6;
            this.groupControl2.Text = "Bakım Ayar";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(6, 73);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(84, 13);
            this.labelControl5.TabIndex = 3;
            this.labelControl5.Text = "Son Bakım Tarihi :";
            // 
            // textMaintenanceBaseLastDate
            // 
            this.textMaintenanceBaseLastDate.Location = new System.Drawing.Point(5, 93);
            this.textMaintenanceBaseLastDate.Name = "textMaintenanceBaseLastDate";
            this.textMaintenanceBaseLastDate.Properties.ReadOnly = true;
            this.textMaintenanceBaseLastDate.Size = new System.Drawing.Size(190, 20);
            this.textMaintenanceBaseLastDate.TabIndex = 2;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(6, 30);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(80, 13);
            this.labelControl6.TabIndex = 1;
            this.labelControl6.Text = "Başlangıç Tarihi :";
            // 
            // textMaintenanceBaseDate
            // 
            this.textMaintenanceBaseDate.Location = new System.Drawing.Point(5, 50);
            this.textMaintenanceBaseDate.Name = "textMaintenanceBaseDate";
            this.textMaintenanceBaseDate.Properties.ReadOnly = true;
            this.textMaintenanceBaseDate.Size = new System.Drawing.Size(190, 20);
            this.textMaintenanceBaseDate.TabIndex = 0;
            // 
            // groupControl3
            // 
            this.groupControl3.Appearance.BorderColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary;
            this.groupControl3.Appearance.Options.UseBorderColor = true;
            this.groupControl3.Controls.Add(this.textMaintenanceNote);
            this.groupControl3.Controls.Add(this.labelControl10);
            this.groupControl3.Controls.Add(this.textMaintenanceProcess);
            this.groupControl3.Controls.Add(this.labelControl9);
            this.groupControl3.Controls.Add(this.textMaintenancePerson);
            this.groupControl3.Controls.Add(this.labelControl8);
            this.groupControl3.Controls.Add(this.dateMaintenanceDate);
            this.groupControl3.Controls.Add(this.labelControl7);
            this.groupControl3.Controls.Add(this.textMaintenanceTakedPrice);
            this.groupControl3.Controls.Add(this.labelControl4);
            this.groupControl3.Location = new System.Drawing.Point(12, 51);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(521, 431);
            this.groupControl3.TabIndex = 7;
            this.groupControl3.Text = "Yapılan Bakım";
            // 
            // textMaintenanceNote
            // 
            this.textMaintenanceNote.Font = new System.Drawing.Font("Tahoma", 12F);
            this.textMaintenanceNote.Location = new System.Drawing.Point(5, 308);
            this.textMaintenanceNote.Multiline = true;
            this.textMaintenanceNote.Name = "textMaintenanceNote";
            this.textMaintenanceNote.Size = new System.Drawing.Size(511, 93);
            this.textMaintenanceNote.TabIndex = 12;
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl10.Appearance.Options.UseFont = true;
            this.labelControl10.Location = new System.Drawing.Point(5, 286);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(28, 16);
            this.labelControl10.TabIndex = 13;
            this.labelControl10.Text = "Not :";
            // 
            // textMaintenanceProcess
            // 
            this.textMaintenanceProcess.Font = new System.Drawing.Font("Tahoma", 12F);
            this.textMaintenanceProcess.Location = new System.Drawing.Point(5, 179);
            this.textMaintenanceProcess.Multiline = true;
            this.textMaintenanceProcess.Name = "textMaintenanceProcess";
            this.textMaintenanceProcess.Size = new System.Drawing.Size(511, 93);
            this.textMaintenanceProcess.TabIndex = 6;
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(5, 157);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(40, 16);
            this.labelControl9.TabIndex = 11;
            this.labelControl9.Text = "İşlem :";
            // 
            // textMaintenancePerson
            // 
            this.textMaintenancePerson.Location = new System.Drawing.Point(89, 106);
            this.textMaintenancePerson.Name = "textMaintenancePerson";
            this.textMaintenancePerson.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.textMaintenancePerson.Properties.Appearance.Options.UseFont = true;
            this.textMaintenancePerson.Size = new System.Drawing.Size(190, 26);
            this.textMaintenancePerson.TabIndex = 9;
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(5, 112);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(67, 16);
            this.labelControl8.TabIndex = 10;
            this.labelControl8.Text = "Yapan Kişi :";
            // 
            // dateMaintenanceDate
            // 
            this.dateMaintenanceDate.EditValue = null;
            this.dateMaintenanceDate.Location = new System.Drawing.Point(89, 67);
            this.dateMaintenanceDate.Name = "dateMaintenanceDate";
            this.dateMaintenanceDate.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.dateMaintenanceDate.Properties.Appearance.Options.UseFont = true;
            this.dateMaintenanceDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateMaintenanceDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateMaintenanceDate.Size = new System.Drawing.Size(190, 26);
            this.dateMaintenanceDate.TabIndex = 8;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(5, 73);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(47, 16);
            this.labelControl7.TabIndex = 7;
            this.labelControl7.Text = "Tarih* :";
            // 
            // textMaintenanceTakedPrice
            // 
            this.textMaintenanceTakedPrice.EditValue = "0";
            this.textMaintenanceTakedPrice.Location = new System.Drawing.Point(89, 29);
            this.textMaintenanceTakedPrice.Name = "textMaintenanceTakedPrice";
            this.textMaintenanceTakedPrice.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.textMaintenanceTakedPrice.Properties.Appearance.Options.UseFont = true;
            this.textMaintenanceTakedPrice.Properties.BeepOnError = false;
            this.textMaintenanceTakedPrice.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.textMaintenanceTakedPrice.Properties.MaskSettings.Set("mask", "c");
            this.textMaintenanceTakedPrice.Size = new System.Drawing.Size(190, 26);
            this.textMaintenanceTakedPrice.TabIndex = 6;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(5, 35);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(90, 16);
            this.labelControl4.TabIndex = 6;
            this.labelControl4.Text = "Alınan Ücret* : ";
            // 
            // NewMaintenanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 494);
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.tileNavPane1);
            this.MaximizeBox = false;
            this.Name = "NewMaintenanceForm";
            this.Text = "Yeni Bakım";
            this.Load += new System.EventHandler(this.NewMaintenanceForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tileNavPane1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textCustomerPhoneNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textCustomerName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textMaintenanceBaseLastDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textMaintenanceBaseDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.groupControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textMaintenancePerson.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateMaintenanceDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateMaintenanceDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textMaintenanceTakedPrice.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Navigation.TileNavPane tileNavPane1;
        private DevExpress.XtraBars.Navigation.NavButton navButton1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.TextBox textCustomerAddress;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit textCustomerPhoneNumber;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit textCustomerName;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit textMaintenanceBaseLastDate;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit textMaintenanceBaseDate;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.DateEdit dateMaintenanceDate;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit textMaintenanceTakedPrice;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit textMaintenancePerson;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraBars.Navigation.NavButton navButton3;
        private System.Windows.Forms.TextBox textMaintenanceNote;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private System.Windows.Forms.TextBox textMaintenanceProcess;
        private DevExpress.XtraEditors.LabelControl labelControl9;
    }
}