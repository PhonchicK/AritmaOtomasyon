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

namespace FormUI.Views.CustomerForms
{
    public partial class CustomerForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        ICustomerService customerService;
        public CustomerForm()
        {
            InitializeComponent();
            customerService = InstanceFactory.GetInstance<ICustomerService>();
            gridControl.DataSource = customerService.GetAll();
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
                gridControl.DataSource = customerService.GetAll();
            }
        }

        private void bbiRefresh_ItemClick(object sender, ItemClickEventArgs e)
        {
            gridControl.DataSource = customerService.GetAll();
        }
    }
}