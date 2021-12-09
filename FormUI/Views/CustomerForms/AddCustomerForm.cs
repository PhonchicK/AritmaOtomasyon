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

namespace FormUI.Views.CustomerForms
{
    public partial class AddCustomerForm : DevExpress.XtraEditors.XtraForm
    {
        ICustomerService customerService;
        public AddCustomerForm()
        {
            InitializeComponent();
            customerService = InstanceFactory.GetInstance<ICustomerService>();
        }

        private void navButton1_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            if (string.IsNullOrEmpty(TextName.Text))
                return;
            customerService.Add(new Customer() { Name = TextName.Text, PhoneNumber = TextPhoneNumber.Text, Address = TextAddress.Text, Comment = textComment.Text});
            this.DialogResult = DialogResult.OK;
        }

        private void navButton3_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
