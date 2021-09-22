using Business.DependencyResolvers.Ninject;
using Bussiness.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormUI.Views.MaintenanceForms
{
    public partial class CloseMaintenances : DevExpress.XtraEditors.XtraForm
    {
        IMaintenanceService maintenanceService;
        IMaintenanceBaseService maintenanceBaseService;
        public CloseMaintenances()
        {
            maintenanceService = InstanceFactory.GetInstance<IMaintenanceService>();
            maintenanceBaseService = InstanceFactory.GetInstance<IMaintenanceBaseService>();
            InitializeComponent();
        }

        private void CloseMaintenances_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = maintenanceBaseService.GetClosesDetails();
        }
    }
}
