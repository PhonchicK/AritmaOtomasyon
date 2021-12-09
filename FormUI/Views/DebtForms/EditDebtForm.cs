using Business.DependencyResolvers.Ninject;
using Bussiness.Abstract;
using DevExpress.XtraEditors;
using DevExpress.XtraLayout;
using DevExpress.XtraLayout.Helpers;
using Entities.Concrete;
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

namespace FormUI.Views.DebtForms
{
    public partial class EditDebtForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        Debt selectedDebt;
        IDebtService debtService;
        ICustomerService customerService;
        public EditDebtForm(int debtID)
        {
            InitializeComponent();
            debtService = InstanceFactory.GetInstance<IDebtService>();
            customerService = InstanceFactory.GetInstance<ICustomerService>();
            selectedDebt = debtService.GetByID(debtID);
        }

        private void EditDebtForm_Load(object sender, EventArgs e)
        {
            Customer customer = customerService.GetByID(selectedDebt.CustomerID);
            textCustomerID.Text = customer.ID.ToString();

            dateDebtDate.DateTime = selectedDebt.Date.Date;
            textReceive.Text = selectedDebt.Receive.ToString();
            textGive.Text = selectedDebt.Give.ToString();
            textComment.Text = selectedDebt.Comment;
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

        private void bbiSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            textComment.Focus();
            selectedDebt.CustomerID = int.Parse(textCustomerID.Text);
            selectedDebt.Date = dateDebtDate.DateTime.Date;
            selectedDebt.Receive = int.Parse(textReceive.Text);
            selectedDebt.Give = int.Parse(textGive.Text);
            selectedDebt.Comment = textComment.Text;

            debtService.Update(selectedDebt);
        }

        private void bbiClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void bbiDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show(selectedDebt.ID.ToString() +
                " ID li kaydı silmek istiyor musunuz ? ", "Uyarı",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                debtService.Delete(new Debt() { ID = selectedDebt.ID });
            }
            this.DialogResult = DialogResult.OK;
        }

        private void bbiReset_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Customer customer = customerService.GetByID(selectedDebt.CustomerID);
            textCustomerID.Text = customer.ID.ToString();

            dateDebtDate.DateTime = selectedDebt.Date.Date;
            textReceive.Text = selectedDebt.Receive.ToString();
            textGive.Text = selectedDebt.Give.ToString();
            textComment.Text = selectedDebt.Comment;
        }

        private void bbiSaveAndClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            textComment.Focus();
            selectedDebt.CustomerID = int.Parse(textCustomerID.Text);
            selectedDebt.Date = dateDebtDate.DateTime.Date;
            selectedDebt.Receive = int.Parse(textReceive.Text);
            selectedDebt.Give = int.Parse(textGive.Text);
            selectedDebt.Comment = textComment.Text;

            debtService.Update(selectedDebt);

            this.DialogResult = DialogResult.OK;
        }
    }
}
