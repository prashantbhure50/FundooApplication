using BussinessLayer.Interface;
using CommonLayer.DataBase;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace FundooApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NotesController : ControllerBase
    {
        INoteBL noteBl;
        public NotesController(INoteBL noteBl)
        {
            this.noteBl = noteBl;
        }
        [HttpGet("GetAllNotes")]
        public IActionResult Get()
        {
            IEnumerable<Note> note = this.noteBl.GetAll();
            return Ok(note);
        }
        [HttpGet("GetNoteById")]
        public IActionResult GetNotes(Note notes)
        {
            Note note = this.noteBl.GetNoteById(notes.NotesId);
            if (note == null)
            {
                return NotFound("The Note couldn't be found.");
            }
            return Ok(note);
        }
        [HttpPost]
        public ActionResult AddNotes(Note note)
        {
            try
            {
                this.noteBl.AddNotes(note);
                return this.Ok(new { success = true, message = "Notes Added Successful " });
            }

            catch (Exception e)
            {
                return this.BadRequest(new { success = false, message = e.Message });
            }
        }
        [HttpDelete("DeleteNote")]
        public IActionResult DeleteNote(Note note)
        {
            try
            {
                this.noteBl.DeleteNote(note.NotesId);
                return Ok(new { success = true, message = "Notes Deleted " });
            }
            catch (Exception e)
            {
                return BadRequest(new { success = false, message = "Note is null" });
            }
        }
        [HttpPut("UpdateNote")]
        public ActionResult UpdateNotes(Note note)
        {
            try
            {
                this.noteBl.UpdateNotes(note);
                return Ok(new { success = true, message = "Notes Updates Successfully " });

            }
            catch (Exception e)
            {
                return BadRequest(new { success = false, message = "Note is null" });
            }
        }
    }
}
