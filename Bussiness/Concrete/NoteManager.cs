using Bussiness.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness.Concrete
{
    public class NoteManager : INoteService
    {
        private INoteDal noteDal;

        public NoteManager(INoteDal noteDal)
        {
            this.noteDal = noteDal;
        }

        public int Add(Note note)
        {
            return noteDal.Add(note).ID;
        }

        public void Delete(Note note)
        {
            noteDal.Delete(note);
        }

        public List<Note> GetAll()
        {
            return noteDal.GetAll();
        }

        public Note GetByID(int id)
        {
            return noteDal.Get(n => n.ID == id);
        }

        public List<Note> GetTodayNotes()
        {
            DateTime date = DateTime.Now.Date;
            return noteDal.GetAll(n => n.Date == date);
        }

        public void Update(Note note)
        {
            noteDal.Update(note);
        }
    }
}
