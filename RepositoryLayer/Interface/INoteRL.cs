using CommonLayer.DataBase;
using CommonLayer.RequestModle;
using System.Collections.Generic;

namespace RepositoryLayer.Interface
{
     public interface INoteRL
    {
        IEnumerable<Note> GetAll();
        Note GetNoteById(int id);
        void AddNotes(ReqNote notes);
        void DeleteNote(int id);
        void UpdateNotes(Note note);
        void UpdatePin(Note note);
        void UpdateReminder(Note note);
        void UpdateColour(Note note);
        void UpdateTrash(Note note);
        void UpdateArchive(Note note);
     }
}