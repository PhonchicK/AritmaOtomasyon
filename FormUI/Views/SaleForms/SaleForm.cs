using Business.DependencyResolvers.Ninject;
using Bussiness.Abstract;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using Entities.Concrete;
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

namespace FormUI.Views.SaleForms
{
    public partial class SaleForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        bool isCustomer = false;
        int customerID;
        ISaleService saleService;
        IInstalmentService instalmentService;
        public SaleForm()
        {
            InitializeComponent();
            saleService = InstanceFactory.GetInstance<ISaleService>();
            instalmentService = InstanceFactory.GetInstance<IInstalmentService>();
            gridControl.DataSource = saleService.GetAllDetails();
            //bsiRecordsCount.Caption = "RECORDS : " + dataSource.Count;
        }
        public SaleForm(int customerID)
        {
            InitializeComponent();
            saleService = InstanceFactory.GetInstance<ISaleService>();
            gridControl.DataSource = saleService.GetCustomerDetails(customerID);
            //bsiRecordsCount.Caption = "RECORDS : " + dataSource.Count;
            this.customerID = customerID;
            isCustomer = true;
        }

        void bbiPrintPreview_ItemClick(object sender, ItemClickEventArgs e)
        {
            gridControl.ShowRibbonPrintPreview();
        }
        private void SaleForm_Load(object sender, EventArgs e)
        {

        }

        private void bbiNew_ItemClick(object sender, ItemClickEventArgs e)
        {
            if(new NewSaleForm().ShowDialog() == DialogResult.OK)
            {
                gridControl.DataSource = saleService.GetAllDetails();
            }
        }

        private void ribbonControl_Click(object sender, EventArgs e)
        {

        }

        private void bbiDelete_ItemClick(object sender, ItemClickEventArgs e)
        {
            int selectedSaleID;
            if (((GridView)gridControl.MainView).SelectedRowsCount > 0)
            {
                int[] selRows = ((GridView)gridControl.MainView).GetSelectedRows();
                selectedSaleID = ((SaleDto)(((GridView)gridControl.MainView).GetRow(selRows[0]))).ID;
                if (MessageBox.Show(selectedSaleID.ToString() +
                    " ID li satışı silmek istiyor musunuz ? \n Not : Satış silinirse kayıtlı bakım ve taksit kayıtlarıda silinecektir.", "Uyarı",
                    MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    saleService.Delete(new Sale() { ID = selectedSaleID });
                    if(isCustomer)
                    {
                        gridControl.DataSource = saleService.GetCustomerDetails(customerID);
                    }
                    else
                    {
                        gridControl.DataSource = saleService.GetAllDetails();
                    }
                }
            }
        }
        EditSaleForm editSaleForm;
        private void gridControl_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int selectedSaleID;
            if (((GridView)gridControl.MainView).SelectedRowsCount > 0)
            {
                int[] selRows = ((GridView)gridControl.MainView).GetSelectedRows();
                selectedSaleID = ((SaleDto)(((GridView)gridControl.MainView).GetRow(selRows[0]))).ID;
                editSaleForm = new EditSaleForm(selectedSaleID);
                editSaleForm.ShowDialog();
            }
        }

        private void bbiEdit_ItemClick(object sender, ItemClickEventArgs e)
        {
            int selectedSaleID;
            if (((GridView)gridControl.MainView).SelectedRowsCount > 0)
            {
                int[] selRows = ((GridView)gridControl.MainView).GetSelectedRows();
                selectedSaleID = ((SaleDto)(((GridView)gridControl.MainView).GetRow(selRows[0]))).ID;
                editSaleForm = new EditSaleForm(selectedSaleID);
                editSaleForm.ShowDialog();
            }
        }

        private void gridView_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            SaleDto selectedSale;
            if (((GridView)gridControl.MainView).SelectedRowsCount > 0)
            {
                int[] selRows = ((GridView)gridControl.MainView).GetSelectedRows();
                selectedSale = ((SaleDto)(((GridView)gridControl.MainView).GetRow(selRows[0])));
                barButtonItem1.Enabled = selectedSale.PaymentType == "Elden Taksit";
            }
        }
        PayInstalment payInstalment;
        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            int selectedSaleID;
            if (((GridView)gridControl.MainView).SelectedRowsCount > 0)
            {
                int[] selRows = ((GridView)gridControl.MainView).GetSelectedRows();
                selectedSaleID = ((SaleDto)(((GridView)gridControl.MainView).GetRow(selRows[0]))).ID;
                
                var instalments = instalmentService.GetSaleInstalments(selectedSaleID);

                bool state = true;

                foreach (var item in instalments)
                {
                    bool sstate = (state && (item.PayablePrice == item.PaidPrice));
                    state = sstate;
                }
                if (state)
                {
                    MessageBox.Show("Tüm taksitler ödenmiş.");
                    return;
                }

                payInstalment = new PayInstalment(selectedSaleID);
                payInstalment.ShowDialog();
            }
        }
    }
}