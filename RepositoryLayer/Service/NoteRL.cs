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
                  .FirstOrDefault(e => e.NotesId == id);
        }
        public Note AddNotes(Note note)
        {
            _userDbContext.Notes.Add(note);
            _userDbContext.SaveChanges();
            return note;
        }
        public void DeleteNote(int id)
        {
            var result = _userDbContext.Notes.FirstOrDefault(e => e.NotesId == id);
            if (result == null)
            {
                throw new Exception("No Note Exist");
            }
            else
            {
                _userDbContext.Notes.Remove(result);
                _userDbContext.SaveChanges();
           
            }
        }
        public void UpdateNotes(Note note)
        {
            var result = _userDbContext.Notes.FirstOrDefault(n => n.NotesId == note.NotesId);
            if (result == null)
            {
                throw new Exception("No such Notes Exist");
            }
            else
            {
                result.Title = note.Title;
                result.Body = note.Body;
                _userDbContext.SaveChanges();
            }
        }

      
    }
}
