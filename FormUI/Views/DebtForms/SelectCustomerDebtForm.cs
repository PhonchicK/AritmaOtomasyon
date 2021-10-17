using Business.DependencyResolvers.Ninject;
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
    public partial class SelectCustomerDebtForm : DevExpress.XtraEditors.XtraForm
    {
        public int SelectedDebt { get; set; }
        IDebtService debtService;
        public SelectCustomerDebtForm(int customerID)
        {
            InitializeComponent();

            debtService = InstanceFactory.GetInstance<IDebtService>();
            gridControl.DataSource = debtService.GetCustomerDebts(customerID);
        }

        private void gridControl_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (((GridView)gridControl.MainView).SelectedRowsCount > 0)
            {
                int[] selRows = ((GridView)gridControl.MainView).GetSelectedRows();
                SelectedDebt = ((Debt)(((GridView)gridControl.MainView).GetRow(selRows[0]))).ID;

                this.DialogResult = DialogResult.OK;
            }
        }
    }
}