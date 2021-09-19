using Business.DependencyResolvers.Ninject;
using Bussiness.Abstract;
using Entities.Concrete;
using FormUI.Views.CustomerForms;
using FormUI.Views.ProductForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormUI.Views.SaleForms
{
    public partial class AddSaleForm : DevExpress.XtraEditors.XtraForm
    {
        ICustomerService customerService;
        IInstalmentService instalmentService;
        ISaleService saleService;
        IMaintenanceService maintenanceService;
        IProductService productService;
        public AddSaleForm()
        {
            InitializeComponent();
            customerService = InstanceFactory.GetInstance<ICustomerService>();
            instalmentService = InstanceFactory.GetInstance<IInstalmentService>();
            saleService = InstanceFactory.GetInstance<ISaleService>();
            maintenanceService = InstanceFactory.GetInstance<IMaintenanceService>();
            productService = InstanceFactory.GetInstance<IProductService>();
        }

        private void navButton1_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)//Sat
        {
            int price = Convert.ToInt32(textPrice.Text);// - Convert.ToInt32(textPaidPrice.Text);
            int remainderPrice = price - Convert.ToInt32(textPaidPrice.Text);

            if (dataGridView1.Rows.Count > 0)
            {
                int totalPrice = 0;
                foreach (DataGridViewRow item in dataGridView1.Rows)
                {
                    totalPrice += Convert.ToInt32(item.Cells[1].Value);
                }
                if (remainderPrice != totalPrice)
                {
                    MessageBox.Show("Taksitlerin Toplam Fiyatı Kalan Tutara Eşit Değil! \n Kalan Tutar = "+ remainderPrice.ToString() +" \n Taksit Toplam =" + totalPrice.ToString());
                    return;
                }
            }

            //Select Customer
            int customerID = 0;
            if (tabControlCustomer.SelectedTabPage.Text == "Yeni")
            {
                customerID = customerService.Add(new Customer() { Name = newCustomerName.Text, PhoneNumber = newCustomerAddress.Text, Address = newCustomerAddress.Text });
            }
            else
                customerID = Convert.ToInt32(textEdit1.Text);

            //Add and Select Sale
            int saleID = saleService.Add(new Sale()
            {
                CustomerID = customerID,
                PaymentType = comboBoxPaymentType.Text,
                Price = price,
                ProductID = Convert.ToInt32(textProductID.Text),
                SaleDate = DateTime.Now.Date,
                RemainderPrice = remainderPrice,
                Assembler = textAssembler.Text,
                Comment = textBox2.Text
            });

            //Add Maintenance
            if (checkEdit1.Checked)
                maintenanceService.Add(new Maintenance() { SaleID = saleID, MaintenanceInterval = Convert.ToInt32(comboBoxMaintenanceInterval.Text), StartDate = dateEditMaintenanceStart.DateTime });

            //Add Instalments
            if (comboBoxPaymentType.SelectedIndex == 2)
            {
                if (dataGridView1.Rows.Count > 0)//Hesaplanmış bir taksit teması var ise
                {
                    foreach (DataGridViewRow item in dataGridView1.Rows)
                    {
                        instalmentService.Add(new Instalment()
                        {
                            SaleID = saleID,
                            InstalmentNo = Convert.ToInt32(item.Cells[0].Value),
                            PaymentDate = dateEditInstalmentStart.DateTime.AddMonths(Convert.ToInt32(item.Cells[0])),
                            PayablePrice = Convert.ToInt32(item.Cells[1].Value)
                        });
                    }
                }
                else
                {
                    for (int i = 0; i < Convert.ToInt32(comboBox1.Text); i++)
                    {
                        instalmentService.Add(new Instalment()
                        {
                            SaleID = saleID,
                            InstalmentNo = i + 1,
                            PaymentDate = dateEditInstalmentStart.DateTime.AddMonths(i + 1),
                            PayablePrice = remainderPrice / Convert.ToInt32(comboBox1.Text)
                        });
                    }
                }
            }

            this.DialogResult = DialogResult.OK;
        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AddSaleForm_Load(object sender, EventArgs e)
        {
            dateEditMaintenanceStart.DateTime = DateTime.Now.Date;
            dateEditInstalmentStart.DateTime = DateTime.Now.Date;
        }

        private void checkEdit1_CheckedChanged(object sender, EventArgs e)
        {
            MaintenanceGroup.Enabled = checkEdit1.Checked;

        }

        private void navButton3_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        SelectCustomerForm selectCustomerForm;
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            selectCustomerForm = new SelectCustomerForm();
            if (selectCustomerForm.ShowDialog() == DialogResult.OK)
            {
                Customer selectedCustomer = customerService.GetByID(selectCustomerForm.SelectedCustomerID);
                textEdit1.Text = selectedCustomer.ID.ToString();
                textEdit2.Text = selectedCustomer.Name;
                textEdit3.Text = selectedCustomer.PhoneNumber;
                textBox1.Text = selectedCustomer.Address;
            }
        }//Müşteri seçme

        SelectProductForm selectProductForm;
        private void simpleButton4_Click(object sender, EventArgs e)//Ürün Seçme
        {
            selectProductForm = new SelectProductForm();
            if (selectProductForm.ShowDialog() == DialogResult.OK)
            {
                Product selectedProduct = productService.GetByID(selectProductForm.SelectedProductID);
                textProductID.Text = selectedProduct.ID.ToString();
                textProductName.Text = selectedProduct.Name;
                textPrice.Text = selectedProduct.DefaultPrice.ToString();
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)//Taksit Hesap
        {
            dataGridView1.Rows.Clear();

            int price = Convert.ToInt32(textPrice.Text) - Convert.ToInt32(textPaidPrice.Text);
            int instalmentCount = Convert.ToInt32(comboBox1.Text);

            for (int i = 1; i <= instalmentCount; i++)
            {
                dataGridView1.Rows.Add(i, price / instalmentCount);
            }
        }

        private void simpleButton5_Click(object sender, EventArgs e)//Taksitleri Temizleme
        {
            dataGridView1.Rows.Clear();
        }
    }
}
