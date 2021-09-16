using Business.DependencyResolvers.Ninject;
using Bussiness.Abstract;
using Entities.Concrete;
using FormUI.Views.CustomerForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormUI.Views.SaleForms
{
    public partial class AddSaleForm : DevExpress.XtraEditors.XtraForm
    {
        ICustomerService customerService;
        IInstalmentService instalmentService;
        ISaleService saleService;
        IMaintenanceService maintenanceService;
        public AddSaleForm()
        {
            InitializeComponent();
            customerService = InstanceFactory.GetInstance<ICustomerService>();
            instalmentService = InstanceFactory.GetInstance<IInstalmentService>();
            saleService = InstanceFactory.GetInstance<ISaleService>();
            maintenanceService = InstanceFactory.GetInstance<IMaintenanceService>();
        }

        private void navButton1_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            int price = Convert.ToInt32(textEditPrice.Text) - Convert.ToInt32(textEdit4.Text);

            //Select Customer
            int customerID = 0;
            if (tabControlCustomer.SelectedTabPage.Text == "Yeni")
            {
                customerID = customerService.Add(new Customer() { Name = newCustomerName.Text, PhoneNumber = newCustomerAddress.Text, Address = newCustomerAddress.Text });
            }
            else
                customerID = Convert.ToInt32(textEdit1.Text);

            //Add and Select Sale
            int saleID = saleService.Add(new Sale() { CustomerID = customerID, PaymentType= comboBoxPaymentType.Text, Price = price, 
                Product = textEditProduct.Text,SaleDate = DateTime.Now});

            //Add Maintenance
            if(checkEdit1.Checked)
                maintenanceService.Add(new Maintenance() { SaleID = saleID, MaintenanceInterval = Convert.ToInt32(comboBoxMaintenanceInterval.Text), StartDate = dateTimeOffsetEdit1.DateTimeOffset.Date });

            //Add Instalments
            if(comboBoxPaymentType.SelectedIndex == 2)
            {
                for (int i = 0; i < Convert.ToInt32(comboBox1.Text); i++)
                {
                    instalmentService.Add(new Instalment() { SaleID = saleID, InstalmentNo = i + 1, PaymentDate = dateEdit1.DateTime.AddMonths(i + 1),
                    PayablePrice = price / Convert.ToInt32(comboBox1.Text) });
                }
            }

            this.DialogResult = DialogResult.OK;
        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AddSaleForm_Load(object sender, EventArgs e)
        {
        }

        private void checkEdit1_CheckedChanged(object sender, EventArgs e)
        {
            MaintenanceGroup.Enabled = checkEdit1.Checked;
            
        }

        private void navButton3_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        SelectCustomerForm selectCustomerForm;
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            selectCustomerForm = new SelectCustomerForm();
            if(selectCustomerForm.ShowDialog() == DialogResult.OK)
            {
                Customer selectedCustomer = customerService.GetByID(selectCustomerForm.SelectedCustomerID);
                textEdit1.Text = selectedCustomer.ID.ToString();
                textEdit2.Text = selectedCustomer.Name;
                textEdit3.Text = selectedCustomer.PhoneNumber;
                textBox1.Text = selectedCustomer.Address;
            }
        }
    }
}
