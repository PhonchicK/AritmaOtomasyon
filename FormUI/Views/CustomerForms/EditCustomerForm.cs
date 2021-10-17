using Business.DependencyResolvers.Ninject;
using Bussiness.Abstract;
using DevExpress.XtraEditors;
using DevExpress.XtraLayout;
using DevExpress.XtraLayout.Helpers;
using Entities.Concrete;
using FormUI.Views.DebtForms;
using FormUI.Views.InstalmentForms;
using FormUI.Views.MaintenanceForms;
using FormUI.Views.SaleForms;
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

namespace FormUI.Views.CustomerForms
{
    public partial class EditCustomerForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        Customer selectedCustomer;
        ICustomerService customerService;
        ISaleService saleService;
        IInstalmentService instalmentService;
        IMaintenanceBaseService maintenanceBaseService;
        IMaintenanceService maintenanceService;
        public EditCustomerForm(int customerID)
        {
            InitializeComponent();
            customerService = InstanceFactory.GetInstance<ICustomerService>();
            saleService = InstanceFactory.GetInstance<ISaleService>();
            instalmentService = InstanceFactory.GetInstance<IInstalmentService>();
            maintenanceBaseService = InstanceFactory.GetInstance<IMaintenanceBaseService>();
            maintenanceService = InstanceFactory.GetInstance<IMaintenanceService>();
            selectedCustomer = customerService.GetByID(customerID);
        }

        private void navButton2_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            if(saleService.GetCustomerDetails(selectedCustomer.ID).Count < 1)
            {
                MessageBox.Show("Müşteriye ait satış kaydı bulunamadı.");
                return;
            }
            new SaleForm(selectedCustomer.ID).ShowDialog();
        }
        private void navButton5_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            if(instalmentService.GetCustomerInstalments(selectedCustomer.ID).Count < 1)
            {
                MessageBox.Show("Müşteriye ait taksit kaydı bulunamadı.");
                return;
            }
            new InstalmentForm("customer", selectedCustomer.ID).ShowDialog();
        }

        private void navButton3_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            if(maintenanceBaseService.GetCustomerDetails(selectedCustomer.ID).Count < 1)
            {
                MessageBox.Show("Müşteriye ait bakım kaydı bulunamadı.");
                return;
            }
            new MaintenancesForm("customer", selectedCustomer.ID).ShowDialog();
        }

        private void navButton4_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            if (maintenanceService.GetByCustomerID(selectedCustomer.ID).Count < 1)
            {
                MessageBox.Show("Müşteriye ait bakım kaydı bulunamadı.");
                return;
            }
            new DoneMaintenancesForm("customer", selectedCustomer.ID).ShowDialog();
        }

        private void bbiSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(string.IsNullOrWhiteSpace(textCustomerName.Text))
            {
                MessageBox.Show("Lütfen gerekli alanları doldurunuz.");
                return;
            }
            selectedCustomer.Name = textCustomerName.Text;
            selectedCustomer.PhoneNumber = textCustomerPhoneNumber.Text;
            selectedCustomer.Address = textCustomerAddress.Text;
            if (string.IsNullOrWhiteSpace(textReferanceID.Text))
            {
                selectedCustomer.ReferanceCustomerID = null;
                selectedCustomer.ReferancePrice = null;
            }
            else
            {
                selectedCustomer.ReferanceCustomerID = int.Parse(textReferanceID.Text);
                selectedCustomer.ReferancePrice = int.Parse(textReferancePrice.Text);
            }
            customerService.Update(selectedCustomer);
        }

        private void bbiClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void bbiDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Seçili müşteriyi silmek istediğinize emin misiniz ? ", "Uyarı!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                customerService.Delete(selectedCustomer);
                this.DialogResult = DialogResult.OK;
            }
        }

        private void bbiSaveAndClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textCustomerName.Text))
            {
                MessageBox.Show("Lütfen gerekli alanları doldurunuz.");
                return;
            }
            selectedCustomer.Name = textCustomerName.Text;
            selectedCustomer.PhoneNumber = textCustomerPhoneNumber.Text;
            selectedCustomer.Address = textCustomerAddress.Text;
            if (string.IsNullOrWhiteSpace(textReferanceID.Text))
            {
                selectedCustomer.ReferanceCustomerID = null;
                selectedCustomer.ReferancePrice = null;
            }
            else
            {
                selectedCustomer.ReferanceCustomerID = int.Parse(textReferanceID.Text);
                selectedCustomer.ReferancePrice = int.Parse(textReferancePrice.Text);
            }
            customerService.Update(selectedCustomer);
            this.DialogResult = DialogResult.OK;
        }

        private void bbiReset_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoadInputs();
        }
        private void LoadInputs()
        {
            textCustomerName.Text = selectedCustomer.Name;
            textCustomerPhoneNumber.Text = selectedCustomer.PhoneNumber;
            textCustomerAddress.Text = selectedCustomer.Address;
            if (selectedCustomer.ReferanceCustomerID != null)
            {
                textReferanceID.Text = selectedCustomer.ReferanceCustomerID.ToString();
            }
            else
                textReferanceID.Text = null;
            listBoxReferancedCustomers.DataSource = customerService.GetReferancedCustomers(selectedCustomer.ID);
            listBoxReferancedCustomers.DisplayMember = "Name";

            listBoxReferancePrices.Items.Clear();
            int totalReferancePrice = 0;
            foreach(var item in customerService.GetReferancedCustomers(selectedCustomer.ID))
            {
                listBoxReferancePrices.Items.Add(item.Name + "   /   " + item.ReferancePrice + "TL");
                totalReferancePrice += item.ReferancePrice.Value;
            }
            labelTotalReferancePrice.Text = totalReferancePrice.ToString() + " TL";
        }

        private void EditCustomerForm_Load(object sender, EventArgs e)
        {
            LoadInputs();
        }

        private void textReferanceID_EditValueChanged(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(textReferanceID.Text))
            {
                textReferanceName.Text = null;
                textReferancePhoneNumber.Text = null;
                textReferancePrice.ReadOnly = true;
                textReferancePrice.Text = null;
            }
            else
            {
                Customer referance = customerService.GetByID(int.Parse(textReferanceID.Text));
                textReferanceName.Text = referance.Name;
                textReferancePhoneNumber.Text = referance.PhoneNumber;
                textReferancePrice.ReadOnly = false;
            }
        }
        SelectCustomerForm selectCustomerForm;
        private void buttonSelectReferance_Click(object sender, EventArgs e)
        {
            selectCustomerForm = new SelectCustomerForm();
            if(selectCustomerForm.ShowDialog() == DialogResult.OK)
            {
                if(selectCustomerForm.SelectedCustomerID == selectedCustomer.ID)
                {
                    MessageBox.Show("Aynı müşteriyi seçemezsin!");
                    return;
                }
                textReferanceID.Text = selectCustomerForm.SelectedCustomerID.ToString();
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            textReferanceID.Text = null;
        }
        private void navButton6_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            new CustomerDebtForm(selectedCustomer.ID).Show();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new NewDebtForm(selectedCustomer.ID).ShowDialog();
        }
    }
}