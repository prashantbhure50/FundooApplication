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
            try
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
            }catch(Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public void UpdatePin(int id,string pinNote)
        {
            try
            {
                var result = _userDbContext.Notes.FirstOrDefault(n => n.NotesId == id);
                if (result == null)
                {
                    throw new Exception("No such Pin Exist");
                }
                else
                {
                    result.PinNote = pinNote;
                    _userDbContext.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public void UpdateReminder(Note note)
        {
            try
            {
                var result = _userDbContext.Notes.FirstOrDefault(n => n.NotesId == note.NotesId);
                if (result == null)
                {
                    throw new Exception("No such Pin Exist");
                }
                else
                {
                    result.Reminder = note.Reminder;
                    _userDbContext.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public void UpdateColour(Note note)
        {
            try
            {
                var result = _userDbContext.Notes.FirstOrDefault(n => n.NotesId == note.NotesId);
                if (result == null)
                {
                    throw new Exception("No such Pin Exist");
                }
                else
                {
                    result.Colour = note.Colour;
                    _userDbContext.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public void UpdateTrash(Note note)
        {
            try
            {
                var result = _userDbContext.Notes.FirstOrDefault(n => n.NotesId == note.NotesId);
                if (result == null)
                {
                    throw new Exception("No such Pin Exist");
                }
                else
                {
                    result.Trash = note.Trash;
                    _userDbContext.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public void UpdateArchive(Note note)
        {
            try
            {
                var result = _userDbContext.Notes.FirstOrDefault(n => n.NotesId == note.NotesId);
                if (result == null)
                {
                    throw new Exception("No such Pin Exist");
                }
                else
                {
                    result.Archive = note.Archive;
                    _userDbContext.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }


    }
}
