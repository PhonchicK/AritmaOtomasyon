﻿using Business.DependencyResolvers.Ninject;
using Bussiness.Abstract;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using Entities.Concrete;
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

namespace FormUI.Views.DebtForms
{
    public partial class DebtForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        IDebtService debtService;
        public DebtForm()
        {
            InitializeComponent();
            debtService = InstanceFactory.GetInstance<IDebtService>();
            gridControl.DataSource = debtService.GetAllDetails();
        }
        void bbiPrintPreview_ItemClick(object sender, ItemClickEventArgs e)
        {
            gridControl.ShowRibbonPrintPreview();
        }

        private void bbiNew_ItemClick(object sender, ItemClickEventArgs e)
        {
            new NewDebtForm().ShowDialog();
        }

        private void bbiDelete_ItemClick(object sender, ItemClickEventArgs e)
        {
            int selectedDebtID;
            if (((GridView)gridControl.MainView).SelectedRowsCount > 0)
            {
                int[] selRows = ((GridView)gridControl.MainView).GetSelectedRows();
                selectedDebtID = ((DebtDto)(((GridView)gridControl.MainView).GetRow(selRows[0]))).ID;
                if (MessageBox.Show(selectedDebtID.ToString() +
                    " ID li kaydı silmek istiyor musunuz ? ", "Uyarı",
                    MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    debtService.Delete(new Debt() { ID = selectedDebtID });
                }
            }
        }
        SelectCustomerDebtForm selectCustomerDebtForm;
        private void bbiEdit_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (((GridView)gridControl.MainView).SelectedRowsCount > 0)
            {
                int[] selRows = ((GridView)gridControl.MainView).GetSelectedRows();
                selectCustomerDebtForm = new SelectCustomerDebtForm(((DebtDto)(((GridView)gridControl.MainView).GetRow(selRows[0]))).CustomerID);
                if(selectCustomerDebtForm.ShowDialog() == DialogResult.OK)
                {
                    new EditDebtForm(selectCustomerDebtForm.SelectedDebt).ShowDialog();
                }
            }
        }
    }
}