using Business.DependencyResolvers.Ninject;
using Bussiness.Abstract;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using Entities.Dto;
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
            barButtonItem1.Enabled = false;
        }
        public MaintenancesForm(string val, int ID)
        {
            InitializeComponent();
            maintenanceBaseService = InstanceFactory.GetInstance<IMaintenanceBaseService>();
            switch(val)
            {
                case "sale":
                    gridControl.DataSource = maintenanceBaseService.GetSaleDetails(ID);
                    break;
                case "customer":
                    gridControl.DataSource = maintenanceBaseService.GetCustomerDetails(ID);
                    break;

            }
        }
        void bbiPrintPreview_ItemClick(object sender, ItemClickEventArgs e)
        {
            gridControl.ShowRibbonPrintPreview();
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {

        }
        EditMaintenanceForm editMaintenanceForm;
        private void bbiEdit_ItemClick(object sender, ItemClickEventArgs e)
        {
            int selectedMaintenanceID;
            if (((GridView)gridControl.MainView).SelectedRowsCount > 0)
            {
                int[] selRows = ((GridView)gridControl.MainView).GetSelectedRows();
                selectedMaintenanceID = ((MaintenanceDto)(((GridView)gridControl.MainView).GetRow(selRows[0]))).ID;
                editMaintenanceForm = new EditMaintenanceForm(selectedMaintenanceID);
                editMaintenanceForm.ShowDialog();
            }
        }
    }
}