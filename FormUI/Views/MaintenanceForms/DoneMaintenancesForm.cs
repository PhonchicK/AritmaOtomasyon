using Business.DependencyResolvers.Ninject;
using Bussiness.Abstract;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using Entities.Concrete;
using IHYAOtomasyon.Views.MaintenanceForms;
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
        string value;
        int id;
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
            value = val;
            id = ID;
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

        EditDoneMaintenanceForm editDoneMaintenanceForm;
        private void bbiEdit_ItemClick(object sender, ItemClickEventArgs e)
        {
            int selectedMaintenanceID;
            if (((GridView)gridControl.MainView).SelectedRowsCount > 0)
            {
                int[] selRows = ((GridView)gridControl.MainView).GetSelectedRows();
                selectedMaintenanceID = ((Maintenance)(((GridView)gridControl.MainView).GetRow(selRows[0]))).ID;
                editDoneMaintenanceForm = new EditDoneMaintenanceForm(selectedMaintenanceID);
                editDoneMaintenanceForm.ShowDialog();
            }
        }

        private void gridControl_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int selectedMaintenanceID;
            if (((GridView)gridControl.MainView).SelectedRowsCount > 0)
            {
                int[] selRows = ((GridView)gridControl.MainView).GetSelectedRows();
                selectedMaintenanceID = ((Maintenance)(((GridView)gridControl.MainView).GetRow(selRows[0]))).ID;
                editDoneMaintenanceForm = new EditDoneMaintenanceForm(selectedMaintenanceID);
                editDoneMaintenanceForm.ShowDialog();
            }
        }

        private void bbiDelete_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (((GridView)gridControl.MainView).SelectedRowsCount > 0)
            {
                int[] selRows = ((GridView)gridControl.MainView).GetSelectedRows();
                Maintenance selectedMaintenance = ((Maintenance)(((GridView)gridControl.MainView).GetRow(selRows[0])));
                if(MessageBox.Show("Bu bakım kaydını silmek istediğinize emin misiniz ?", "Uyarı", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    maintenanceService.Delete(selectedMaintenance);
                    if(value != null)
                    {
                        switch (value)
                        {
                            case "customer":
                                gridControl.DataSource = maintenanceService.GetByCustomerID(id);
                                break;
                            case "sale":
                                gridControl.DataSource = maintenanceService.GetBySaleID(id);
                                break;
                        }
                    }
                    else

                        gridControl.DataSource = maintenanceService.GetAll();
                }
            }
        }
    }
}