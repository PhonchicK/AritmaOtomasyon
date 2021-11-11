using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IHYAOtomasyon.Others.Google_Drive
{
    public partial class ProgressForm : Form
    {
        public ProgressForm()
        {
            InitializeComponent();
        }
        public async void SetProgressValue(int val, string text)
        {
            progressBarControl1.Position = val;
            labelControl1.Text = text;
        }
    }
}
