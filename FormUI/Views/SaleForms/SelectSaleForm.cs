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

namespace FormUI.Views.SaleForms
{
    public partial class SelectSaleForm : DevExpress.XtraEditors.XtraForm
    {
        public int selectedSaleID { get; set; }
        ISaleService saleService;
        public SelectSaleForm()
        { 
            InitializeComponent();
            saleService = InstanceFactory.GetInstance<ISaleService>();
            gridControl.DataSource = saleService.GetAllDetails();
        }
        public SelectSaleForm(int customerID)
        {
            InitializeComponent();
            saleService = InstanceFactory.GetInstance<ISaleService>();
            gridControl.DataSource = saleService.GetCustomerDetails(customerID);
        }

        private void gridControl_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (((GridView)gridControl.MainView).SelectedRowsCount > 0)
            {
                int[] selRows = ((GridView)gridControl.MainView).GetSelectedRows();
                selectedSaleID = ((SaleDto)(((GridView)gridControl.MainView).GetRow(selRows[0]))).ID;
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}