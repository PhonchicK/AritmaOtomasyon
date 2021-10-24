using Business.DependencyResolvers.Ninject;
using Bussiness.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormUI.Views.ProductForms
{
    public partial class NewProductForm : DevExpress.XtraEditors.XtraForm
    {
        IProductService productService;
        public NewProductForm()
        {
            InitializeComponent();
            productService = InstanceFactory.GetInstance<IProductService>();
        }

        private void navButton1_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            textFeatures.Focus();
            if (string.IsNullOrWhiteSpace(textProductName.Text))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun");
                return;
            }
            productService.Add(new Product()
            {
                Name = textProductName.Text,
                Features = textFeatures.Text,
                DefaultPrice = string.IsNullOrWhiteSpace(textPrice.Text) ? 0 : Convert.ToInt32(textPrice.Text)
            });
            this.DialogResult = DialogResult.OK;
        }

        private void navButton3_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
