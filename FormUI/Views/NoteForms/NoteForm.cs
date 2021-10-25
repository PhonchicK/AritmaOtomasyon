using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using Bussiness.Abstract;
using Business.DependencyResolvers.Ninject;
using DevExpress.XtraGrid.Views.Grid;
using Entities.Concrete;

namespace IHYAOtomasyon.Views.NoteForms
{
    public partial class NoteForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        INoteService noteService;
        public NoteForm()
        {
            InitializeComponent();
            noteService = InstanceFactory.GetInstance<INoteService>();
        }
        void bbiPrintPreview_ItemClick(object sender, ItemClickEventArgs e)
        {
            gridControl.ShowRibbonPrintPreview();
        }

        private void NoteForm_Load(object sender, EventArgs e)
        {
            gridControl.DataSource = noteService.GetAll();
        }

        NewNoteForm newNoteForm;
        private void bbiNew_ItemClick(object sender, ItemClickEventArgs e)
        {
            newNoteForm = new NewNoteForm();
            if(newNoteForm.ShowDialog() == DialogResult.OK)
                gridControl.DataSource = noteService.GetAll();
        }

        private void bbiDelete_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (((GridView)gridControl.MainView).SelectedRowsCount > 0)
            {
                int[] selRows = ((GridView)gridControl.MainView).GetSelectedRows();
                Note selectedNote = ((Note)(((GridView)gridControl.MainView).GetRow(selRows[0])));
                if (MessageBox.Show(selectedNote.Name +
                    " isimli notu silmek istiyor musunuz ?", "Uyarı",
                    MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    noteService.Delete(selectedNote);
                    gridControl.DataSource = noteService.GetAll();
                }
            }
        }

        EditNoteForm editNoteForm;
        private void bbiEdit_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (((GridView)gridControl.MainView).SelectedRowsCount > 0)
            {
                int[] selRows = ((GridView)gridControl.MainView).GetSelectedRows();
                int noteID = ((Note)(((GridView)gridControl.MainView).GetRow(selRows[0]))).ID;
                editNoteForm = new EditNoteForm(noteID);
                if(editNoteForm.ShowDialog() == DialogResult.OK)
                {
                    gridControl.DataSource = noteService.GetAll();
                }
            }
        }

        private void gridControl_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (((GridView)gridControl.MainView).SelectedRowsCount > 0)
            {
                int[] selRows = ((GridView)gridControl.MainView).GetSelectedRows();
                int noteID = ((Note)(((GridView)gridControl.MainView).GetRow(selRows[0]))).ID;
                editNoteForm = new EditNoteForm(noteID);
                if (editNoteForm.ShowDialog() == DialogResult.OK)
                {
                    gridControl.DataSource = noteService.GetAll();
                }
            }
        }
    }
}