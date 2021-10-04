using Business.DependencyResolvers.Ninject;
using Bussiness.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormUI.Views.MaintenanceForms
{
    public partial class NewMaintenanceForm : DevExpress.XtraEditors.XtraForm
    {
        IMaintenanceBaseService maintenanceBaseService;
        IMaintenanceService maintenanceService;
        ISaleService saleService;
        ICustomerService customerService;
        int selectedMaintenanceBaseID;
        public NewMaintenanceForm(int maintenanceBaseID)
        {
            InitializeComponent();
            selectedMaintenanceBaseID = maintenanceBaseID;
            maintenanceBaseService = InstanceFactory.GetInstance<IMaintenanceBaseService>();
            maintenanceService = InstanceFactory.GetInstance<IMaintenanceService>();
            saleService = InstanceFactory.GetInstance<ISaleService>();
            MaintenanceBase selectedMaintenanceBase = maintenanceBaseService.GetByID(maintenanceBaseID);
            Maintenance lastMaintenance = maintenanceService.GetByID(selectedMaintenanceBase.LastMaintenanceID);

            textMaintenanceBaseDate.Text = selectedMaintenanceBase.StartDate.ToString();
            textMaintenanceBaseLastDate.Text = lastMaintenance != null ? lastMaintenance.Date.ToString() : null;

            Customer customer = customerService.GetByID(saleService.GetByID(selectedMaintenanceBase.SaleID).ID);
            textCustomerName.Text = customer.Name;
            textCustomerPhoneNumber.Text = customer.PhoneNumber;
            textCustomerAddress.Text = customer.Address;
        }

        private void navButton1_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textMaintenanceTakedPrice.Text) || string.IsNullOrWhiteSpace(dateMaintenanceDate.Text))
            {
                MessageBox.Show("Lütfen gerekli alanları doldurun.");
                return;
            }
            maintenanceService.Add(new Maintenance() 
            { 
                MaintenanceBaseID = selectedMaintenanceBaseID, 
                TakedPrice = int.Parse(textMaintenanceTakedPrice.Text),
                Date = dateMaintenanceDate.DateTime.Date,
                PersonDoing = textMaintenancePerson.Text,
                Process = textMaintenanceProcess.Text,
                Note = textMaintenanceNote.Text
            });
            this.DialogResult = DialogResult.OK;
        }

        private void NewMaintenanceForm_Load(object sender, EventArgs e)
        {
            dateMaintenanceDate.DateTime = DateTime.Now.Date;
        }

        private void navButton3_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
