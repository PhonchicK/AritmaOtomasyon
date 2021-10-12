using Business.DependencyResolvers.Ninject;
using Bussiness.Abstract;
using DevExpress.XtraEditors;
using DevExpress.XtraLayout;
using DevExpress.XtraLayout.Helpers;
using Entities.Concrete;
using Entities.Dto;
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

namespace FormUI.Views.MaintenanceForms
{
    public partial class EditMaintenanceForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        IMaintenanceBaseService maintenanceBaseService;
        IProductService productService;
        MaintenanceDto selectedMaintenance;
        public EditMaintenanceForm(int maintenanceBaseID)
        {
            InitializeComponent();
            maintenanceBaseService = InstanceFactory.GetInstance<IMaintenanceBaseService>();
            productService = InstanceFactory.GetInstance<IProductService>();

            selectedMaintenance = maintenanceBaseService.GetDetailsByID(maintenanceBaseID);
        }

        private void EditMaintenanceForm_Load(object sender, EventArgs e)
        {
            dateMaintenanceStartDate.DateTime = selectedMaintenance.StartDate.Date;
            comboBoxMaintenanceInterval.Text = selectedMaintenance.MaintenanceInterval.ToString();
            textProductName.Text = selectedMaintenance.Product;
            textProductFeatures.Text = productService.GetByID(selectedMaintenance.ProductID).Features;
            textCustomerName.Text = selectedMaintenance.CustomerName;
            textCustomerPhone.Text = selectedMaintenance.CustomerPhoneNumber;
        }

        private void bbiSaveAndClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(dateMaintenanceStartDate.Text) || string.IsNullOrWhiteSpace(comboBoxMaintenanceInterval.Text))
            {
                MessageBox.Show("Lütfen gerekli alanları doldurunuz.");
                return;
            }
            MaintenanceBase selectedMaintenanceBase = maintenanceBaseService.GetByID(selectedMaintenance.ID);
            selectedMaintenanceBase.StartDate = dateMaintenanceStartDate.DateTime.Date;
            selectedMaintenanceBase.MaintenanceInterval = int.Parse(comboBoxMaintenanceInterval.Text);
            maintenanceBaseService.Update(selectedMaintenanceBase);
            this.DialogResult = DialogResult.OK;
        }

        private void bbiSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(string.IsNullOrWhiteSpace(dateMaintenanceStartDate.Text) || string.IsNullOrWhiteSpace(comboBoxMaintenanceInterval.Text))
            {
                MessageBox.Show("Lütfen gerekli alanları doldurunuz.");
                return;
            }
            MaintenanceBase selectedMaintenanceBase = maintenanceBaseService.GetByID(selectedMaintenance.ID);
            selectedMaintenanceBase.StartDate = dateMaintenanceStartDate.DateTime.Date;
            selectedMaintenanceBase.MaintenanceInterval = int.Parse(comboBoxMaintenanceInterval.Text);
            maintenanceBaseService.Update(selectedMaintenanceBase);
        }

        private void comboBoxMaintenanceInterval_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void bbiReset_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            dateMaintenanceStartDate.DateTime = selectedMaintenance.StartDate.Date;
            comboBoxMaintenanceInterval.Text = selectedMaintenance.MaintenanceInterval.ToString();
            textProductName.Text = selectedMaintenance.Product;
            textProductFeatures.Text = productService.GetByID(selectedMaintenance.ProductID).Features;
            textCustomerName.Text = selectedMaintenance.CustomerName;
            textCustomerPhone.Text = selectedMaintenance.CustomerPhoneNumber;
        }

        private void bbiDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(MessageBox.Show("Bu bakımı iptal etmek istediğinize emin misiniz ?","Uyarı",MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                maintenanceBaseService.Delete(new MaintenanceBase() { ID = selectedMaintenance.ID });
            }
        }

        private void bbiClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}