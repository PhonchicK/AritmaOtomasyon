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

namespace FormUI.Views.CustomerForms
{
    public partial class SelectCustomerForm : DevExpress.XtraEditors.XtraForm
    {
        ICustomerService customerService;
        public int SelectedCustomerID { get; set; }
        public SelectCustomerForm()
        {
            InitializeComponent();
            customerService = InstanceFactory.GetInstance<ICustomerService>();
            gridControl.DataSource = customerService.GetAll();
            //bsiRecordsCount.Caption = "RECORDS : " + dataSource.Count;
        }
        private void gridControl_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if(((GridView)gridControl.MainView).SelectedRowsCount > 0)
            {
                int[] selRows = ((GridView)gridControl.MainView).GetSelectedRows();
                SelectedCustomerID = ((Customer)(((GridView)gridControl.MainView).GetRow(selRows[0]))).ID;
                this.DialogResult = DialogResult.OK;
            }
        }

        private void SelectCustomerForm_Load(object sender, EventArgs e)
        {

        }
    }
}