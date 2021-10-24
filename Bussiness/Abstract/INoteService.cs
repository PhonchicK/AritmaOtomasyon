using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness.Abstract
{
    public interface INoteService
    {
        List<Note> GetAll();
        List<Note> GetTodayNotes();
        Note GetByID(int id);
        int Add(Note note);
        void Delete(Note note);
        void Update(Note note);
    }
}
