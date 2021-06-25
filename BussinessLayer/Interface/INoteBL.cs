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
        void DeleteNote(int id);
        void UpdateNotes(Note note);
        void UpdatePin(int id, string pinNote);
        void UpdateReminder(Note note);
        void UpdateColour(Note note);
        void UpdateTrash(Note note);
        void UpdateArchive(Note note);
    }
}
