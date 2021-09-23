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

namespace FormUI.Views.MaintenanceForms
{
    public partial class MaintenancesForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        IMaintenanceBaseService maintenanceBaseService;

        public MaintenancesForm()
        {
            InitializeComponent();
            maintenanceBaseService = InstanceFactory.GetInstance<IMaintenanceBaseService>();
            gridControl.DataSource = maintenanceBaseService.GetAllDetails();
        }
        public MaintenancesForm(int customerID)
        {
            InitializeComponent();
            maintenanceBaseService = InstanceFactory.GetInstance<IMaintenanceBaseService>();
            gridControl.DataSource = maintenanceBaseService.GetCustomerDetails(customerID);
        }
        void bbiPrintPreview_ItemClick(object sender, ItemClickEventArgs e)
        {
            gridControl.ShowRibbonPrintPreview();
        }
    }
}