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
            gridControl.DataSource = instalmentService.GetAllDetails();
            //bsiRecordsCount.Caption = "RECORDS : " + dataSource.Count;
        }
        void bbiPrintPreview_ItemClick(object sender, ItemClickEventArgs e)
        {
            gridControl.ShowRibbonPrintPreview();
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            
        }

        private void bbiNew_ItemClick(object sender, ItemClickEventArgs e)
        {
            /*if(new AddCustomerForm().ShowDialog() == DialogResult.OK)
            {
                gridControl.DataSource = customerService.GetAll();
            }*/
        }

        private void bbiRefresh_ItemClick(object sender, ItemClickEventArgs e)
        {
            gridControl.DataSource = barToggleSwitchItem1.Checked ? instalmentService.GetAllDetails() : instalmentService.GetNotPaidDetails();
        }

        private void bbiDelete_ItemClick(object sender, ItemClickEventArgs e)
        {
            MessageBox.Show(gridView.ActiveFilterString);
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
            gridControl.DataSource = barToggleSwitchItem1.Checked ? instalmentService.GetAllDetails() : instalmentService.GetNotPaidDetails();
        }
    }
}