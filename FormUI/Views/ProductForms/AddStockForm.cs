using Business.DependencyResolvers.Ninject;
using Bussiness.Abstract;
using Entities.Concrete;
using FormUI.Views.ProductForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IHYAOtomasyon.Views.ProductForms
{
    public partial class AddStockForm : DevExpress.XtraEditors.XtraForm
    {
        IProductService productService;
        IStockInService stockInService;
        private void LoadServices()
        {
            productService = InstanceFactory.GetInstance<IProductService>();
            stockInService = InstanceFactory.GetInstance<IStockInService>();
        }
        public AddStockForm()
        {
            InitializeComponent();
            LoadServices();
        }
        public AddStockForm(int productID)
        {
            InitializeComponent();
            LoadServices();
            textProductID.Text = productID.ToString();
        }

        private void navButton1_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textProductID.Text) || string.IsNullOrEmpty(textCount.Text))
            {
                return;
            }
            stockInService.Add(new StockIn()
            {
                ProductID = int.Parse(textProductID.Text),
                Count = int.Parse(textCount.Text),
                WhoPurchase = textWhoPurchase.Text
            });
            this.DialogResult = DialogResult.OK;
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
                textProductFeatures.Text = product.Features;
            }
        }

        private void navButton3_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        SelectProductForm selectProductForm;
        private void buttonSelectReferance_Click(object sender, EventArgs e)
        {
            selectProductForm = new SelectProductForm();
            if(selectProductForm.ShowDialog() == DialogResult.OK)
            {
                textProductID.Text = selectProductForm.SelectedProductID.ToString();
            }
        }
    }
}
