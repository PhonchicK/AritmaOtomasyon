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

namespace IHYAOtomasyon.Views.NoteForms
{
    public partial class EditNoteForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        Note selectedNote;
        INoteService noteService;
        public EditNoteForm(int noteID)
        {
            InitializeComponent();
            noteService = InstanceFactory.GetInstance<INoteService>();
            selectedNote = noteService.GetByID(noteID);
        }

        private void EditNoteForm_Load(object sender, EventArgs e)
        {
            textName.Text = selectedNote.Name;
            dateNote.DateTime = selectedNote.Date;
            textContent.Text = selectedNote.Content;
        }

        private void bbiReset_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            textName.Text = selectedNote.Name;
            dateNote.DateTime = selectedNote.Date;
            textContent.Text = selectedNote.Content;
        }

        private void bbiSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            selectedNote.Name = textName.Text;
            selectedNote.Date = dateNote.DateTime.Date;
            selectedNote.Content = textContent.Text;

            noteService.Update(selectedNote);
        }

        private void bbiSaveAndClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            selectedNote.Name = textName.Text;
            selectedNote.Date = dateNote.DateTime.Date;
            selectedNote.Content = textContent.Text;

            noteService.Update(selectedNote);
            this.DialogResult = DialogResult.OK;
        }

        private void bbiDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show(selectedNote.Name +
                    " isimli notu silmek istiyor musunuz ?", "Uyarı",
                    MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                noteService.Delete(selectedNote);
                this.DialogResult = DialogResult.OK;
            }
        }

        private void bbiClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}