using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business.DependencyResolvers.Ninject;
using Bussiness.Abstract;
using Entities.Concrete;

namespace FormUI.Views.InstalmentForms
{
    public partial class PayInstalment : DevExpress.XtraEditors.XtraForm
    {
        ISaleService saleService;
        IInstalmentService instalmentService;
        ICustomerService customerService;

        private Instalment[] saleInstalments;
        private int payInstalmentIndex;
        public PayInstalment(int saleID)
        {
            InitializeComponent();
            saleService = InstanceFactory.GetInstance<ISaleService>();
            instalmentService = InstanceFactory.GetInstance<IInstalmentService>();
            customerService = InstanceFactory.GetInstance<ICustomerService>();

            saleInstalments = instalmentService.GetSaleInstalments(saleID).ToArray();
        }
        private void PayInstalment_Load(object sender, EventArgs e)
        {
            bool state = true;

            if (saleInstalments.Length == 0)
                state = false;

            foreach (var item in saleInstalments)
            {
                state = (state && (item.PayablePrice != item.PaidPrice));
            }
            if (!state)
                this.DialogResult = DialogResult.Abort;

            if (state)
            {
                for (int i = 0; i < saleInstalments.Length; i++)
                {
                    if (saleInstalments[i].PaidPrice < saleInstalments[i].PayablePrice && saleInstalments[i].PaymentDate.Month >= DateTime.Now.Month)//Ödenecek taksiti bulmak için kontrol
                    {
                        payInstalmentIndex = i;
                        break;
                    }
                }

                int totalRemainderPrice = 0;
                int totalRemainderMonths = 0;
                int notPaidMonths = 0;
                int totalNotPaid = 0;

                foreach (var item in saleInstalments)
                {
                    totalRemainderPrice += item.PayablePrice - item.PaidPrice;//Toplam kalan borç hesabı

                    totalRemainderMonths += (item.PaidPrice < item.PayablePrice) ? 1 : 0;//Toplam kalan ay hesabı

                    notPaidMonths += ((item.PaidPrice < item.PayablePrice) && (item.PaymentDate < DateTime.Now)) ? 1 : 0;
                    totalNotPaid += ((item.PaidPrice < item.PayablePrice) && (item.PaymentDate < DateTime.Now)) ? item.PayablePrice - item.PaidPrice : 0;
                }
                labelRemainderPrice.Text = totalRemainderPrice.ToString();
                labelRemainderMonths.Text = totalRemainderMonths.ToString();
                labelPayableInstalmentsCount.Text = notPaidMonths.ToString();

                int firstPayInstalmentIndex = (saleInstalments[payInstalmentIndex].PaidPrice > 0) ? payInstalmentIndex + 1 : payInstalmentIndex;

                labelLastDelayInstalment.Text = ((int)(DateTime.Now - saleInstalments[firstPayInstalmentIndex].PaymentDate).TotalDays).ToString();

                labelPayablePrice.Text = ((saleInstalments[payInstalmentIndex].PayablePrice - saleInstalments[payInstalmentIndex].PaidPrice) + totalNotPaid).ToString();

                labelPaymentDate.Text = saleInstalments[payInstalmentIndex].PaymentDate.Date.ToString();

                datePaidDate.DateTime = DateTime.Now;
            }
        }

        private void navButton1_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            int paymentPrice = Convert.ToInt32(textEditPrice.Text);
            int remainingPrice = 0;
            for (int i = 0; i <= payInstalmentIndex + 1; i++)
            {
                remainingPrice = (saleInstalments[i].PaidPrice + paymentPrice) - saleInstalments[i].PayablePrice;//Artacak tutar hesabı
                saleInstalments[i].PaidPrice += paymentPrice - remainingPrice;
                saleInstalments[i].PaidDate = datePaidDate.DateTime;

                instalmentService.Update(saleInstalments[i]);

                paymentPrice = remainingPrice;
            }

            /*if (remainingPrice > 0)
            {
                remainingPrice = ((saleInstalments[payInstalmentIndex].PaidPrice + paymentPrice) < saleInstalments[payInstalmentIndex].PayablePrice) ? 0 : //Artan ücret - ye düşmemesi için
                         (saleInstalments[payInstalmentIndex].PaidPrice + paymentPrice) - saleInstalments[payInstalmentIndex].PayablePrice;//Artacak tutar hesabı
                saleInstalments[payInstalmentIndex].PaidPrice += paymentPrice - remainingPrice;
                saleInstalments[payInstalmentIndex].PaidDate = datePaidDate.DateTime;

                instalmentService.Update(saleInstalments[payInstalmentIndex]);

                paymentPrice = remainingPrice;
            }*/
            if (paymentPrice > 0)//Tutar artmış ise
            {
                for (int i = saleInstalments.Length - 1; i > 0; i--)//Son taksitten başla 
                {
                    if (paymentPrice < 1)
                        break;

                    remainingPrice = ((saleInstalments[i].PaidPrice + paymentPrice) < saleInstalments[i].PayablePrice) ? 0 : //Artan ücret - ye düşmemesi için
                        (saleInstalments[i].PaidPrice + paymentPrice) - saleInstalments[i].PayablePrice;

                    saleInstalments[i].PaidPrice += paymentPrice - remainingPrice;
                    saleInstalments[i].PaidDate = datePaidDate.DateTime;

                    instalmentService.Update(saleInstalments[i]);

                    paymentPrice = remainingPrice;
                }
            }
            this.DialogResult = DialogResult.OK;
        }

        private void navButton3_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
