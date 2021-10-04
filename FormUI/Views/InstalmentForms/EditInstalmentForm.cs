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

namespace FormUI.Views.InstalmentForms
{
    public partial class EditInstalmentForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        InstalmentDto selectedInstalment;
        IInstalmentService instalmentService;
        ICustomerService customerService;
        public EditInstalmentForm(int instalmentID)
        {
            InitializeComponent();
            instalmentService = InstanceFactory.GetInstance<IInstalmentService>();
            customerService = InstanceFactory.GetInstance<ICustomerService>();
            selectedInstalment = instalmentService.GetDetailsByID(instalmentID);
        }

        private void EditInstalmentForm_Load(object sender, EventArgs e)
        {
            textCustomerName.Text = selectedInstalment.CustomerName;
            textCustomerPhone.Text = selectedInstalment.CustomerPhoneNumber;

            textInstalmentNo.Text = selectedInstalment.InstalmentNo.ToString();
            textInstalmentPayablePrice.Text = selectedInstalment.PayablePrice.ToString();
            dateInstalmentPaymentDate.DateTime = selectedInstalment.PaymentDate.Date;
            textPaidPrice.Text = selectedInstalment.PaidPrice.ToString();
            datePaidDate.DateTime = selectedInstalment.PaidDate.Date;
        }

        private void bbiClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void bbiReset_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(MessageBox.Show("Kayıtları başa döndürmek istediğinize emin misiniz ?", "Uyarı", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                textCustomerName.Text = selectedInstalment.CustomerName;
                textCustomerPhone.Text = selectedInstalment.CustomerPhoneNumber;

                textInstalmentNo.Text = selectedInstalment.InstalmentNo.ToString();
                textInstalmentPayablePrice.Text = selectedInstalment.PayablePrice.ToString();
                dateInstalmentPaymentDate.DateTime = selectedInstalment.PaymentDate.Date;
                textPaidPrice.Text = selectedInstalment.PaidPrice.ToString();
                datePaidDate.DateTime = selectedInstalment.PaidDate.Date;
            }
        }

        private void bbiSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Save();
        }

        private void Save()
        {
            Instalment updatedInstalment = instalmentService.GetByID(selectedInstalment.ID);
            updatedInstalment.PaidDate = datePaidDate.DateTime.Date;
            updatedInstalment.PaidPrice = int.Parse(textPaidPrice.Text);
            instalmentService.Update(updatedInstalment);
        }

        private void bbiSaveAndClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Save();
            this.DialogResult = DialogResult.OK;
        }
    }
}