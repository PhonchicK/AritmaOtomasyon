
namespace FormUI.Views.CustomerForms
{
    partial class EditCustomerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditCustomerForm));
            this.mainRibbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bbiSave = new DevExpress.XtraBars.BarButtonItem();
            this.bbiSaveAndClose = new DevExpress.XtraBars.BarButtonItem();
            this.bbiSaveAndNew = new DevExpress.XtraBars.BarButtonItem();
            this.bbiReset = new DevExpress.XtraBars.BarButtonItem();
            this.bbiDelete = new DevExpress.XtraBars.BarButtonItem();
            this.bbiClose = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.mainRibbonPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.mainRibbonPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.textCustomerAddress = new System.Windows.Forms.TextBox();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.textCustomerPhoneNumber = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.textCustomerName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.textReferancePrice = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.buttonSelectReferance = new DevExpress.XtraEditors.SimpleButton();
            this.textReferanceID = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.textReferancePhoneNumber = new DevExpress.XtraEditors.TextEdit();
            this.textReferanceName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.listBoxReferancedCustomers = new DevExpress.XtraEditors.ListBoxControl();
            this.tileNavPane1 = new DevExpress.XtraBars.Navigation.TileNavPane();
            this.navButton2 = new DevExpress.XtraBars.Navigation.NavButton();
            this.navButton3 = new DevExpress.XtraBars.Navigation.NavButton();
            this.navButton4 = new DevExpress.XtraBars.Navigation.NavButton();
            this.navButton5 = new DevExpress.XtraBars.Navigation.NavButton();
            this.navButton6 = new DevExpress.XtraBars.Navigation.NavButton();
            this.listBoxReferancePrices = new DevExpress.XtraEditors.ListBoxControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelTotalReferancePrice = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.mainRibbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textCustomerPhoneNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textCustomerName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textReferancePrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textReferanceID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textReferancePhoneNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textReferanceName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxReferancedCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileNavPane1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxReferancePrices)).BeginInit();
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
            this.bbiSaveAndNew,
            this.bbiReset,
            this.bbiDelete,
            this.bbiClose,
            this.barButtonItem1});
            this.mainRibbonControl.Location = new System.Drawing.Point(0, 0);
            this.mainRibbonControl.MaxItemId = 11;
            this.mainRibbonControl.Name = "mainRibbonControl";
            this.mainRibbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.mainRibbonPage});
            this.mainRibbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            this.mainRibbonControl.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.mainRibbonControl.Size = new System.Drawing.Size(798, 158);
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
            this.bbiSaveAndClose.Caption = "Kaydet Ve Kapat";
            this.bbiSaveAndClose.Id = 3;
            this.bbiSaveAndClose.ImageOptions.ImageUri.Uri = "SaveAndClose";
            this.bbiSaveAndClose.Name = "bbiSaveAndClose";
            this.bbiSaveAndClose.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiSaveAndClose_ItemClick);
            // 
            // bbiSaveAndNew
            // 
            this.bbiSaveAndNew.Caption = "Save And New";
            this.bbiSaveAndNew.Id = 4;
            this.bbiSaveAndNew.ImageOptions.ImageUri.Uri = "SaveAndNew";
            this.bbiSaveAndNew.Name = "bbiSaveAndNew";
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
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Yeni Alacak / Verecek";
            this.barButtonItem1.Id = 10;
            this.barButtonItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
            this.barButtonItem1.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.LargeImage")));
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // mainRibbonPage
            // 
            this.mainRibbonPage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.mainRibbonPageGroup,
            this.ribbonPageGroup1});
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
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem1);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Hızlı Menü";
            // 
            // groupControl1
            // 
            this.groupControl1.Appearance.BorderColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary;
            this.groupControl1.Appearance.Options.UseBorderColor = true;
            this.groupControl1.Controls.Add(this.textCustomerAddress);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.textCustomerPhoneNumber);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.textCustomerName);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(12, 164);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(353, 239);
            this.groupControl1.TabIndex = 2;
            this.groupControl1.Text = "Müşteri";
            // 
            // textCustomerAddress
            // 
            this.textCustomerAddress.Font = new System.Drawing.Font("Tahoma", 12F);
            this.textCustomerAddress.Location = new System.Drawing.Point(5, 130);
            this.textCustomerAddress.Multiline = true;
            this.textCustomerAddress.Name = "textCustomerAddress";
            this.textCustomerAddress.Size = new System.Drawing.Size(343, 104);
            this.textCustomerAddress.TabIndex = 3;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(5, 108);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(42, 16);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Adres :";
            // 
            // textCustomerPhoneNumber
            // 
            this.textCustomerPhoneNumber.Location = new System.Drawing.Point(5, 76);
            this.textCustomerPhoneNumber.MenuManager = this.mainRibbonControl;
            this.textCustomerPhoneNumber.Name = "textCustomerPhoneNumber";
            this.textCustomerPhoneNumber.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.textCustomerPhoneNumber.Properties.Appearance.Options.UseFont = true;
            this.textCustomerPhoneNumber.Properties.BeepOnError = false;
            this.textCustomerPhoneNumber.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.RegularMaskManager));
            this.textCustomerPhoneNumber.Properties.MaskSettings.Set("mask", "(\\d?\\d?\\d?) \\d\\d\\d-\\d\\d\\d\\d");
            this.textCustomerPhoneNumber.Size = new System.Drawing.Size(343, 26);
            this.textCustomerPhoneNumber.TabIndex = 2;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(5, 54);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(110, 16);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Telefon Numarası :";
            // 
            // textCustomerName
            // 
            this.textCustomerName.Location = new System.Drawing.Point(46, 23);
            this.textCustomerName.MenuManager = this.mainRibbonControl;
            this.textCustomerName.Name = "textCustomerName";
            this.textCustomerName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.textCustomerName.Properties.Appearance.Options.UseFont = true;
            this.textCustomerName.Size = new System.Drawing.Size(302, 26);
            this.textCustomerName.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(5, 28);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(35, 16);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Adı* :";
            // 
            // groupControl2
            // 
            this.groupControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl2.Appearance.BorderColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary;
            this.groupControl2.Appearance.Options.UseBorderColor = true;
            this.groupControl2.Controls.Add(this.textReferancePrice);
            this.groupControl2.Controls.Add(this.labelControl4);
            this.groupControl2.Controls.Add(this.simpleButton1);
            this.groupControl2.Controls.Add(this.buttonSelectReferance);
            this.groupControl2.Controls.Add(this.textReferanceID);
            this.groupControl2.Controls.Add(this.labelControl7);
            this.groupControl2.Controls.Add(this.labelControl6);
            this.groupControl2.Controls.Add(this.textReferancePhoneNumber);
            this.groupControl2.Controls.Add(this.textReferanceName);
            this.groupControl2.Controls.Add(this.labelControl5);
            this.groupControl2.Location = new System.Drawing.Point(417, 164);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(353, 239);
            this.groupControl2.TabIndex = 3;
            this.groupControl2.Text = "Referans";
            // 
            // textReferancePrice
            // 
            this.textReferancePrice.Location = new System.Drawing.Point(83, 201);
            this.textReferancePrice.MenuManager = this.mainRibbonControl;
            this.textReferancePrice.Name = "textReferancePrice";
            this.textReferancePrice.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.textReferancePrice.Properties.Appearance.Options.UseFont = true;
            this.textReferancePrice.Properties.BeepOnError = false;
            this.textReferancePrice.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.textReferancePrice.Properties.MaskSettings.Set("MaskManagerSignature", "allowNull=False");
            this.textReferancePrice.Properties.MaskSettings.Set("mask", "c");
            this.textReferancePrice.Properties.ReadOnly = true;
            this.textReferancePrice.Size = new System.Drawing.Size(260, 26);
            this.textReferancePrice.TabIndex = 17;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(5, 207);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(72, 16);
            this.labelControl4.TabIndex = 16;
            this.labelControl4.Text = "Prim Ücreti :";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(164, 34);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(30, 23);
            this.simpleButton1.TabIndex = 5;
            this.simpleButton1.Text = "Sil";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // buttonSelectReferance
            // 
            this.buttonSelectReferance.Location = new System.Drawing.Point(128, 34);
            this.buttonSelectReferance.Name = "buttonSelectReferance";
            this.buttonSelectReferance.Size = new System.Drawing.Size(30, 23);
            this.buttonSelectReferance.TabIndex = 4;
            this.buttonSelectReferance.Text = "Seç";
            this.buttonSelectReferance.Click += new System.EventHandler(this.buttonSelectReferance_Click);
            // 
            // textReferanceID
            // 
            this.textReferanceID.Location = new System.Drawing.Point(38, 32);
            this.textReferanceID.MenuManager = this.mainRibbonControl;
            this.textReferanceID.Name = "textReferanceID";
            this.textReferanceID.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.textReferanceID.Properties.Appearance.Options.UseFont = true;
            this.textReferanceID.Properties.ReadOnly = true;
            this.textReferanceID.Size = new System.Drawing.Size(87, 26);
            this.textReferanceID.TabIndex = 13;
            this.textReferanceID.EditValueChanged += new System.EventHandler(this.textReferanceID_EditValueChanged);
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(5, 38);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(25, 16);
            this.labelControl7.TabIndex = 12;
            this.labelControl7.Text = "İD : ";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(5, 76);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(27, 16);
            this.labelControl6.TabIndex = 6;
            this.labelControl6.Text = "Adı :";
            // 
            // textReferancePhoneNumber
            // 
            this.textReferancePhoneNumber.Location = new System.Drawing.Point(5, 161);
            this.textReferancePhoneNumber.MenuManager = this.mainRibbonControl;
            this.textReferancePhoneNumber.Name = "textReferancePhoneNumber";
            this.textReferancePhoneNumber.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.textReferancePhoneNumber.Properties.Appearance.Options.UseFont = true;
            this.textReferancePhoneNumber.Properties.BeepOnError = false;
            this.textReferancePhoneNumber.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.RegularMaskManager));
            this.textReferancePhoneNumber.Properties.MaskSettings.Set("mask", "(\\d?\\d?\\d?) \\d\\d\\d-\\d\\d\\d\\d");
            this.textReferancePhoneNumber.Properties.ReadOnly = true;
            this.textReferancePhoneNumber.Size = new System.Drawing.Size(338, 26);
            this.textReferancePhoneNumber.TabIndex = 9;
            // 
            // textReferanceName
            // 
            this.textReferanceName.Location = new System.Drawing.Point(5, 98);
            this.textReferanceName.MenuManager = this.mainRibbonControl;
            this.textReferanceName.Name = "textReferanceName";
            this.textReferanceName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.textReferanceName.Properties.Appearance.Options.UseFont = true;
            this.textReferanceName.Properties.ReadOnly = true;
            this.textReferanceName.Size = new System.Drawing.Size(338, 26);
            this.textReferanceName.TabIndex = 7;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(5, 136);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(110, 16);
            this.labelControl5.TabIndex = 8;
            this.labelControl5.Text = "Telefon Numarası :";
            // 
            // listBoxReferancedCustomers
            // 
            this.listBoxReferancedCustomers.Location = new System.Drawing.Point(12, 413);
            this.listBoxReferancedCustomers.Name = "listBoxReferancedCustomers";
            this.listBoxReferancedCustomers.Size = new System.Drawing.Size(353, 96);
            this.listBoxReferancedCustomers.TabIndex = 4;
            // 
            // tileNavPane1
            // 
            this.tileNavPane1.Buttons.Add(this.navButton2);
            this.tileNavPane1.Buttons.Add(this.navButton3);
            this.tileNavPane1.Buttons.Add(this.navButton4);
            this.tileNavPane1.Buttons.Add(this.navButton5);
            this.tileNavPane1.Buttons.Add(this.navButton6);
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
            this.tileNavPane1.Size = new System.Drawing.Size(798, 53);
            this.tileNavPane1.TabIndex = 7;
            this.tileNavPane1.Text = "tileNavPane1";
            // 
            // navButton2
            // 
            this.navButton2.Alignment = DevExpress.XtraBars.Navigation.NavButtonAlignment.Left;
            this.navButton2.Caption = "Satışlar";
            this.navButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("navButton2.ImageOptions.Image")));
            this.navButton2.Name = "navButton2";
            this.navButton2.ElementClick += new DevExpress.XtraBars.Navigation.NavElementClickEventHandler(this.navButton2_ElementClick);
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
            // navButton6
            // 
            this.navButton6.Alignment = DevExpress.XtraBars.Navigation.NavButtonAlignment.Left;
            this.navButton6.Caption = "Alacak/Verecek";
            this.navButton6.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("navButton6.ImageOptions.Image")));
            this.navButton6.Name = "navButton6";
            this.navButton6.ElementClick += new DevExpress.XtraBars.Navigation.NavElementClickEventHandler(this.navButton6_ElementClick);
            // 
            // listBoxReferancePrices
            // 
            this.listBoxReferancePrices.Location = new System.Drawing.Point(417, 413);
            this.listBoxReferancePrices.Name = "listBoxReferancePrices";
            this.listBoxReferancePrices.Size = new System.Drawing.Size(353, 96);
            this.listBoxReferancePrices.TabIndex = 5;
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(417, 515);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(212, 16);
            this.labelControl8.TabIndex = 6;
            this.labelControl8.Text = "Referanslardan Aldığı Toplam Ücret :";
            // 
            // labelTotalReferancePrice
            // 
            this.labelTotalReferancePrice.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelTotalReferancePrice.Appearance.Options.UseFont = true;
            this.labelTotalReferancePrice.Location = new System.Drawing.Point(635, 515);
            this.labelTotalReferancePrice.Name = "labelTotalReferancePrice";
            this.labelTotalReferancePrice.Size = new System.Drawing.Size(7, 16);
            this.labelTotalReferancePrice.TabIndex = 9;
            this.labelTotalReferancePrice.Text = "0";
            // 
            // EditCustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(798, 599);
            this.Controls.Add(this.labelTotalReferancePrice);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.tileNavPane1);
            this.Controls.Add(this.listBoxReferancePrices);
            this.Controls.Add(this.listBoxReferancedCustomers);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.mainRibbonControl);
            this.MaximizeBox = false;
            this.Name = "EditCustomerForm";
            this.Ribbon = this.mainRibbonControl;
            this.Load += new System.EventHandler(this.EditCustomerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mainRibbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textCustomerPhoneNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textCustomerName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textReferancePrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textReferanceID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textReferancePhoneNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textReferanceName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxReferancedCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileNavPane1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxReferancePrices)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.Ribbon.RibbonControl mainRibbonControl;
        private DevExpress.XtraBars.Ribbon.RibbonPage mainRibbonPage;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup mainRibbonPageGroup;
        private DevExpress.XtraBars.BarButtonItem bbiSave;
        private DevExpress.XtraBars.BarButtonItem bbiSaveAndClose;
        private DevExpress.XtraBars.BarButtonItem bbiSaveAndNew;
        private DevExpress.XtraBars.BarButtonItem bbiReset;
        private DevExpress.XtraBars.BarButtonItem bbiDelete;
        private DevExpress.XtraBars.BarButtonItem bbiClose;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private System.Windows.Forms.TextBox textCustomerAddress;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit textCustomerPhoneNumber;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit textCustomerName;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton buttonSelectReferance;
        private DevExpress.XtraEditors.TextEdit textReferanceID;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit textReferancePhoneNumber;
        private DevExpress.XtraEditors.TextEdit textReferanceName;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.ListBoxControl listBoxReferancedCustomers;
        private DevExpress.XtraBars.Navigation.TileNavPane tileNavPane1;
        private DevExpress.XtraBars.Navigation.NavButton navButton2;
        private DevExpress.XtraBars.Navigation.NavButton navButton3;
        private DevExpress.XtraBars.Navigation.NavButton navButton4;
        private DevExpress.XtraBars.Navigation.NavButton navButton5;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraEditors.ListBoxControl listBoxReferancePrices;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.TextEdit textReferancePrice;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelTotalReferancePrice;
        private DevExpress.XtraBars.Navigation.NavButton navButton6;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
    }
}