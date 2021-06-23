using CommonLayer.DataBase;
using System;
using System.Collections.Generic;
using System.Text;

namespace BussinessLayer.Interface
{
    public interface INoteBL
    {
        IEnumerable<Note> GetAll();
        Note GetNoteById(int id);
        Note AddNotes(Note note);
        void DeleteNote(Note note);
        //void UpdateNotes(Note note, Note entity);
    }
}
