using Business.DependencyResolvers.Ninject;
using Bussiness.Abstract;
using DevExpress.XtraEditors;
using DevExpress.XtraLayout;
using DevExpress.XtraLayout.Helpers;
using Entities.Concrete;
using Entities.Dto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormUI.Views.MaintenanceForms
{
    public partial class EditMaintenanceForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        IMaintenanceBaseService maintenanceBaseService;
        IProductService productService;
        MaintenanceDto selectedMaintenance;
        public EditMaintenanceForm(int maintenanceBaseID)
        {
            InitializeComponent();
            maintenanceBaseService = InstanceFactory.GetInstance<IMaintenanceBaseService>();
            productService = InstanceFactory.GetInstance<IProductService>();

            selectedMaintenance = maintenanceBaseService.GetDetailsByID(maintenanceBaseID);
        }

        private void EditMaintenanceForm_Load(object sender, EventArgs e)
        {
            dateMaintenanceStartDate.DateTime = selectedMaintenance.StartDate.Date;
            comboBoxMaintenanceInterval.Text = selectedMaintenance.MaintenanceInterval.ToString();
            textProductName.Text = selectedMaintenance.Product;
            textProductFeatures.Text = productService.GetByID(selectedMaintenance.ProductID).Features;
        }
    }
}