﻿using DevExpress.XtraBars;
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

namespace FormUI.Views.InstalmentForms
{
    public partial class InstalmentForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        IInstalmentService instalmentService;
        public InstalmentForm()
        {
            InitializeComponent();
            instalmentService = InstanceFactory.GetInstance<IInstalmentService>();
            gridControl.DataSource = instalmentService.GetAll();
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
            /*if(new AddCustomerForm().ShowDialog() == DialogResult.OK)
            {
                gridControl.DataSource = customerService.GetAll();
            }*/
        }

        private void bbiRefresh_ItemClick(object sender, ItemClickEventArgs e)
        {
            gridControl.DataSource = instalmentService.GetAll();
        }
    }
}