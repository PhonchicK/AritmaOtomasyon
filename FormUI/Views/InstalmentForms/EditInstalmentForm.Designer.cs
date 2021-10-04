
namespace FormUI.Views.InstalmentForms
{
    partial class EditInstalmentForm
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
            this.mainRibbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bbiSave = new DevExpress.XtraBars.BarButtonItem();
            this.bbiSaveAndClose = new DevExpress.XtraBars.BarButtonItem();
            this.bbiReset = new DevExpress.XtraBars.BarButtonItem();
            this.bbiClose = new DevExpress.XtraBars.BarButtonItem();
            this.mainRibbonPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.mainRibbonPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.textCustomerPhone = new DevExpress.XtraEditors.TextEdit();
            this.textCustomerName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
            this.textPaidPrice = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.datePaidDate = new DevExpress.XtraEditors.DateEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.textInstalmentPayablePrice = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.dateInstalmentPaymentDate = new DevExpress.XtraEditors.DateEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.textInstalmentNo = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.mainRibbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textCustomerPhone.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textCustomerName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).BeginInit();
            this.groupControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textPaidPrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datePaidDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datePaidDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textInstalmentPayablePrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateInstalmentPaymentDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateInstalmentPaymentDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textInstalmentNo.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // mainRibbonControl
            // 
            this.mainRibbonControl.ExpandCollapseItem.Id = 0;
            this.mainRibbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.mainRibbonControl.ExpandCollapseItem,
            this.mainRibbonControl.SearchEditItem,
            this.bbiSave,
            this.bbiSaveAndClose,
            this.bbiReset,
            this.bbiClose});
            this.mainRibbonControl.Location = new System.Drawing.Point(0, 0);
            this.mainRibbonControl.MaxItemId = 10;
            this.mainRibbonControl.Name = "mainRibbonControl";
            this.mainRibbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.mainRibbonPage});
            this.mainRibbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            this.mainRibbonControl.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.mainRibbonControl.Size = new System.Drawing.Size(381, 158);
            this.mainRibbonControl.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // bbiSave
            // 
            this.bbiSave.Caption = "Save";
            this.bbiSave.Id = 2;
            this.bbiSave.ImageOptions.ImageUri.Uri = "Save";
            this.bbiSave.Name = "bbiSave";
            this.bbiSave.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiSave_ItemClick);
            // 
            // bbiSaveAndClose
            // 
            this.bbiSaveAndClose.Caption = "Save And Close";
            this.bbiSaveAndClose.Id = 3;
            this.bbiSaveAndClose.ImageOptions.ImageUri.Uri = "SaveAndClose";
            this.bbiSaveAndClose.Name = "bbiSaveAndClose";
            this.bbiSaveAndClose.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiSaveAndClose_ItemClick);
            // 
            // bbiReset
            // 
            this.bbiReset.Caption = "Reset Changes";
            this.bbiReset.Id = 5;
            this.bbiReset.ImageOptions.ImageUri.Uri = "Reset";
            this.bbiReset.Name = "bbiReset";
            this.bbiReset.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiReset_ItemClick);
            // 
            // bbiClose
            // 
            this.bbiClose.Caption = "Close";
            this.bbiClose.Id = 7;
            this.bbiClose.ImageOptions.ImageUri.Uri = "Close";
            this.bbiClose.Name = "bbiClose";
            this.bbiClose.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiClose_ItemClick);
            // 
            // mainRibbonPage
            // 
            this.mainRibbonPage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.mainRibbonPageGroup});
            this.mainRibbonPage.MergeOrder = 0;
            this.mainRibbonPage.Name = "mainRibbonPage";
            this.mainRibbonPage.Text = "Home";
            // 
            // mainRibbonPageGroup
            // 
            this.mainRibbonPageGroup.AllowTextClipping = false;
            this.mainRibbonPageGroup.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
            this.mainRibbonPageGroup.ItemLinks.Add(this.bbiSave);
            this.mainRibbonPageGroup.ItemLinks.Add(this.bbiSaveAndClose);
            this.mainRibbonPageGroup.ItemLinks.Add(this.bbiReset);
            this.mainRibbonPageGroup.ItemLinks.Add(this.bbiClose);
            this.mainRibbonPageGroup.Name = "mainRibbonPageGroup";
            this.mainRibbonPageGroup.Text = "Tasks";
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.BorderColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary;
            this.groupControl1.AppearanceCaption.Options.UseBorderColor = true;
            this.groupControl1.Controls.Add(this.textCustomerPhone);
            this.groupControl1.Controls.Add(this.textCustomerName);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Location = new System.Drawing.Point(12, 453);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(357, 107);
            this.groupControl1.TabIndex = 4;
            this.groupControl1.Text = "Müşteri";
            // 
            // textCustomerPhone
            // 
            this.textCustomerPhone.Location = new System.Drawing.Point(114, 66);
            this.textCustomerPhone.Name = "textCustomerPhone";
            this.textCustomerPhone.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.textCustomerPhone.Properties.Appearance.Options.UseFont = true;
            this.textCustomerPhone.Properties.ReadOnly = true;
            this.textCustomerPhone.Size = new System.Drawing.Size(238, 26);
            this.textCustomerPhone.TabIndex = 16;
            // 
            // textCustomerName
            // 
            this.textCustomerName.Location = new System.Drawing.Point(114, 26);
            this.textCustomerName.Name = "textCustomerName";
            this.textCustomerName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.textCustomerName.Properties.Appearance.Options.UseFont = true;
            this.textCustomerName.Properties.ReadOnly = true;
            this.textCustomerName.Size = new System.Drawing.Size(238, 26);
            this.textCustomerName.TabIndex = 15;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(6, 74);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(90, 13);
            this.labelControl3.TabIndex = 14;
            this.labelControl3.Text = "Telefon Numarası :";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(11, 34);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(22, 13);
            this.labelControl2.TabIndex = 13;
            this.labelControl2.Text = "Adı :";
            // 
            // groupControl2
            // 
            this.groupControl2.AppearanceCaption.BorderColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary;
            this.groupControl2.AppearanceCaption.Options.UseBorderColor = true;
            this.groupControl2.Controls.Add(this.groupControl4);
            this.groupControl2.Controls.Add(this.groupControl3);
            this.groupControl2.Controls.Add(this.textInstalmentNo);
            this.groupControl2.Controls.Add(this.labelControl1);
            this.groupControl2.Location = new System.Drawing.Point(12, 164);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(357, 283);
            this.groupControl2.TabIndex = 17;
            this.groupControl2.Text = "Taksit";
            // 
            // groupControl4
            // 
            this.groupControl4.AppearanceCaption.BorderColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary;
            this.groupControl4.AppearanceCaption.Options.UseBorderColor = true;
            this.groupControl4.Controls.Add(this.textPaidPrice);
            this.groupControl4.Controls.Add(this.labelControl6);
            this.groupControl4.Controls.Add(this.datePaidDate);
            this.groupControl4.Controls.Add(this.labelControl7);
            this.groupControl4.Location = new System.Drawing.Point(5, 178);
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.Size = new System.Drawing.Size(347, 101);
            this.groupControl4.TabIndex = 21;
            this.groupControl4.Text = "Ödenen";
            // 
            // textPaidPrice
            // 
            this.textPaidPrice.Location = new System.Drawing.Point(53, 66);
            this.textPaidPrice.MenuManager = this.mainRibbonControl;
            this.textPaidPrice.Name = "textPaidPrice";
            this.textPaidPrice.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.textPaidPrice.Properties.Appearance.Options.UseFont = true;
            this.textPaidPrice.Properties.BeepOnError = false;
            this.textPaidPrice.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.textPaidPrice.Properties.MaskSettings.Set("MaskManagerSignature", "allowNull=False");
            this.textPaidPrice.Properties.MaskSettings.Set("mask", "c");
            this.textPaidPrice.Size = new System.Drawing.Size(289, 26);
            this.textPaidPrice.TabIndex = 20;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(7, 72);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(40, 16);
            this.labelControl6.TabIndex = 19;
            this.labelControl6.Text = "Tutar :";
            // 
            // datePaidDate
            // 
            this.datePaidDate.EditValue = null;
            this.datePaidDate.Location = new System.Drawing.Point(52, 29);
            this.datePaidDate.MenuManager = this.mainRibbonControl;
            this.datePaidDate.Name = "datePaidDate";
            this.datePaidDate.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.datePaidDate.Properties.Appearance.Options.UseFont = true;
            this.datePaidDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.datePaidDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.datePaidDate.Size = new System.Drawing.Size(290, 26);
            this.datePaidDate.TabIndex = 18;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(7, 35);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(39, 16);
            this.labelControl7.TabIndex = 17;
            this.labelControl7.Text = "Tarih :";
            // 
            // groupControl3
            // 
            this.groupControl3.AppearanceCaption.BorderColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary;
            this.groupControl3.AppearanceCaption.Options.UseBorderColor = true;
            this.groupControl3.Controls.Add(this.textInstalmentPayablePrice);
            this.groupControl3.Controls.Add(this.labelControl5);
            this.groupControl3.Controls.Add(this.dateInstalmentPaymentDate);
            this.groupControl3.Controls.Add(this.labelControl4);
            this.groupControl3.Location = new System.Drawing.Point(5, 71);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(347, 101);
            this.groupControl3.TabIndex = 17;
            this.groupControl3.Text = "Ödenecek";
            // 
            // textInstalmentPayablePrice
            // 
            this.textInstalmentPayablePrice.Location = new System.Drawing.Point(53, 66);
            this.textInstalmentPayablePrice.MenuManager = this.mainRibbonControl;
            this.textInstalmentPayablePrice.Name = "textInstalmentPayablePrice";
            this.textInstalmentPayablePrice.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.textInstalmentPayablePrice.Properties.Appearance.Options.UseFont = true;
            this.textInstalmentPayablePrice.Properties.BeepOnError = false;
            this.textInstalmentPayablePrice.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.textInstalmentPayablePrice.Properties.MaskSettings.Set("MaskManagerSignature", "allowNull=False");
            this.textInstalmentPayablePrice.Properties.MaskSettings.Set("mask", "c");
            this.textInstalmentPayablePrice.Properties.ReadOnly = true;
            this.textInstalmentPayablePrice.Size = new System.Drawing.Size(289, 26);
            this.textInstalmentPayablePrice.TabIndex = 20;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(7, 72);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(40, 16);
            this.labelControl5.TabIndex = 19;
            this.labelControl5.Text = "Tutar :";
            // 
            // dateInstalmentPaymentDate
            // 
            this.dateInstalmentPaymentDate.EditValue = null;
            this.dateInstalmentPaymentDate.Location = new System.Drawing.Point(52, 29);
            this.dateInstalmentPaymentDate.MenuManager = this.mainRibbonControl;
            this.dateInstalmentPaymentDate.Name = "dateInstalmentPaymentDate";
            this.dateInstalmentPaymentDate.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.dateInstalmentPaymentDate.Properties.Appearance.Options.UseFont = true;
            this.dateInstalmentPaymentDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateInstalmentPaymentDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateInstalmentPaymentDate.Properties.ReadOnly = true;
            this.dateInstalmentPaymentDate.Size = new System.Drawing.Size(290, 26);
            this.dateInstalmentPaymentDate.TabIndex = 18;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(7, 35);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(39, 16);
            this.labelControl4.TabIndex = 17;
            this.labelControl4.Text = "Tarih :";
            // 
            // textInstalmentNo
            // 
            this.textInstalmentNo.Location = new System.Drawing.Point(54, 26);
            this.textInstalmentNo.Name = "textInstalmentNo";
            this.textInstalmentNo.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.textInstalmentNo.Properties.Appearance.Options.UseFont = true;
            this.textInstalmentNo.Properties.ReadOnly = true;
            this.textInstalmentNo.Size = new System.Drawing.Size(298, 26);
            this.textInstalmentNo.TabIndex = 18;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(7, 32);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(32, 16);
            this.labelControl1.TabIndex = 17;
            this.labelControl1.Text = "Sıra :";
            // 
            // EditInstalmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(381, 563);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.mainRibbonControl);
            this.MaximizeBox = false;
            this.Name = "EditInstalmentForm";
            this.Ribbon = this.mainRibbonControl;
            this.Load += new System.EventHandler(this.EditInstalmentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mainRibbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textCustomerPhone.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textCustomerName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
            this.groupControl4.ResumeLayout(false);
            this.groupControl4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textPaidPrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datePaidDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datePaidDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.groupControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textInstalmentPayablePrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateInstalmentPaymentDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateInstalmentPaymentDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textInstalmentNo.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.Ribbon.RibbonControl mainRibbonControl;
        private DevExpress.XtraBars.Ribbon.RibbonPage mainRibbonPage;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup mainRibbonPageGroup;
        private DevExpress.XtraBars.BarButtonItem bbiSave;
        private DevExpress.XtraBars.BarButtonItem bbiSaveAndClose;
        private DevExpress.XtraBars.BarButtonItem bbiReset;
        private DevExpress.XtraBars.BarButtonItem bbiClose;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit textCustomerPhone;
        private DevExpress.XtraEditors.TextEdit textCustomerName;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.TextEdit textInstalmentNo;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl4;
        private DevExpress.XtraEditors.TextEdit textPaidPrice;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.DateEdit datePaidDate;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit textInstalmentPayablePrice;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.DateEdit dateInstalmentPaymentDate;
        private DevExpress.XtraEditors.LabelControl labelControl4;
    }
}