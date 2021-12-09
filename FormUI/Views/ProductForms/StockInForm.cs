using Business.DependencyResolvers.Ninject;
using Bussiness.Abstract;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using Entities.Concrete;
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

namespace IHYAOtomasyon.Views.ProductForms
{
    public partial class StockInForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        int productID;
        IStockInService stockInService;
        public StockInForm()
        {
            InitializeComponent();
            stockInService = InstanceFactory.GetInstance<IStockInService>();
            gridControl.DataSource = stockInService.GetAll();
        }
        public StockInForm(int productID)
        {
            InitializeComponent();
            stockInService = InstanceFactory.GetInstance<IStockInService>();
            this.productID = productID;
            gridControl.DataSource = stockInService.GetProductStockIns(productID);
        }

        AddStockForm addStockForm;
        private void bbiNew_ItemClick(object sender, ItemClickEventArgs e)
        {
            addStockForm = new AddStockForm();
            if(addStockForm.ShowDialog() == DialogResult.OK)
            {
                gridControl.DataSource = productID != null ? stockInService.GetProductStockIns(productID) : stockInService.GetAll();
            }
        }

        EditStockIn editStockIn;
        private void bbiEdit_ItemClick(object sender, ItemClickEventArgs e)
        {
            int selectedStockInID;
            if (((GridView)gridControl.MainView).SelectedRowsCount > 0)
            {
                int[] selRows = ((GridView)gridControl.MainView).GetSelectedRows();
                selectedStockInID = ((StockIn)(((GridView)gridControl.MainView).GetRow(selRows[0]))).ID;

                editStockIn = new EditStockIn(selectedStockInID);
                if (editStockIn.ShowDialog() == DialogResult.OK)
                {
                    gridControl.DataSource = productID != null ? stockInService.GetProductStockIns(productID) : stockInService.GetAll();
                }
            }
        }

        private void bbiDelete_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (((GridView)gridControl.MainView).SelectedRowsCount > 0)
            {
                int[] selRows = ((GridView)gridControl.MainView).GetSelectedRows();
                StockIn selectedStockIn = ((StockIn)(((GridView)gridControl.MainView).GetRow(selRows[0])));

                if(MessageBox.Show(selectedStockIn.WhoPurchase + " tarafından yapılan stok giriş kaydını silmek istediğinize emin misiniz ?", "Uyarı", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    stockInService.Delete(selectedStockIn);
                    gridControl.DataSource = productID != null ? stockInService.GetProductStockIns(productID) : stockInService.GetAll();
                }
            }
        }
    }
}