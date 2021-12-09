using Business.DependencyResolvers.Ninject;
using Bussiness.Abstract;
using DevExpress.XtraEditors;
using DevExpress.XtraLayout;
using DevExpress.XtraLayout.Helpers;
using Entities.Concrete;
using IHYAOtomasyon.Views.ProductForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormUI.Views.ProductForms
{
    public partial class EditProductForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        Product selectedProduct;
        IProductService productService;
        public EditProductForm(int productID)
        {
            InitializeComponent();
            productService = InstanceFactory.GetInstance<IProductService>();
            selectedProduct = productService.GetByID(productID);
        }

        private void EditProductForm_Load(object sender, EventArgs e)
        {
            textProductName.Text = selectedProduct.Name;
            textFeatures.Text = selectedProduct.Features;
            textPrice.Text = selectedProduct.DefaultPrice.ToString();
        }

        private void bbiSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            textFeatures.Focus();
            selectedProduct.Name = textProductName.Text;
            selectedProduct.Features = textFeatures.Text;
            selectedProduct.DefaultPrice = int.Parse(textPrice.Text);
            productService.Update(selectedProduct);
        }

        private void bbiSaveAndClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            textFeatures.Focus();
            selectedProduct.Name = textProductName.Text;
            selectedProduct.Features = textFeatures.Text;
            selectedProduct.DefaultPrice = int.Parse(textPrice.Text);
            productService.Update(selectedProduct);
            this.DialogResult = DialogResult.OK;
        }

        private void bbiReset_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            textProductName.Text = selectedProduct.Name;
            textFeatures.Text = selectedProduct.Features;
            textPrice.Text = selectedProduct.DefaultPrice.ToString();
        }

        private void bbiDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bu ürünü silmek istediğinize emin misiniz ? " , "Uyarı!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                productService.Delete(selectedProduct);
                this.DialogResult = DialogResult.OK;
            }
        }

        private void bbiClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new AddStockForm(selectedProduct.ID).ShowDialog();
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new StockInForm(selectedProduct.ID).Show();
        }
    }
}