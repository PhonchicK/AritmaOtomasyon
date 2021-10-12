﻿using Business.DependencyResolvers.Ninject;
using Bussiness.Abstract;
using DevExpress.Utils.Filtering.Internal;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Localization;
using FormUI.DE.Localizers;
using FormUI.Views.CustomerForms;
using FormUI.Views.InstalmentForms;
using FormUI.Views.MaintenanceForms;
using FormUI.Views.ProductForms;
using FormUI.Views.SaleForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormUI
{
    public partial class MainMenu : DevExpress.XtraEditors.XtraForm
    {
        ICustomerService customerService;
        ISaleService saleService;
        IInstalmentService instalmentService;
        IMaintenanceBaseService maintenanceBaseService;
        IMaintenanceService maintenanceService;
        public MainMenu()
        {
            InitializeComponent();
            customerService = InstanceFactory.GetInstance<ICustomerService>();
            saleService = InstanceFactory.GetInstance<ISaleService>();
            instalmentService = InstanceFactory.GetInstance<IInstalmentService>();
            maintenanceBaseService = InstanceFactory.GetInstance<IMaintenanceBaseService>();
            maintenanceService = InstanceFactory.GetInstance<IMaintenanceService>();

            GridLocalizer.Active = new TurkishGridLocalizer();
            Localizer.Active = new TurkishEditorsLocalizer();
            EditResLocalizer.Active = new TurkishEditResLocalizer();
            FilterUIElementResXLocalizer.Active = new TurkishFilterUILocalizer();
        }

        private void tileBarItem2_ItemClick(object sender, TileItemEventArgs e)
        {
            new CustomerForm().Show();
        }

        private void tileBarItem3_ItemClick(object sender, TileItemEventArgs e)
        {
            new SaleForm().Show();
        }

        private void tileBarItem1_ItemClick(object sender, TileItemEventArgs e)
        {
            new ProductForm().Show();
        }

        private void tileBarItem4_ItemClick(object sender, TileItemEventArgs e)
        {
            new MaintenancesForm().Show();
        }

        private void tileBarItem5_ItemClick(object sender, TileItemEventArgs e)
        {
            new InstalmentForm().Show();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = maintenanceBaseService.GetClosesDetails();
            gridControl2.DataSource = instalmentService.GetThisMonthInstalments();
            gridControl3.DataSource = instalmentService.GetLateInstalments();
        }
    }
}