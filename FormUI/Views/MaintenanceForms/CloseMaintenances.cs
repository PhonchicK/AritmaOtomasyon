using Business.DependencyResolvers.Ninject;
using Bussiness.Abstract;
using DevExpress.XtraGrid.Views.Grid;
using Entities.Dto;
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

        private void gridControl1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (((GridView)gridControl1.MainView).SelectedRowsCount > 0)
            {
                int[] selRows = ((GridView)gridControl1.MainView).GetSelectedRows();
                int selectedMaintenanceID = ((MaintenanceDto)(((GridView)gridControl1.MainView).GetRow(selRows[0]))).ID;
                new NewMaintenanceForm(selectedMaintenanceID).ShowDialog();
            }
        }
    }
}
