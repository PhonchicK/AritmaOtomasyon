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

namespace IHYAOtomasyon.Views.NoteForms
{
    public partial class NewNoteForm : DevExpress.XtraEditors.XtraForm
    {
        INoteService noteService;
        public NewNoteForm()
        {
            InitializeComponent();
            noteService = InstanceFactory.GetInstance<INoteService>();
        }

        private void navButton1_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            noteService.Add(new Note() 
            {
                Name = textName.Text,
                Date = dateNote.DateTime.Date,
                Content = textContent.Text
            });
            this.DialogResult = DialogResult.OK;
        }

        private void NewNoteForm_Load(object sender, EventArgs e)
        {
            dateNote.DateTime = DateTime.Now.Date;
        }

        private void navButton3_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
