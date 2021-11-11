using Business.DependencyResolvers.Ninject;
using Bussiness.Abstract;
using DevExpress.XtraEditors;
using DevExpress.XtraLayout;
using DevExpress.XtraLayout.Helpers;
using Entities.Concrete;
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

namespace IHYAOtomasyon.Views.MaintenanceForms
{
    public partial class EditDoneMaintenanceForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        IMaintenanceService maintenanceService;
        Maintenance selectedMaintenance;
        public EditDoneMaintenanceForm(int maintenanceID)
        {
            InitializeComponent();

            maintenanceService = InstanceFactory.GetInstance<IMaintenanceService>();

            selectedMaintenance = maintenanceService.GetByID(maintenanceID);
        }

        private void LoadAll()
        {
            textMaintenanceTakedPrice.Text = selectedMaintenance.TakedPrice.ToString();
            dateMaintenanceDate.DateTime = selectedMaintenance.Date;
            textMaintenancePerson.Text = selectedMaintenance.PersonDoing;
            textMaintenanceProcess.Text = selectedMaintenance.Process;
            textMaintenanceNote.Text = selectedMaintenance.Note;
        }

        private void EditDoneMaintenanceForm_Load(object sender, EventArgs e)
        {
            LoadAll();
        }

        private void bbiReset_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoadAll();
        }

        private void bbiSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            selectedMaintenance.TakedPrice = int.Parse(textMaintenanceTakedPrice.Text);
            selectedMaintenance.Date = dateMaintenanceDate.DateTime.Date;
            selectedMaintenance.PersonDoing = textMaintenancePerson.Text;
            selectedMaintenance.Process = textMaintenanceProcess.Text;
            selectedMaintenance.Note = textMaintenanceNote.Text;

            maintenanceService.Update(selectedMaintenance);
        }

        private void bbiSaveAndClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            selectedMaintenance.TakedPrice = int.Parse(textMaintenanceTakedPrice.Text);
            selectedMaintenance.Date = dateMaintenanceDate.DateTime.Date;
            selectedMaintenance.PersonDoing = textMaintenancePerson.Text;
            selectedMaintenance.Process = textMaintenanceProcess.Text;
            selectedMaintenance.Note = textMaintenanceNote.Text;

            maintenanceService.Update(selectedMaintenance);

            this.DialogResult = DialogResult.OK;
        }

        private void bbiDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(MessageBox.Show("Bu bakım kaydını silmek istediğinize emin misiniz ?","Uyarı",MessageBoxButtons.YesNo) == DialogResult.OK)
            {
                maintenanceService.Delete(selectedMaintenance);
                this.DialogResult = DialogResult.OK;
            }
        }

        private void bbiClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}