using CommonLayer.DataBase;
using RepositoryLayer.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RepositoryLayer.Service
{
   public class NoteRL:INoteRL
    {
        private UserContext _userDbContext;
        public NoteRL(UserContext userDbContext)
        {
            _userDbContext = userDbContext;
        }
        public IEnumerable<Note> GetAll()
        {
            return _userDbContext.Notes.ToList();
        }
        public Note GetNoteById(int id)
        {
            return _userDbContext.Notes
                  .FirstOrDefault(e => e.UserId == id);
        }
        public Note AddNotes(Note note)
        {
            _userDbContext.Notes.Add(note);
            _userDbContext.SaveChanges();
            return note;
        }
        public void DeleteNote(Note note)
        {
            _userDbContext.Notes.Remove(note);
            _userDbContext.SaveChanges();
        }

        //public void UpdateNotes(Note note,Note entity)
        //{
        //    note.Title = entity.Title;
        //    note.Body = entity.Body;
        //    note.Reminder = entity.Reminder;
        //    note.Colour = entity.Colour;
        //    note.Archive = entity.Archive;
        //    note.PinNote = entity.PinNote;
        //    note.Trash = entity.Trash;
        //    note.UserId = entity.UserId;
        //    note.LabelId = entity.LabelId;
        //    _userDbContext.SaveChanges();

        //}
    }
}
