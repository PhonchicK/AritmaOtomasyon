
namespace FormUI.Views.SaleForms
{
    partial class EditSaleForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditSaleForm));
            this.mainRibbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bbiSave = new DevExpress.XtraBars.BarButtonItem();
            this.bbiSaveAndClose = new DevExpress.XtraBars.BarButtonItem();
            this.bbiReset = new DevExpress.XtraBars.BarButtonItem();
            this.bbiDelete = new DevExpress.XtraBars.BarButtonItem();
            this.bbiClose = new DevExpress.XtraBars.BarButtonItem();
            this.mainRibbonPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.mainRibbonPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.labelCustomerID = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.textCustomerPhone = new DevExpress.XtraEditors.TextEdit();
            this.textCustomerName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.textComment = new System.Windows.Forms.RichTextBox();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.separatorControl1 = new DevExpress.XtraEditors.SeparatorControl();
            this.textAssembler = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.buttonSelectProduct = new DevExpress.XtraEditors.SimpleButton();
            this.labelProductID = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.textProductName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.tileNavPane1 = new DevExpress.XtraBars.Navigation.TileNavPane();
            this.navButton3 = new DevExpress.XtraBars.Navigation.NavButton();
            this.navButton4 = new DevExpress.XtraBars.Navigation.NavButton();
            this.navButton5 = new DevExpress.XtraBars.Navigation.NavButton();
            ((System.ComponentModel.ISupportInitialize)(this.mainRibbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textCustomerPhone.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textCustomerName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textAssembler.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textProductName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileNavPane1)).BeginInit();
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
            this.mainRibbonControl.Size = new System.Drawing.Size(710, 158);
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
            this.groupControl1.Location = new System.Drawing.Point(12, 164);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(246, 179);
            this.groupControl1.TabIndex = 16;
            this.groupControl1.Text = "Müşteri";
            // 
            // labelCustomerID
            // 
            this.labelCustomerID.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelCustomerID.Appearance.Options.UseFont = true;
            this.labelCustomerID.Location = new System.Drawing.Point(41, 35);
            this.labelCustomerID.Name = "labelCustomerID";
            this.labelCustomerID.Size = new System.Drawing.Size(9, 19);
            this.labelCustomerID.TabIndex = 17;
            this.labelCustomerID.Text = "0";
            this.labelCustomerID.TextChanged += new System.EventHandler(this.labelCustomerID_TextChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(7, 35);
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
            this.textCustomerPhone.Properties.BeepOnError = false;
            this.textCustomerPhone.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.RegularMaskManager));
            this.textCustomerPhone.Properties.MaskSettings.Set("mask", "(\\d?\\d?\\d?) \\d\\d\\d-\\d\\d\\d\\d");
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
            this.groupControl2.Controls.Add(this.textComment);
            this.groupControl2.Controls.Add(this.labelControl8);
            this.groupControl2.Controls.Add(this.separatorControl1);
            this.groupControl2.Controls.Add(this.textAssembler);
            this.groupControl2.Controls.Add(this.labelControl6);
            this.groupControl2.Controls.Add(this.buttonSelectProduct);
            this.groupControl2.Controls.Add(this.labelProductID);
            this.groupControl2.Controls.Add(this.labelControl5);
            this.groupControl2.Controls.Add(this.textProductName);
            this.groupControl2.Controls.Add(this.labelControl7);
            this.groupControl2.Location = new System.Drawing.Point(12, 349);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(686, 188);
            this.groupControl2.TabIndex = 19;
            this.groupControl2.Text = "Ürün";
            // 
            // textComment
            // 
            this.textComment.Font = new System.Drawing.Font("Tahoma", 10F);
            this.textComment.Location = new System.Drawing.Point(286, 99);
            this.textComment.Name = "textComment";
            this.textComment.Size = new System.Drawing.Size(380, 84);
            this.textComment.TabIndex = 23;
            this.textComment.Text = "";
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(286, 79);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(48, 13);
            this.labelControl8.TabIndex = 22;
            this.labelControl8.Text = "Açıklama :";
            // 
            // separatorControl1
            // 
            this.separatorControl1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.separatorControl1.LineOrientation = System.Windows.Forms.Orientation.Vertical;
            this.separatorControl1.Location = new System.Drawing.Point(247, 26);
            this.separatorControl1.Name = "separatorControl1";
            this.separatorControl1.Size = new System.Drawing.Size(19, 157);
            this.separatorControl1.TabIndex = 21;
            // 
            // textAssembler
            // 
            this.textAssembler.Location = new System.Drawing.Point(283, 47);
            this.textAssembler.Name = "textAssembler";
            this.textAssembler.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.textAssembler.Properties.Appearance.Options.UseFont = true;
            this.textAssembler.Size = new System.Drawing.Size(383, 26);
            this.textAssembler.TabIndex = 20;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(286, 28);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(73, 13);
            this.labelControl6.TabIndex = 19;
            this.labelControl6.Text = "Montaj Yapan :";
            // 
            // buttonSelectProduct
            // 
            this.buttonSelectProduct.Location = new System.Drawing.Point(67, 35);
            this.buttonSelectProduct.Name = "buttonSelectProduct";
            this.buttonSelectProduct.Size = new System.Drawing.Size(75, 23);
            this.buttonSelectProduct.TabIndex = 18;
            this.buttonSelectProduct.Text = "Seç";
            this.buttonSelectProduct.Click += new System.EventHandler(this.buttonSelectProduct_Click);
            // 
            // labelProductID
            // 
            this.labelProductID.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelProductID.Appearance.Options.UseFont = true;
            this.labelProductID.Location = new System.Drawing.Point(41, 35);
            this.labelProductID.Name = "labelProductID";
            this.labelProductID.Size = new System.Drawing.Size(9, 19);
            this.labelProductID.TabIndex = 17;
            this.labelProductID.Text = "0";
            this.labelProductID.TextChanged += new System.EventHandler(this.labelProductID_TextChanged);
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(7, 35);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(28, 19);
            this.labelControl5.TabIndex = 11;
            this.labelControl5.Text = "İD :";
            // 
            // textProductName
            // 
            this.textProductName.Location = new System.Drawing.Point(5, 112);
            this.textProductName.Name = "textProductName";
            this.textProductName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.textProductName.Properties.Appearance.Options.UseFont = true;
            this.textProductName.Properties.ReadOnly = true;
            this.textProductName.Size = new System.Drawing.Size(237, 26);
            this.textProductName.TabIndex = 15;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(8, 93);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(22, 13);
            this.labelControl7.TabIndex = 13;
            this.labelControl7.Text = "Adı :";
            // 
            // groupControl3
            // 
            this.groupControl3.AppearanceCaption.BorderColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary;
            this.groupControl3.AppearanceCaption.Options.UseBorderColor = true;
            this.groupControl3.Location = new System.Drawing.Point(264, 164);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(434, 179);
            this.groupControl3.TabIndex = 19;
            this.groupControl3.Text = "Ödeme";
            // 
            // tileNavPane1
            // 
            this.tileNavPane1.Buttons.Add(this.navButton3);
            this.tileNavPane1.Buttons.Add(this.navButton4);
            this.tileNavPane1.Buttons.Add(this.navButton5);
            this.tileNavPane1.Cursor = System.Windows.Forms.Cursors.Default;
            // 
            // tileNavCategory1
            // 
            this.tileNavPane1.DefaultCategory.Name = "tileNavCategory1";
            // 
            // 
            // 
            this.tileNavPane1.DefaultCategory.Tile.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            this.tileNavPane1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tileNavPane1.Location = new System.Drawing.Point(0, 546);
            this.tileNavPane1.Name = "tileNavPane1";
            this.tileNavPane1.Size = new System.Drawing.Size(710, 53);
            this.tileNavPane1.TabIndex = 21;
            this.tileNavPane1.Text = "tileNavPane1";
            // 
            // navButton3
            // 
            this.navButton3.Alignment = DevExpress.XtraBars.Navigation.NavButtonAlignment.Left;
            this.navButton3.Caption = "Bakımlar";
            this.navButton3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("navButton3.ImageOptions.Image")));
            this.navButton3.Name = "navButton3";
            this.navButton3.ElementClick += new DevExpress.XtraBars.Navigation.NavElementClickEventHandler(this.navButton3_ElementClick);
            // 
            // navButton4
            // 
            this.navButton4.Alignment = DevExpress.XtraBars.Navigation.NavButtonAlignment.Left;
            this.navButton4.Caption = "Yapılan Bakımlar";
            this.navButton4.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("navButton4.ImageOptions.Image")));
            this.navButton4.Name = "navButton4";
            this.navButton4.ElementClick += new DevExpress.XtraBars.Navigation.NavElementClickEventHandler(this.navButton4_ElementClick);
            // 
            // navButton5
            // 
            this.navButton5.Alignment = DevExpress.XtraBars.Navigation.NavButtonAlignment.Left;
            this.navButton5.Caption = "Taksitler";
            this.navButton5.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("navButton5.ImageOptions.Image")));
            this.navButton5.Name = "navButton5";
            this.navButton5.ElementClick += new DevExpress.XtraBars.Navigation.NavElementClickEventHandler(this.navButton5_ElementClick);
            // 
            // EditSaleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(710, 599);
            this.Controls.Add(this.tileNavPane1);
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.mainRibbonControl);
            this.MaximizeBox = false;
            this.Name = "EditSaleForm";
            this.Ribbon = this.mainRibbonControl;
            this.Load += new System.EventHandler(this.EditSaleForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mainRibbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textCustomerPhone.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textCustomerName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textAssembler.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textProductName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileNavPane1)).EndInit();
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
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelCustomerID;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit textCustomerPhone;
        private DevExpress.XtraEditors.TextEdit textCustomerName;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.SimpleButton buttonSelectProduct;
        private DevExpress.XtraEditors.LabelControl labelProductID;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit textProductName;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private System.Windows.Forms.RichTextBox textComment;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.SeparatorControl separatorControl1;
        private DevExpress.XtraEditors.TextEdit textAssembler;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraBars.Navigation.TileNavPane tileNavPane1;
        private DevExpress.XtraBars.Navigation.NavButton navButton3;
        private DevExpress.XtraBars.Navigation.NavButton navButton4;
        private DevExpress.XtraBars.Navigation.NavButton navButton5;
    }
}