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

namespace FormUI.Views.DebtForms
{
    public partial class NewDebtForm : DevExpress.XtraEditors.XtraForm
    {
        ICustomerService customerService;
        IDebtService debtService;
        public NewDebtForm()
        {
            InitializeComponent();
            customerService = InstanceFactory.GetInstance<ICustomerService>();
            debtService = InstanceFactory.GetInstance<IDebtService>();
        }

        public NewDebtForm(int customerID)
        {
            InitializeComponent();
            customerService = InstanceFactory.GetInstance<ICustomerService>();
            debtService = InstanceFactory.GetInstance<IDebtService>();
            textCustomerID.Text = customerID.ToString();
        }

        SelectCustomerForm selectCustomerForm;
        private void buttonSelectReferance_Click(object sender, EventArgs e)
        {
            selectCustomerForm = new SelectCustomerForm();
            if(selectCustomerForm.ShowDialog() == DialogResult.OK)
            {
                textCustomerID.Text = selectCustomerForm.SelectedCustomerID.ToString(); 
            }
        }

        private void textCustomerID_EditValueChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textCustomerID.Text))
            {
                textCustomerName.Text = null;
                textCustomerPhoneNumber.Text = null;
            }
            else
            {
                Customer referance = customerService.GetByID(int.Parse(textCustomerID.Text));
                textCustomerName.Text = referance.Name;
                textCustomerPhoneNumber.Text = referance.PhoneNumber;
            }
        }

        private void NewDebtForm_Load(object sender, EventArgs e)
        {
            dateDebtDate.DateTime = DateTime.Now.Date;
        }

        private void navButton1_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            if(string.IsNullOrWhiteSpace(textCustomerID.Text))
            {
                MessageBox.Show("Lütfen müşteri seçin.");
                return;
            }
            debtService.Add(new Debt()
            {
                CustomerID = int.Parse(textCustomerID.Text),
                Receive = int.Parse(textReceive.Text),
                Give = int.Parse(textGive.Text),
                Comment = textComment.Text
            });
            this.DialogResult = DialogResult.OK;
        }

        private void navButton3_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
