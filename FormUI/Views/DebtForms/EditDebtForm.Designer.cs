
namespace FormUI.Views.DebtForms
{
    partial class EditDebtForm
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
            this.bbiDelete = new DevExpress.XtraBars.BarButtonItem();
            this.bbiClose = new DevExpress.XtraBars.BarButtonItem();
            this.mainRibbonPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.mainRibbonPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.textComment = new System.Windows.Forms.TextBox();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.textGive = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.textReceive = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.dateDebtDate = new DevExpress.XtraEditors.DateEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.buttonSelectReferance = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.textCustomerID = new DevExpress.XtraEditors.TextEdit();
            this.textCustomerPhoneNumber = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.textCustomerName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.mainRibbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textGive.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textReceive.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateDebtDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateDebtDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textCustomerID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textCustomerPhoneNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textCustomerName.Properties)).BeginInit();
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
            this.bbiDelete,
            this.bbiClose});
            this.mainRibbonControl.Location = new System.Drawing.Point(0, 0);
            this.mainRibbonControl.MaxItemId = 10;
            this.mainRibbonControl.Name = "mainRibbonControl";
            this.mainRibbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.mainRibbonPage});
            this.mainRibbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            this.mainRibbonControl.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.mainRibbonControl.Size = new System.Drawing.Size(378, 158);
            this.mainRibbonControl.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // bbiSave
            // 
            this.bbiSave.Caption = "Kaydet";
            this.bbiSave.Id = 2;
            this.bbiSave.ImageOptions.ImageUri.Uri = "Save";
            this.bbiSave.Name = "bbiSave";
            this.bbiSave.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiSave_ItemClick);
            // 
            // bbiSaveAndClose
            // 
            this.bbiSaveAndClose.Caption = "Kaydet ve Kapat";
            this.bbiSaveAndClose.Id = 3;
            this.bbiSaveAndClose.ImageOptions.ImageUri.Uri = "SaveAndClose";
            this.bbiSaveAndClose.Name = "bbiSaveAndClose";
            this.bbiSaveAndClose.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiSaveAndClose_ItemClick);
            // 
            // bbiReset
            // 
            this.bbiReset.Caption = "Değişiklikleri Sıfırla";
            this.bbiReset.Id = 5;
            this.bbiReset.ImageOptions.ImageUri.Uri = "Reset";
            this.bbiReset.Name = "bbiReset";
            this.bbiReset.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiReset_ItemClick);
            // 
            // bbiDelete
            // 
            this.bbiDelete.Caption = "Sil";
            this.bbiDelete.Id = 6;
            this.bbiDelete.ImageOptions.ImageUri.Uri = "Delete";
            this.bbiDelete.Name = "bbiDelete";
            this.bbiDelete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiDelete_ItemClick);
            // 
            // bbiClose
            // 
            this.bbiClose.Caption = "Kapat";
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
            this.mainRibbonPageGroup.ItemLinks.Add(this.bbiDelete);
            this.mainRibbonPageGroup.ItemLinks.Add(this.bbiClose);
            this.mainRibbonPageGroup.Name = "mainRibbonPageGroup";
            this.mainRibbonPageGroup.Text = "İşlemler";
            // 
            // textComment
            // 
            this.textComment.Font = new System.Drawing.Font("Tahoma", 12F);
            this.textComment.Location = new System.Drawing.Point(17, 521);
            this.textComment.Multiline = true;
            this.textComment.Name = "textComment";
            this.textComment.Size = new System.Drawing.Size(343, 95);
            this.textComment.TabIndex = 32;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(17, 498);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(64, 16);
            this.labelControl7.TabIndex = 31;
            this.labelControl7.Text = "Açıklama : ";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(17, 463);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(48, 16);
            this.labelControl6.TabIndex = 30;
            this.labelControl6.Text = "Vercek :";
            // 
            // textGive
            // 
            this.textGive.EditValue = "0";
            this.textGive.Location = new System.Drawing.Point(84, 457);
            this.textGive.Name = "textGive";
            this.textGive.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.textGive.Properties.Appearance.Options.UseFont = true;
            this.textGive.Properties.BeepOnError = false;
            this.textGive.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.textGive.Properties.MaskSettings.Set("mask", "c");
            this.textGive.Size = new System.Drawing.Size(276, 26);
            this.textGive.TabIndex = 29;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(17, 417);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(50, 16);
            this.labelControl5.TabIndex = 28;
            this.labelControl5.Text = "Alacak : ";
            // 
            // textReceive
            // 
            this.textReceive.EditValue = "0";
            this.textReceive.Location = new System.Drawing.Point(84, 411);
            this.textReceive.Name = "textReceive";
            this.textReceive.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.textReceive.Properties.Appearance.Options.UseFont = true;
            this.textReceive.Properties.BeepOnError = false;
            this.textReceive.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.textReceive.Properties.MaskSettings.Set("mask", "c");
            this.textReceive.Size = new System.Drawing.Size(276, 26);
            this.textReceive.TabIndex = 27;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(17, 370);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(43, 16);
            this.labelControl4.TabIndex = 26;
            this.labelControl4.Text = "Tarih : ";
            // 
            // dateDebtDate
            // 
            this.dateDebtDate.EditValue = null;
            this.dateDebtDate.Location = new System.Drawing.Point(84, 364);
            this.dateDebtDate.Name = "dateDebtDate";
            this.dateDebtDate.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.dateDebtDate.Properties.Appearance.Options.UseFont = true;
            this.dateDebtDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateDebtDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateDebtDate.Size = new System.Drawing.Size(276, 26);
            this.dateDebtDate.TabIndex = 25;
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
            this.groupControl1.Location = new System.Drawing.Point(12, 164);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(353, 177);
            this.groupControl1.TabIndex = 24;
            this.groupControl1.Text = "Müşteri";
            // 
            // buttonSelectReferance
            // 
            this.buttonSelectReferance.Location = new System.Drawing.Point(162, 29);
            this.buttonSelectReferance.Name = "buttonSelectReferance";
            this.buttonSelectReferance.Size = new System.Drawing.Size(30, 23);
            this.buttonSelectReferance.TabIndex = 16;
            this.buttonSelectReferance.Text = "Seç";
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
            // EditDebtForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(378, 621);
            this.Controls.Add(this.textComment);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.textGive);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.textReceive);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.dateDebtDate);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.mainRibbonControl);
            this.MaximizeBox = false;
            this.Name = "EditDebtForm";
            this.Ribbon = this.mainRibbonControl;
            this.Load += new System.EventHandler(this.EditDebtForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mainRibbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textGive.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textReceive.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateDebtDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateDebtDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textCustomerID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textCustomerPhoneNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textCustomerName.Properties)).EndInit();
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
        private DevExpress.XtraBars.BarButtonItem bbiDelete;
        private DevExpress.XtraBars.BarButtonItem bbiClose;
        private System.Windows.Forms.TextBox textComment;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit textGive;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit textReceive;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.DateEdit dateDebtDate;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton buttonSelectReferance;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit textCustomerID;
        private DevExpress.XtraEditors.TextEdit textCustomerPhoneNumber;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit textCustomerName;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}