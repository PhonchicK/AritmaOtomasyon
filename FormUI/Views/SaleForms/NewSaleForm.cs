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
    public partial class NewSaleForm : DevExpress.XtraEditors.XtraForm
    {
        SelectCustomerForm selectCustomerForm;
        SelectProductForm selectProductForm;

        #region Services
        ICustomerService customerService;
        IInstalmentService instalmentService;
        ISaleService saleService;
        IMaintenanceBaseService maintenanceBaseService;
        IProductService productService;
        IDebtService debtService;

        private void LoadServices()
        {
            customerService = InstanceFactory.GetInstance<ICustomerService>();
            instalmentService = InstanceFactory.GetInstance<IInstalmentService>();
            saleService = InstanceFactory.GetInstance<ISaleService>();
            maintenanceBaseService = InstanceFactory.GetInstance<IMaintenanceBaseService>();
            productService = InstanceFactory.GetInstance<IProductService>();
            debtService = InstanceFactory.GetInstance<IDebtService>();
        }
        #endregion
        public NewSaleForm()
        {
            InitializeComponent();
            LoadServices();
        }
        #region Customer
        private void buttonSelectCustomer_Click(object sender, EventArgs e)
        {
            selectCustomerForm = new SelectCustomerForm();
            if (selectCustomerForm.ShowDialog() == DialogResult.OK)
            {
                Customer selectedCustomer = customerService.GetByID(selectCustomerForm.SelectedCustomerID);
                textExistsCustomerID.Text = selectedCustomer.ID.ToString();
                textExistsCustomerName.Text = selectedCustomer.Name;
                textExistsCustomerPhoneNumber.Text = selectedCustomer.PhoneNumber;
                textExistsCustomerAddress.Text = selectedCustomer.Address;
            }
        }
        private void buttonCustomerNext_Click(object sender, EventArgs e)
        {
            if (tabControlCustomer.SelectedTabPage.Text == "Yeni")
            {
                if (string.IsNullOrWhiteSpace(textNewCustomerName.Text))
                {
                    MessageBox.Show("Lütfen gerekli alanları doldurunuz! \n (Gerekli alanlar '*' ile gösterilmiştir.)");
                    return;
                }
                CustomerNextPage();
            }
            else if (tabControlCustomer.SelectedTabPage.Text == "Varolan")
            {
                if (string.IsNullOrWhiteSpace(textExistsCustomerID.Text))
                {
                    MessageBox.Show("Lütfen bir müşteri seçiniz!");
                    return;
                }
                CustomerNextPage();
            }
        }
        private void buttonCustomerCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            CustomerReferancePage();
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            ReferanceSavePage();
        }
        #endregion

        #region Product
        private void buttonSelectProduct_Click(object sender, EventArgs e)
        {
            selectProductForm = new SelectProductForm();
            if (selectProductForm.ShowDialog() == DialogResult.OK)
            {
                Product selectedProduct = productService.GetByID(selectProductForm.SelectedProductID);
                textProductID.Text = selectedProduct.ID.ToString();
                textProductName.Text = selectedProduct.Name;
                textPaymentPrice.Text = selectedProduct.DefaultPrice.ToString();
            }
        }
        private void toggleMaintenanceState_Toggled(object sender, EventArgs e)
        {
            buttonMaintenanceSettings.Enabled = toggleMaintenanceState.IsOn;
        }
        private void buttonProductNext_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textProductID.Text))
            {
                MessageBox.Show("Lütfen bir ürün seçiniz.");
                return;
            }
            if (toggleMaintenanceState.IsOn)
            {
                if (string.IsNullOrWhiteSpace(comboBoxMaintenanceInterval.Text))
                {
                    MessageBox.Show("Lütfen bir bakım aralığı seçiniz.");
                    return;
                }
                if (string.IsNullOrWhiteSpace(dateEditMaintenanceStart.Text))
                {
                    MessageBox.Show("Lütfen bakım başlangıç tarihi giriniz.");
                    return;
                }
            }
            ProductNextPage();
        }
        private void buttonProductBack_Click(object sender, EventArgs e)
        {
            ProductBackPage();
        }
        #endregion

        #region Payment
        private void comboBoxPaymentType_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonPaymentInstalmentSettings.Enabled = (comboBoxPaymentType.Text == "Taksit");
        }
        private void buttonPaymentInstalmentSettings_Click(object sender, EventArgs e)
        {
            int price = Convert.ToInt32(textPaymentPrice.Text);
            int paidPrice = Convert.ToInt32(textPaymentPaidPrice.Text);

            if (paidPrice >= price)
            {
                MessageBox.Show("Lütfen Ücret ve Ödenen Tutar alanlarını kontrol ediniz!");
                return;
            }
            PaymentInstalmentSettings();
        }
        private void buttonPaymentBack_Click(object sender, EventArgs e)
        {
            PaymentBackPage();
        }
        private void buttonPaymentNext_Click(object sender, EventArgs e)
        {
            if (comboBoxPaymentType.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen bir ödeme şekli seçiniz.");
                return;
            }
            if (comboBoxPaymentType.Text == "Taksit")
            {
                if (comboBoxInstalmentCount.SelectedIndex == -1)
                {
                    MessageBox.Show("Lütfen gerekli alanları doldurunuz.");
                    return;
                }

                int totalInstalmentPrice = Convert.ToInt32(labelTotalPrice.Text);
                int paymentPrice = Convert.ToInt32(textPaymentPrice.Text);
                int paidPrice = Convert.ToInt32(textPaymentPaidPrice.Text);

                if (totalInstalmentPrice != (paymentPrice - paidPrice))
                {
                    if (MessageBox.Show("Ödenecek tutar toplam taksit tutarına eşit değil! Devam etmek istiyormusunuz ? \n Toplam Taksit Tutarı = " +
                        totalInstalmentPrice.ToString() + "\n Ödenecek Tutar = " + (paymentPrice - paidPrice).ToString(), "Uyarı!", MessageBoxButtons.YesNo) != DialogResult.Yes)
                    {
                        return;
                    }
                }
            }
            PaymentNextPage();
        }
        #endregion

        #region Maintenance
        private void comboBoxMaintenanceInterval_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
        private void buttonMaintenanceSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(comboBoxMaintenanceInterval.Text))
            {
                MessageBox.Show("Lütfen bir bakım aralığı seçiniz.");
                return;
            }
            if (string.IsNullOrWhiteSpace(dateEditMaintenanceStart.Text))
            {
                MessageBox.Show("Lütfen bakım başlangıç tarihi giriniz.");
                return;
            }
            MaintenanceExitPage();
        }
        private void buttonMaintenanceBack_Click(object sender, EventArgs e)
        {
            MaintenanceExitPage();
        }
        #endregion

        #region Instalment
        private void comboBoxInstalmentCount_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxInstalmentCount.SelectedIndex != -1)
            {
                int price = Convert.ToInt32(textPaymentPrice.Text) - Convert.ToInt32(textPaymentPaidPrice.Text);
                int instalmentCount = Convert.ToInt32(comboBoxInstalmentCount.Text);
                LoadInstalments(price, instalmentCount);
            }
        }
        private void LoadInstalments(int price, int count)
        {
            dataGridView1.Rows.Clear();
            for (int i = 1; i <= count; i++)
            {
                dataGridView1.Rows.Add(i, price / count, dateEditInstalmentStart.DateTime.Date.AddMonths(i).ToShortDateString());
            }
            CalculateTotalPrice();
        }
        private void buttonInstalmentBack_Click(object sender, EventArgs e)
        {
            InstalmentExitPage();
        }
        private void buttonInstalmentSave_Click(object sender, EventArgs e)
        {
            if (comboBoxInstalmentCount.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen gerekli alanları doldurunuz.");
                return;
            }
            InstalmentExitPage();
        }
        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            CalculateTotalPrice();
        }
        private void CalculateTotalPrice()
        {
            int total = 0;
            foreach (DataGridViewRow item in dataGridView1.Rows)
            {
                total += Convert.ToInt32(item.Cells[1].Value);
            }
            labelTotalPrice.Text = total.ToString();
        }
        private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(Column1_KeyPress);
            if (dataGridView1.CurrentCell.ColumnIndex == 1) //Desired Column
            {
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.KeyPress += new KeyPressEventHandler(Column1_KeyPress);
                }
            }
        }
        private void Column1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void dateEditInstalmentStart_EditValueChanged(object sender, EventArgs e)
        {
            if (comboBoxInstalmentCount.SelectedIndex != -1)
            {
                int price = Convert.ToInt32(textPaymentPrice.Text) - Convert.ToInt32(textPaymentPaidPrice.Text);
                int instalmentCount = Convert.ToInt32(comboBoxInstalmentCount.Text);
                LoadInstalments(price, instalmentCount);
            }
        }
        #endregion

        #region Details
        private void buttonDetailsSell_Click(object sender, EventArgs e)
        {
            int customerID;
            int saleID;
            int price = Convert.ToInt32(textPaymentPrice.Text);
            int paidPrice = Convert.ToInt32(textPaymentPaidPrice.Text);
            int? referanceID = null;
            int? referancePrice = null;

            if (!string.IsNullOrWhiteSpace(textReferanceID.Text))
            {
                referanceID = int.Parse(textReferanceID.Text);
                referancePrice = int.Parse(textReferancePrice.Text);
            }

            if (tabControlCustomer.SelectedTabPage.Text == "Yeni")
            {
                customerID = customerService.Add(new Customer() 
                { 
                    Name = textNewCustomerName.Text, 
                    PhoneNumber = textNewCustomerPhoneNumber.Text, 
                    Address = textNewCustomerAddress.Text , 
                    ReferanceCustomerID = referanceID,
                    ReferancePrice = referancePrice
                });
            }
            else
                customerID = Convert.ToInt32(textExistsCustomerID.Text);

            saleID = saleService.Add(new Sale()
            {
                CustomerID = customerID,
                ProductID = Convert.ToInt32(textProductID.Text),
                Price = price,
                //RemainderPrice = price - paidPrice,
                PaymentType = comboBoxPaymentType.Text,
                SaleDate = DateTime.Now.Date,
                Assembler = textProductAssembler.Text,
                Comment = textProductComment.Text
            });

            if (toggleMaintenanceState.IsOn)
                maintenanceBaseService.Add(new MaintenanceBase()
                {
                    SaleID = saleID,
                    MaintenanceInterval = Convert.ToInt32(comboBoxMaintenanceInterval.Text),
                    StartDate = dateEditMaintenanceStart.DateTime.Date
                });

            if (comboBoxPaymentType.Text == "Taksit")
            {
                foreach (DataGridViewRow item in dataGridView1.Rows)
                {
                    instalmentService.Add(new Instalment()
                    {
                        SaleID = saleID,
                        InstalmentNo = Convert.ToInt32(item.Cells[0].Value),
                        PaymentDate = dateEditInstalmentStart.DateTime.AddMonths(Convert.ToInt32(item.Cells[0].Value)),
                        PayablePrice = Convert.ToInt32(item.Cells[1].Value)
                    });
                }
            }

            else
            {
                debtService.Add(new Debt() 
                { 
                    CustomerID = customerID, 
                    Date = DateTime.Now.Date, 
                    Receive = price,
                    Give = paidPrice,
                    Comment =  price.ToString() + "TL tutarlı " + textProductName.Text + " adlı ürün satışı."
                });
            }
            this.DialogResult = DialogResult.OK;
        }
        private void LoadDetails()
        {
            labelDetailsCustomerState.Text = tabControlCustomer.SelectedTabPage.Text;
            if(tabControlCustomer.SelectedTabPage.Text == "Yeni")
            {
                labelDetailsCustomerName.Text = textNewCustomerName.Text;
                labelDetailsCustomerPhoneNumber.Text = textNewCustomerPhoneNumber.Text;
            }
            else
            {
                labelDetailsCustomerName.Text = textExistsCustomerName.Text;
                labelDetailsCustomerPhoneNumber.Text = textExistsCustomerPhoneNumber.Text;
            }

            labelDetailsProductName.Text = textProductName.Text;
            labelDetailsPaymentType.Text = comboBoxPaymentType.Text;
            labelDetailsPaymentPrice.Text = textPaymentPrice.Text;
            labelDetailsPaymentPaidPrice.Text = textPaymentPaidPrice.Text;
            if(comboBoxPaymentType.Text == "Taksit")
            {
                labelDetailsInstalmentCount.Text = comboBoxInstalmentCount.Text;
            }
        }
        #endregion

        #region PageControls
        private void CustomerNextPage()
        {
            mainTabControl.SelectedTabPage = tabPageProduct;
        }
        private void CustomerReferancePage()
        {
            mainTabControl.SelectedTabPage = tabPageReferance;
        }
        private void ReferanceSavePage()
        {
            mainTabControl.SelectedTabPage = tabPageCustomer;
        }
        private void buttonMaintenanceSettings_Click(object sender, EventArgs e)
        {
            mainTabControl.SelectedTabPage = tabPageMaintenance;
        }
        private void ProductBackPage()
        {
            mainTabControl.SelectedTabPage = tabPageCustomer;
        }
        private void ProductNextPage()
        {
            mainTabControl.SelectedTabPage = tabPagePayment;
        }
        private void MaintenanceExitPage()
        {
            mainTabControl.SelectedTabPage = tabPageProduct;
        }
        private void PaymentInstalmentSettings()
        {
            mainTabControl.SelectedTabPage = tabPageInstalment;
        }
        private void PaymentBackPage()
        {
            mainTabControl.SelectedTabPage = tabPageProduct;
        }
        private void PaymentNextPage()
        {
            mainTabControl.SelectedTabPage = tabPageDetails;
        }
        private void InstalmentExitPage()
        {
            mainTabControl.SelectedTabPage = tabPagePayment;
        }
        #endregion

        private void NewSaleForm_Load(object sender, EventArgs e)
        {
            dateEditInstalmentStart.DateTime = DateTime.Now.Date;
            dateEditMaintenanceStart.DateTime = DateTime.Now.Date;
        }

        private void mainTabControl_SelectedPageChanged(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e)
        {
            switch(e.Page.Text)
            {
                case "Details":
                    LoadDetails();
                    break;
            }
        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {
            selectCustomerForm = new SelectCustomerForm();
            if (selectCustomerForm.ShowDialog() == DialogResult.OK)
            {
                textReferanceID.Text = selectCustomerForm.SelectedCustomerID.ToString();
            }
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            textReferanceID.Text = null;
        }

        private void textReferanceID_EditValueChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textReferanceID.Text))
            {
                textReferanceName.Text = null;
                textReferancePhoneNumber.Text = null;
                textReferancePrice.ReadOnly = true;
                textReferancePrice.Text = null;
            }
            else
            {
                Customer referance = customerService.GetByID(int.Parse(textReferanceID.Text));
                textReferanceName.Text = referance.Name;
                textReferancePhoneNumber.Text = referance.PhoneNumber;
                textReferancePrice.ReadOnly = false;
            }
        }
    }
}
