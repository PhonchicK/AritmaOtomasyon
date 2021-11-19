using Business.DependencyResolvers.Ninject;
using Bussiness.Abstract;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using Entities.Dto;
using FormUI.Views.InstalmentForms;
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

namespace IHYAOtomasyon.Views.InstalmentForms
{
    public partial class InstalmentDetailsForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        IInstalmentService instalmentService;
        public InstalmentDetailsForm()
        {
            InitializeComponent();
            instalmentService = InstanceFactory.GetInstance<IInstalmentService>();
        }
        void bbiPrintPreview_ItemClick(object sender, ItemClickEventArgs e)
        {
            gridControl.ShowRibbonPrintPreview();
        }

        PayInstalment payInstalment;
        private void bbiEdit_ItemClick(object sender, ItemClickEventArgs e)
        {
            int selectedSaleID;
            if (((GridView)gridControl.MainView).SelectedRowsCount > 0)
            {
                int[] selRows = ((GridView)gridControl.MainView).GetSelectedRows();
                selectedSaleID = ((InstalmentDetailsDto)(((GridView)gridControl.MainView).GetRow(selRows[0]))).SaleID;
                payInstalment = new PayInstalment(selectedSaleID);
                if(payInstalment.ShowDialog() == DialogResult.OK)
                {
                    gridControl.DataSource = instalmentService.GetAllCustomerDetails();
                }
            }
        }

        private void InstalmentDetailsForm_Load(object sender, EventArgs e)
        {
            gridControl.DataSource = instalmentService.GetAllCustomerDetails();
        }

        private void gridControl_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int selectedSaleID;
            if (((GridView)gridControl.MainView).SelectedRowsCount > 0)
            {
                int[] selRows = ((GridView)gridControl.MainView).GetSelectedRows();
                selectedSaleID = ((InstalmentDetailsDto)(((GridView)gridControl.MainView).GetRow(selRows[0]))).SaleID;
                payInstalment = new PayInstalment(selectedSaleID);
                if (payInstalment.ShowDialog() == DialogResult.OK)
                {
                    gridControl.DataSource = instalmentService.GetAllCustomerDetails();
                }
            }
        }
    }
}