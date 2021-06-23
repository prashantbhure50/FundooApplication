
using BussinessLayer.Interface;
using CommonLayer.DataBase;
using RepositoryLayer.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace BussinessLayer.Service
{
    public class NoteBL : INoteBL
    {
        INoteRL noteRl;
        public NoteBL(INoteRL noteRl)
        {
            this.noteRl = noteRl;
        }
        public IEnumerable<Note> GetAll()
        {
            return this.noteRl.GetAll();
        }
        public Note GetNoteById(int id)
        {
            return this.noteRl.GetNoteById(id);
        }
        public Note AddNotes(Note Note)
        {
            this.noteRl.AddNotes(Note);
            return Note;
        }

        public void DeleteNote(Note note)
        {
            this.noteRl.DeleteNote(note);
        }
        //public void UpdateNotes (Note note, Note entity)
        //{
        //    this.noteRl.UpdateNotes( note, entity);

        //}
    }
}
