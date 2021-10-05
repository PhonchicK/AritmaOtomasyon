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
using Entities.Concrete;
using Bussiness.Abstract;
using Business.DependencyResolvers.Ninject;

namespace FormUI.Views.InstalmentForms
{
    public partial class InstalmentForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        IInstalmentService instalmentService;
        public InstalmentForm()
        {
            InitializeComponent();
            instalmentService = InstanceFactory.GetInstance<IInstalmentService>();
            gridView.RowStyle += GridView_RowStyle;
            gridControl.DataSource = instalmentService.GetAllDetails();
            //bsiRecordsCount.Caption = "RECORDS : " + dataSource.Count;
        }
        public InstalmentForm(string val, int ID)
        {
            InitializeComponent();
            instalmentService = InstanceFactory.GetInstance<IInstalmentService>();
            switch(val)
            {
                case "customer":
                    gridControl.DataSource = instalmentService.GetCustomerInstalments(ID);
                    break;
                case "sale":
                    gridControl.DataSource = instalmentService.GetSaleInstalmentsDetails(ID);
                    break;
            }
            gridView.RowStyle += GridView_RowStyle;
            //bsiRecordsCount.Caption = "RECORDS : " + dataSource.Count;
        }
        void bbiPrintPreview_ItemClick(object sender, ItemClickEventArgs e)
        {
            gridControl.ShowRibbonPrintPreview();
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            gridView.ActiveFilter.NonColumnFilter = "[PaidPrice] < [PayablePrice]";
        }

        private void GridView_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            int paid = Convert.ToInt32(gridView.GetRowCellValue(e.RowHandle, "PaidPrice"));
            int payable = Convert.ToInt32(gridView.GetRowCellValue(e.RowHandle, "PayablePrice"));

            if (paid == payable)
            {
                e.Appearance.BackColor = Color.LightGreen;
            }
            else
            {
                e.Appearance.BackColor = Color.IndianRed;
            }

            //Override any other formatting  
            e.HighPriority = true;
        }

        private void barToggleSwitchItem1_CheckedChanged(object sender, ItemClickEventArgs e)
        {
            gridView.ActiveFilter.NonColumnFilter = barToggleSwitchItem1.Checked ? null : "[PaidPrice] < [PayablePrice]";
        }

        private void bbiEdit_ItemClick(object sender, ItemClickEventArgs e)
        {

        }
    }
}