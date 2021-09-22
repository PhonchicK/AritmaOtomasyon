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

namespace FormUI.Views.CustomerForms
{
    public partial class EditCustomerForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        Customer selectedCustomer;
        public EditCustomerForm(int customerID)
        {
            InitializeComponent();
        }
    }
}