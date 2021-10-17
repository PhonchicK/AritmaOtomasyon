using Business.DependencyResolvers.Ninject;
using Bussiness.Abstract;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormUI.Views.DebtForms
{
    public partial class CustomerDebtForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        IDebtService debtService;
        int selectedCustomerID;
        public CustomerDebtForm(int customerID)
        {
            InitializeComponent();
            debtService = InstanceFactory.GetInstance<IDebtService>();
            selectedCustomerID = customerID;
            gridControl.DataSource = debtService.GetCustomerDebts(customerID);
        }
        void bbiPrintPreview_ItemClick(object sender, ItemClickEventArgs e)
        {
            gridControl.ShowRibbonPrintPreview();
        }

        private void bbiNew_ItemClick(object sender, ItemClickEventArgs e)
        {
            new NewDebtForm(selectedCustomerID).ShowDialog();
        }
    }
}