using Business.DependencyResolvers.Ninject;
using Bussiness.Abstract;
using DevExpress.XtraEditors;
using DevExpress.XtraLayout;
using DevExpress.XtraLayout.Helpers;
using Entities.Concrete;
using FormUI.Views.ProductForms;
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

namespace IHYAOtomasyon.Views.ProductForms
{
    public partial class EditStockIn : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        StockIn selectedStockIn;
        IProductService productService;
        IStockInService stockInService;
        private void LoadServices()
        {
            productService = InstanceFactory.GetInstance<IProductService>();
            stockInService = InstanceFactory.GetInstance<IStockInService>();
        }
        public EditStockIn(int stockInID)
        {
            InitializeComponent();
            LoadServices();
            selectedStockIn = stockInService.Get(stockInID);
        }

        private void textProductID_EditValueChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textProductID.Text))
            {
                textProductName.Text = null;
            }
            else
            {
                Product product = productService.GetByID(int.Parse(textProductID.Text));
                textProductName.Text = product.Name;
            }
        }
        private void LoadTexts()
        {
            textProductID.Text = selectedStockIn.ProductID.ToString();
            textCount.Text = selectedStockIn.Count.ToString();
            textWhoPurchase.Text = selectedStockIn.WhoPurchase;
        }

        private void EditStockIn_Load(object sender, EventArgs e)
        {
            LoadTexts();
        }

        private void bbiReset_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoadTexts();
        }

        private void bbiSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            selectedStockIn.ProductID = int.Parse(textProductID.Text);
            selectedStockIn.Count = int.Parse(textCount.Text);
            selectedStockIn.WhoPurchase = textWhoPurchase.Text;

            stockInService.Update(selectedStockIn);
        }

        private void bbiSaveAndClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            selectedStockIn.ProductID = int.Parse(textProductID.Text);
            selectedStockIn.Count = int.Parse(textCount.Text);
            selectedStockIn.WhoPurchase = textWhoPurchase.Text;

            stockInService.Update(selectedStockIn);
            this.DialogResult = DialogResult.OK;
        }

        private void bbiClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void bbiDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bu stok girişini silmek istediğinize emin misiniz ? ", "Uyarı", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                stockInService.Delete(selectedStockIn);
                this.DialogResult = DialogResult.OK;
            }
        }
        SelectProductForm selectProductForm;
        private void buttonSelectReferance_Click(object sender, EventArgs e)
        {
            selectProductForm = new SelectProductForm();
            if (selectProductForm.ShowDialog() == DialogResult.OK)
            {
                textProductID.Text = selectProductForm.SelectedProductID.ToString();
            }
        }
    }
}