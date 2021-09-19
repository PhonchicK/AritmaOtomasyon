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

namespace FormUI.Views.CustomerForms
{
    public partial class AddCustomerForm : DevExpress.XtraEditors.XtraForm
    {
        ICustomerService customerService;
        public AddCustomerForm()
        {
            InitializeComponent();
            customerService = InstanceFactory.GetInstance<ICustomerService>();
        }

        private void navButton1_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            if (string.IsNullOrEmpty(TextName.Text))
                return;
            int? refCustomerID = null;
            switch(xtraTabControl1.SelectedTabPage.Text)
            {
                case "Yeni":
                    refCustomerID = customerService.Add(new Customer() { Name = textRefNewName.Text, PhoneNumber = textRefNewPhoneNumber.Text });
                    break;
                case "Varolan":
                    refCustomerID = Convert.ToInt32(textRefID);
                    break;
            }
            customerService.Add(new Customer() { Name = TextName.Text, PhoneNumber = TextPhoneNumber.Text, Address = TextAddress.Text, ReferanceCustomerID = refCustomerID});
            this.DialogResult = DialogResult.OK;
        }

        private void navButton3_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        SelectCustomerForm selectCustomerForm;
        private void simpleButton3_Click(object sender, EventArgs e)
        {
            selectCustomerForm = new SelectCustomerForm();
            if (selectCustomerForm.ShowDialog() == DialogResult.OK)
            {
                Customer selectedCustomer = customerService.GetByID(selectCustomerForm.SelectedCustomerID);
                textRefID.Text = selectedCustomer.ID.ToString();
                textRefName.Text = selectedCustomer.Name;
                textRefPhoneNumber.Text = selectedCustomer.PhoneNumber;
            }
        }
    }
}
