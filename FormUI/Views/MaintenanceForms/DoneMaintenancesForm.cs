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
        public DoneMaintenancesForm(string val, int ID)
        {
            InitializeComponent();
            maintenanceService = InstanceFactory.GetInstance<IMaintenanceService>();
            switch(val)
            {
                case "customer":
                    gridControl.DataSource = maintenanceService.GetByCustomerID(ID);
                    break;
                case "sale":
                    gridControl.DataSource = maintenanceService.GetBySaleID(ID);
                    break;
            }
        }
    }
}