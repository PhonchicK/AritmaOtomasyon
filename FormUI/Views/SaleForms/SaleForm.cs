using Business.DependencyResolvers.Ninject;
using Bussiness.Abstract;
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

namespace FormUI.Views.SaleForms
{
    public partial class SaleForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        ISaleService saleService;
        public SaleForm()
        {
            InitializeComponent();
            saleService = InstanceFactory.GetInstance<ISaleService>();
            gridControl.DataSource = saleService.GetAll();
            //bsiRecordsCount.Caption = "RECORDS : " + dataSource.Count;
        }
        void bbiPrintPreview_ItemClick(object sender, ItemClickEventArgs e)
        {
            gridControl.ShowRibbonPrintPreview();
        }
        private void SaleForm_Load(object sender, EventArgs e)
        {

        }
    }
}