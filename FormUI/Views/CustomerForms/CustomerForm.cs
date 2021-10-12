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
using DevExpress.XtraGrid.Views.Grid;
using Entities.Dto;
using FormUI.Views.SaleForms;
using FormUI.Views.InstalmentForms;

namespace FormUI.Views.CustomerForms
{
    public partial class CustomerForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        ICustomerService customerService;
        IInstalmentService instalmentService;
        public CustomerForm()
        {
            InitializeComponent();
            customerService = InstanceFactory.GetInstance<ICustomerService>();
            instalmentService = InstanceFactory.GetInstance<IInstalmentService>();
            gridControl.DataSource = customerService.GetAllDetails();
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
            if(new AddCustomerForm().ShowDialog() == DialogResult.OK)
            {
                gridControl.DataSource = customerService.GetAllDetails();
            }
        }

        private void bbiRefresh_ItemClick(object sender, ItemClickEventArgs e)
        {
            gridControl.DataSource = customerService.GetAllDetails();
        }
        EditCustomerForm editCustomerForm;
        private void bbiEdit_ItemClick(object sender, ItemClickEventArgs e)
        {
            int selectedCustomerID;
            if (((GridView)gridControl.MainView).SelectedRowsCount > 0)
            {
                int[] selRows = ((GridView)gridControl.MainView).GetSelectedRows();
                selectedCustomerID = ((CustomerDto)(((GridView)gridControl.MainView).GetRow(selRows[0]))).ID;
                editCustomerForm = new EditCustomerForm(selectedCustomerID);
                if(editCustomerForm.ShowDialog() == DialogResult.OK)
                {
                    gridControl.DataSource = customerService.GetAllDetails();
                }
            }
        }

        private void gridControl_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int selectedCustomerID;
            if (((GridView)gridControl.MainView).SelectedRowsCount > 0)
            {
                int[] selRows = ((GridView)gridControl.MainView).GetSelectedRows();
                selectedCustomerID = ((CustomerDto)(((GridView)gridControl.MainView).GetRow(selRows[0]))).ID;
                editCustomerForm = new EditCustomerForm(selectedCustomerID);
                if (editCustomerForm.ShowDialog() == DialogResult.OK)
                {
                    gridControl.DataSource = customerService.GetAllDetails();
                }
            }
        }

        private void bbiDelete_ItemClick(object sender, ItemClickEventArgs e)
        {
            int selectedCustomerID;
            if (((GridView)gridControl.MainView).SelectedRowsCount > 0)
            {
                int[] selRows = ((GridView)gridControl.MainView).GetSelectedRows();
                selectedCustomerID = ((CustomerDto)(((GridView)gridControl.MainView).GetRow(selRows[0]))).ID;
                if (MessageBox.Show(selectedCustomerID.ToString() +
                    " ID li müşteriyi silmek istiyor musunuz ? \n Not : Satış silinirse kayıtlı satış,bakım ve taksit kayıtlarıda silinecektir.", "Uyarı",
                    MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    customerService.Delete(new Customer() { ID = selectedCustomerID });
                }
            }
        }
        SelectSaleForm selectSaleForm;
        PayInstalment payInstalment;
        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            int selectedCustomerID;
            if (((GridView)gridControl.MainView).SelectedRowsCount > 0)
            {
                int[] selRows = ((GridView)gridControl.MainView).GetSelectedRows();
                selectedCustomerID = ((CustomerDto)(((GridView)gridControl.MainView).GetRow(selRows[0]))).ID;
                selectSaleForm = new SelectSaleForm(selectedCustomerID);
                if(selectSaleForm.ShowDialog() == DialogResult.OK)
                {
                    var instalments = instalmentService.GetSaleInstalments(selectSaleForm.selectedSaleID);

                    bool state = true;

                    if (instalments.Count == 0)
                        state = true;

                    foreach (var item in instalments)
                    {
                        state = (state && (item.PayablePrice == item.PaidPrice));
                    }
                    if (state)
                    {
                        MessageBox.Show("Tüm taksitler ödenmiş veya Müşteriye ait taksit kaydı bulunamadı.");
                        return;
                    }

                    payInstalment = new PayInstalment(selectSaleForm.selectedSaleID);
                    payInstalment.ShowDialog();
                }
            }
        }
    }
}