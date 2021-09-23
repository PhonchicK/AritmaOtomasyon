using Business.DependencyResolvers.Ninject;
using Bussiness.Abstract;
using DevExpress.XtraEditors;
using DevExpress.XtraLayout;
using DevExpress.XtraLayout.Helpers;
using Entities.Concrete;
using FormUI.Views.InstalmentForms;
using FormUI.Views.MaintenanceForms;
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
        public EditCustomerForm(int customerID)
        {
            InitializeComponent();
            customerService = InstanceFactory.GetInstance<ICustomerService>();
            saleService = InstanceFactory.GetInstance<ISaleService>();
            instalmentService = InstanceFactory.GetInstance<IInstalmentService>();
            maintenanceBaseService = InstanceFactory.GetInstance<IMaintenanceBaseService>();
            selectedCustomer = customerService.GetByID(customerID);
        }

        private void navButton2_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            
        }
        private void navButton5_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            if(instalmentService.GetCustomerInstalments(selectedCustomer.ID).Count < 1)
            {
                MessageBox.Show("Müşteriye ait taksit kaydı bulunamadı.");
                return;
            }
            new InstalmentForm(selectedCustomer.ID).ShowDialog();
        }

        private void navButton3_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            if(maintenanceBaseService.GetCustomerDetails(selectedCustomer.ID).Count < 1)
            {
                MessageBox.Show("Müşteriye ait bakım kaydı bulunamadı.");
                return;
            }
            new MaintenancesForm(selectedCustomer.ID).ShowDialog();
        }
    }
}