﻿using Business.DependencyResolvers.Ninject;
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

namespace FormUI.Views.ProductForms
{
    public partial class ProductForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        IProductService productService;
        public ProductForm()
        {
            InitializeComponent();
            productService = InstanceFactory.GetInstance<IProductService>();
            gridControl.DataSource = productService.GetAll();
            //bsiRecordsCount.Caption = "RECORDS : " + dataSource.Count;
        }
        void bbiPrintPreview_ItemClick(object sender, ItemClickEventArgs e)
        {
            gridControl.ShowRibbonPrintPreview();
        }
        NewProductForm newProductForm;
        private void bbiNew_ItemClick(object sender, ItemClickEventArgs e)
        {
            newProductForm = new NewProductForm();
            if(newProductForm.ShowDialog() == DialogResult.OK)
            {
                gridControl.DataSource = productService.GetAll();
            }
        }

        private void bbiDelete_ItemClick(object sender, ItemClickEventArgs e)
        {
            int selectedProductID;
            if (((GridView)gridControl.MainView).SelectedRowsCount > 0)
            {
                int[] selRows = ((GridView)gridControl.MainView).GetSelectedRows();
                selectedProductID = ((Product)(((GridView)gridControl.MainView).GetRow(selRows[0]))).ID;
                if (MessageBox.Show(selectedProductID.ToString() +
                    " ID li Ürünü silmek istiyor musunuz ?", "Uyarı",
                    MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    productService.Delete(new Product() { ID = selectedProductID });
                    gridControl.DataSource = productService.GetAll();
                }
            }
        }
        EditProductForm editProductForm;
        private void bbiEdit_ItemClick(object sender, ItemClickEventArgs e)
        {
            int selectedProductID;
            if (((GridView)gridControl.MainView).SelectedRowsCount > 0)
            {
                int[] selRows = ((GridView)gridControl.MainView).GetSelectedRows();
                selectedProductID = ((Product)(((GridView)gridControl.MainView).GetRow(selRows[0]))).ID;

                editProductForm = new EditProductForm(selectedProductID);
                if(editProductForm.ShowDialog() == DialogResult.OK)
                {
                    gridControl.DataSource = productService.GetAll();
                }
            }
        }
    }
}