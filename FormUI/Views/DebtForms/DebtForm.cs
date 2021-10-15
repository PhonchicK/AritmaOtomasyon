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
    }
}