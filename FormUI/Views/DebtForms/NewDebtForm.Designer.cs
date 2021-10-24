
namespace FormUI.Views.DebtForms
{
    partial class NewDebtForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewDebtForm));
            this.tileNavPane1 = new DevExpress.XtraBars.Navigation.TileNavPane();
            this.navButton1 = new DevExpress.XtraBars.Navigation.NavButton();
            this.navButton3 = new DevExpress.XtraBars.Navigation.NavButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.buttonSelectReferance = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.textCustomerID = new DevExpress.XtraEditors.TextEdit();
            this.textCustomerPhoneNumber = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.textCustomerName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.dateDebtDate = new DevExpress.XtraEditors.DateEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.textReceive = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.textGive = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.textComment = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.tileNavPane1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textCustomerID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textCustomerPhoneNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textCustomerName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateDebtDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateDebtDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textReceive.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textGive.Properties)).BeginInit();
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
            this.tileNavPane1.Size = new System.Drawing.Size(381, 59);
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
            this.groupControl1.Controls.Add(this.buttonSelectReferance);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.textCustomerID);
            this.groupControl1.Controls.Add(this.textCustomerPhoneNumber);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.textCustomerName);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(12, 65);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(353, 177);
            this.groupControl1.TabIndex = 3;
            this.groupControl1.Text = "Müşteri";
            // 
            // buttonSelectReferance
            // 
            this.buttonSelectReferance.Location = new System.Drawing.Point(162, 29);
            this.buttonSelectReferance.Name = "buttonSelectReferance";
            this.buttonSelectReferance.Size = new System.Drawing.Size(30, 23);
            this.buttonSelectReferance.TabIndex = 16;
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
            // textCustomerID
            // 
            this.textCustomerID.Location = new System.Drawing.Point(46, 27);
            this.textCustomerID.Name = "textCustomerID";
            this.textCustomerID.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.textCustomerID.Properties.Appearance.Options.UseFont = true;
            this.textCustomerID.Properties.ReadOnly = true;
            this.textCustomerID.Size = new System.Drawing.Size(110, 26);
            this.textCustomerID.TabIndex = 4;
            this.textCustomerID.EditValueChanged += new System.EventHandler(this.textCustomerID_EditValueChanged);
            // 
            // textCustomerPhoneNumber
            // 
            this.textCustomerPhoneNumber.Location = new System.Drawing.Point(5, 138);
            this.textCustomerPhoneNumber.Name = "textCustomerPhoneNumber";
            this.textCustomerPhoneNumber.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.textCustomerPhoneNumber.Properties.Appearance.Options.UseFont = true;
            this.textCustomerPhoneNumber.Properties.BeepOnError = false;
            this.textCustomerPhoneNumber.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.RegularMaskManager));
            this.textCustomerPhoneNumber.Properties.MaskSettings.Set("mask", "(\\d?\\d?\\d?) \\d\\d\\d-\\d\\d\\d\\d");
            this.textCustomerPhoneNumber.Properties.ReadOnly = true;
            this.textCustomerPhoneNumber.Size = new System.Drawing.Size(343, 26);
            this.textCustomerPhoneNumber.TabIndex = 3;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(5, 116);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(110, 16);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Telefon Numarası :";
            // 
            // textCustomerName
            // 
            this.textCustomerName.Location = new System.Drawing.Point(5, 86);
            this.textCustomerName.Name = "textCustomerName";
            this.textCustomerName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.textCustomerName.Properties.Appearance.Options.UseFont = true;
            this.textCustomerName.Properties.ReadOnly = true;
            this.textCustomerName.Size = new System.Drawing.Size(343, 26);
            this.textCustomerName.TabIndex = 1;
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
            // dateDebtDate
            // 
            this.dateDebtDate.EditValue = null;
            this.dateDebtDate.Location = new System.Drawing.Point(84, 265);
            this.dateDebtDate.Name = "dateDebtDate";
            this.dateDebtDate.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.dateDebtDate.Properties.Appearance.Options.UseFont = true;
            this.dateDebtDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateDebtDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateDebtDate.Size = new System.Drawing.Size(276, 26);
            this.dateDebtDate.TabIndex = 4;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(17, 271);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(43, 16);
            this.labelControl4.TabIndex = 17;
            this.labelControl4.Text = "Tarih : ";
            // 
            // textReceive
            // 
            this.textReceive.EditValue = "0";
            this.textReceive.Location = new System.Drawing.Point(84, 312);
            this.textReceive.Name = "textReceive";
            this.textReceive.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.textReceive.Properties.Appearance.Options.UseFont = true;
            this.textReceive.Properties.BeepOnError = false;
            this.textReceive.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.textReceive.Properties.MaskSettings.Set("mask", "c");
            this.textReceive.Size = new System.Drawing.Size(276, 26);
            this.textReceive.TabIndex = 18;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(17, 318);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(50, 16);
            this.labelControl5.TabIndex = 19;
            this.labelControl5.Text = "Alacak : ";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(17, 364);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(48, 16);
            this.labelControl6.TabIndex = 21;
            this.labelControl6.Text = "Vercek :";
            // 
            // textGive
            // 
            this.textGive.EditValue = "0";
            this.textGive.Location = new System.Drawing.Point(84, 358);
            this.textGive.Name = "textGive";
            this.textGive.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.textGive.Properties.Appearance.Options.UseFont = true;
            this.textGive.Properties.BeepOnError = false;
            this.textGive.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.textGive.Properties.MaskSettings.Set("mask", "c");
            this.textGive.Size = new System.Drawing.Size(276, 26);
            this.textGive.TabIndex = 20;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(17, 399);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(64, 16);
            this.labelControl7.TabIndex = 22;
            this.labelControl7.Text = "Açıklama : ";
            // 
            // textComment
            // 
            this.textComment.Font = new System.Drawing.Font("Tahoma", 12F);
            this.textComment.Location = new System.Drawing.Point(17, 422);
            this.textComment.Multiline = true;
            this.textComment.Name = "textComment";
            this.textComment.Size = new System.Drawing.Size(343, 95);
            this.textComment.TabIndex = 23;
            // 
            // NewDebtForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 529);
            this.Controls.Add(this.textComment);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.textGive);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.textReceive);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.dateDebtDate);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.tileNavPane1);
            this.MaximizeBox = false;
            this.Name = "NewDebtForm";
            this.Text = "Yeni Alacak / Verecek";
            this.Load += new System.EventHandler(this.NewDebtForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tileNavPane1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textCustomerID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textCustomerPhoneNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textCustomerName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateDebtDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateDebtDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textReceive.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textGive.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Navigation.TileNavPane tileNavPane1;
        private DevExpress.XtraBars.Navigation.NavButton navButton1;
        private DevExpress.XtraBars.Navigation.NavButton navButton3;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit textCustomerID;
        private DevExpress.XtraEditors.TextEdit textCustomerPhoneNumber;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit textCustomerName;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton buttonSelectReferance;
        private DevExpress.XtraEditors.DateEdit dateDebtDate;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit textReceive;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit textGive;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private System.Windows.Forms.TextBox textComment;
    }
}