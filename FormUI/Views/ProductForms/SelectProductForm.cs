using Business.DependencyResolvers.Ninject;
using Bussiness.Abstract;
using DevExpress.XtraGrid.Views.Grid;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormUI.Views.ProductForms
{
    public partial class SelectProductForm : DevExpress.XtraEditors.XtraForm
    {
        IProductService productService;
        public int SelectedProductID { get; set; }
        public SelectProductForm()
        {
            InitializeComponent();
            productService = InstanceFactory.GetInstance<IProductService>();
            gridControl.DataSource = productService.GetAll();
        }

        private void gridControl_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (((GridView)gridControl.MainView).SelectedRowsCount > 0)
            {
                int[] selRows = ((GridView)gridControl.MainView).GetSelectedRows();
                SelectedProductID = ((Product)(((GridView)gridControl.MainView).GetRow(selRows[0]))).ID;
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}
