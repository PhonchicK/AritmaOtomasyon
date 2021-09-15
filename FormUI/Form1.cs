﻿using FormUI.Views.CustomerForms;
using FormUI.Views.SaleForms;
using MetroFramework.Forms;
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
    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            new CustomerForm().Show();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            new SaleForm().Show();
        }
    }
}