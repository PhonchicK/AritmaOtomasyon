using Business.DependencyResolvers.Ninject;
using Bussiness.Abstract;
using DevExpress.XtraEditors;
using DevExpress.XtraLayout;
using DevExpress.XtraLayout.Helpers;
using Entities.Concrete;
using FormUI.Views.CustomerForms;
using FormUI.Views.InstalmentForms;
using FormUI.Views.MaintenanceForms;
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

namespace FormUI.Views.SaleForms
{
    public partial class EditSaleForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        Sale selectedSale;
        ICustomerService customerService;
        ISaleService saleService;
        IInstalmentService instalmentService;
        IMaintenanceBaseService maintenanceBaseService;
        IMaintenanceService maintenanceService;
        IProductService productService;
        public EditSaleForm(int saleID)
        {
            InitializeComponent();
            customerService = InstanceFactory.GetInstance<ICustomerService>();
            saleService = InstanceFactory.GetInstance<ISaleService>();
            instalmentService = InstanceFactory.GetInstance<IInstalmentService>();
            maintenanceBaseService = InstanceFactory.GetInstance<IMaintenanceBaseService>();
            maintenanceService = InstanceFactory.GetInstance<IMaintenanceService>();
            productService = InstanceFactory.GetInstance<IProductService>();
            selectedSale = saleService.GetByID(saleID);
        }

        private void labelCustomerID_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(labelCustomerID.Text))
            {
                textCustomerName.Text = null;
                textCustomerPhone.Text = null;
            }
            else
            {
                Customer referance = customerService.GetByID(int.Parse(labelCustomerID.Text));
                textCustomerName.Text = referance.Name;
                textCustomerPhone.Text = referance.PhoneNumber;
            }
        }
        SelectCustomerForm selectCustomerForm;
        SelectProductForm selectProductForm;
        private void buttonSelectProduct_Click(object sender, EventArgs e)
        {
            selectProductForm = new SelectProductForm();
            if (selectProductForm.ShowDialog() == DialogResult.OK)
            {
                labelProductID.Text = selectProductForm.SelectedProductID.ToString();
            }
        }

        private void labelProductID_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(labelProductID.Text))
            {
                textProductName.Text = null;
            }
            else
            {
                Product product = productService.GetByID(int.Parse(labelProductID.Text));
                textProductName.Text = product.Name;
            }
        }

        private void EditSaleForm_Load(object sender, EventArgs e)
        {
            labelCustomerID.Text = selectedSale.CustomerID.ToString();
            labelProductID.Text = selectedSale.ProductID.ToString();

            textAssembler.Text = selectedSale.Assembler;
            textComment.Text = selectedSale.Comment;
        }

        private void navButton3_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            if (maintenanceBaseService.GetSaleDetails(selectedSale.ID).Count < 1)
            {
                MessageBox.Show("Satışa ait bakım kaydı bulunamadı.");
                return;
            }
            new MaintenancesForm("sale", selectedSale.ID).ShowDialog();
        }

        private void navButton4_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            if (maintenanceService.GetBySaleID(selectedSale.ID).Count < 1)
            {
                MessageBox.Show("Satışa ait yapılan bakım kaydı bulunamadı.");
                return;
            }
            new DoneMaintenancesForm("sale", selectedSale.ID).ShowDialog();
        }

        private void navButton5_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            if (instalmentService.GetSaleInstalmentsDetails(selectedSale.ID).Count < 1)
            {
                MessageBox.Show("Satışa ait taksit kaydı bulunamadı.");
                return;
            }
            new InstalmentForm("sale", selectedSale.ID).ShowDialog();
        }

        private void bbiClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void bbiDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Seçili satışı silmek istediğinize emin misiniz ? ", "Uyarı!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                saleService.Delete(selectedSale);
                this.DialogResult = DialogResult.OK;
            }
        }

        private void bbiReset_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            labelCustomerID.Text = selectedSale.CustomerID.ToString();
            labelProductID.Text = selectedSale.ProductID.ToString();

            textAssembler.Text = selectedSale.Assembler;
            textComment.Text = selectedSale.Comment;
        }

        private void bbiSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            selectedSale.CustomerID = int.Parse(labelCustomerID.Text);
            selectedSale.ProductID = int.Parse(labelProductID.Text);
            selectedSale.Assembler = textAssembler.Text;
            selectedSale.Comment = textComment.Text;

            saleService.Update(selectedSale);
        }

        private void bbiSaveAndClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            selectedSale.CustomerID = int.Parse(labelCustomerID.Text);
            selectedSale.ProductID = int.Parse(labelProductID.Text);
            selectedSale.Assembler = textAssembler.Text;
            selectedSale.Comment = textComment.Text;

            saleService.Update(selectedSale);
            this.DialogResult = DialogResult.OK;
        }
    }
}