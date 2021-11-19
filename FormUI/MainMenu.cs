using Business.DependencyResolvers.Ninject;
using Bussiness.Abstract;
using DevExpress.Utils.Filtering.Internal;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Localization;
using FormUI.DE.Localizers;
using FormUI.Views.CustomerForms;
using FormUI.Views.DebtForms;
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
using System.Data.Entity;
using Entities.Concrete;
using IHYAOtomasyon.Views.NoteForms;
using DevExpress.XtraGrid.Views.Grid;
using Entities.Dto;
using IHYAOtomasyon.Views.InstalmentForms;

namespace FormUI
{
    public partial class MainMenu : DevExpress.XtraEditors.XtraForm
    {
        public static MainMenu instance;
        ICustomerService customerService;
        ISaleService saleService;
        IInstalmentService instalmentService;
        IMaintenanceBaseService maintenanceBaseService;
        IMaintenanceService maintenanceService;
        IDebtService debtService;
        INoteService noteService;
        public MainMenu()
        {
            InitializeComponent();
            instance = this;

            customerService = InstanceFactory.GetInstance<ICustomerService>();
            saleService = InstanceFactory.GetInstance<ISaleService>();
            instalmentService = InstanceFactory.GetInstance<IInstalmentService>();
            maintenanceBaseService = InstanceFactory.GetInstance<IMaintenanceBaseService>();
            maintenanceService = InstanceFactory.GetInstance<IMaintenanceService>();
            debtService = InstanceFactory.GetInstance<IDebtService>();
            noteService = InstanceFactory.GetInstance<INoteService>();

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

        private void MainMenu_Load(object sender, EventArgs e)
        {
            LoadGrids();
        }
        public void LoadGrids()
        {
            gridControl1.DataSource = maintenanceBaseService.GetClosesDetails();
            gridControl2.DataSource = instalmentService.GetThisMonthInstalments();
            gridControl3.DataSource = instalmentService.GetLateInstalments();
            gridControl4.DataSource = noteService.GetTodayNotes();
        }

        NewMaintenanceForm newMaintenanceForm;
        private void gridControl1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int selectedMaintenanceID;
            if (((GridView)gridControl1.MainView).SelectedRowsCount > 0)
            {
                int[] selRows = ((GridView)gridControl1.MainView).GetSelectedRows();
                selectedMaintenanceID = ((MaintenanceDto)(((GridView)gridControl1.MainView).GetRow(selRows[0]))).ID;
                newMaintenanceForm = new NewMaintenanceForm(selectedMaintenanceID);
                if(newMaintenanceForm.ShowDialog() == DialogResult.OK)
                {
                    gridControl1.DataSource = maintenanceBaseService.GetClosesDetails();
                }
            }
        }

        private void tileBarItem5_ItemClick(object sender, TileItemEventArgs e)
        {
            new DebtForm().Show();
        }

        private void tileBarItem6_ItemClick(object sender, TileItemEventArgs e)
        {
            new NoteForm().Show();
        }
        PayInstalment payInstalment;
        private void gridControl2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int selectedInstalmentSaleID;
            if (((GridView)gridControl2.MainView).SelectedRowsCount > 0)
            {
                int[] selRows = ((GridView)gridControl2.MainView).GetSelectedRows();
                selectedInstalmentSaleID = ((InstalmentDto)(((GridView)gridControl2.MainView).GetRow(selRows[0]))).SaleID;
                payInstalment = new PayInstalment(selectedInstalmentSaleID);
                if(payInstalment.ShowDialog() == DialogResult.OK)
                {
                    gridControl2.DataSource = instalmentService.GetThisMonthInstalments();
                }
            }
        }

        private void gridControl3_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int selectedInstalmentSaleID;
            if (((GridView)gridControl3.MainView).SelectedRowsCount > 0)
            {
                int[] selRows = ((GridView)gridControl3.MainView).GetSelectedRows();
                selectedInstalmentSaleID = ((InstalmentDto)(((GridView)gridControl3.MainView).GetRow(selRows[0]))).SaleID;
                payInstalment = new PayInstalment(selectedInstalmentSaleID);
                if (payInstalment.ShowDialog() == DialogResult.OK)
                {
                    gridControl3.DataSource = instalmentService.GetLateInstalments();
                }
            }
        }

        private void gridControl4_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (((GridView)gridControl4.MainView).SelectedRowsCount > 0)
            {
                int[] selRows = ((GridView)gridControl4.MainView).GetSelectedRows();
                Note selectedNote = ((Note)(((GridView)gridControl3.MainView).GetRow(selRows[0])));
                if (MessageBox.Show(selectedNote.Name + " adlı notu silmek istediğinze emin misiniz ?", "Uyarı", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    noteService.Delete(selectedNote);
                    gridControl4.DataSource = noteService.GetTodayNotes();
                }
            }
        }

        private void tileBarItem7_ItemClick(object sender, TileItemEventArgs e)
        {
            new InstalmentDetailsForm().Show();
        }
    }
}