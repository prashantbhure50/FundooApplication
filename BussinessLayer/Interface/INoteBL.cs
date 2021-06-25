using CommonLayer.DataBase;
using CommonLayer.RequestModle;
using System.Collections.Generic;

namespace BussinessLayer.Interface
{
    public interface INoteBL
    {
        IEnumerable<Note> GetAll();
        Note GetNoteById(int id);
        void AddNotes(ReqNote notes);
        void DeleteNote(int id);
        void UpdateNotes(Note note);
        void UpdatePin(int id, string pinNote);
        void UpdateReminder(Note note);
        void UpdateColour(Note note);
        void UpdateTrash(Note note);
        void UpdateArchive(Note note);
    }
}
