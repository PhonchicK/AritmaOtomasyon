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
    public partial class DoneMaintenancesForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        IMaintenanceService maintenanceService;
        public DoneMaintenancesForm()
        {
            InitializeComponent();
            maintenanceService = InstanceFactory.GetInstance<IMaintenanceService>();
            gridControl.DataSource = maintenanceService.GetAll();
        }
        public DoneMaintenancesForm(int customerID)
        {
            InitializeComponent();
            maintenanceService = InstanceFactory.GetInstance<IMaintenanceService>();
            gridControl.DataSource = maintenanceService.GetByCustomerID(customerID);
        }
    }
}