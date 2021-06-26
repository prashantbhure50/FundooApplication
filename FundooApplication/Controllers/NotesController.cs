﻿using BussinessLayer.Interface;
using CommonLayer.DataBase;
using CommonLayer.RequestModle;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

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
        [Authorize]
        [HttpPost]
        public ActionResult AddNotes(ReqNote note)
        {
            try
            {
               var id = User.Claims.FirstOrDefault(u => u.Type.ToString().Equals("UserID", StringComparison.OrdinalIgnoreCase));
                note.UserId = Int32.Parse(id.Value);
                if (note.UserId != null)
                {
                    this.noteBl.AddNotes(note);
                    return this.Ok(new { success = true, message = "Notes Added Successful " });
                }
                else
                {
                    return this.BadRequest(new { success = false, message = "No Such UserId Exist" });
                }
            }

            catch (Exception e)
            {
                return this.BadRequest(new { success = false, message = "No Such UserId Exist" });
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
        [HttpPut("UpdatePin")]
        public ActionResult UpdatePin(Note note)
        {
            try
            {
                this.noteBl.UpdatePin(note);
                return Ok(new { success = true, message = "Pin Updated Successfully " });

            }
            catch (Exception e)
            {
                return BadRequest(new { success = false, message = "Note is null" });
            }
        }
        [HttpPut("UpdateReminder")]
        public ActionResult UpdateReminder(Note note)
        {
            try
            {
                this.noteBl.UpdateReminder(note);
                return Ok(new { success = true, message = "Reminder Updated Successfully " });

            }
            catch (Exception e)
            {
                return BadRequest(new { success = false, message = "Note is null" });
            }
        }
        [HttpPut("UpdateColour")]
        public ActionResult UpdateColour(Note note)
        {
            try
            {
                this.noteBl.UpdateColour(note);
                return Ok(new { success = true, message = "Colour Updated Successfully " });

            }
            catch (Exception e)
            {
                return BadRequest(new { success = false, message = "Note is null" });
            }
        }
        [HttpPut("UpdateTrash")]
        public ActionResult UpdateTrash(Note note)
        {
            try
            {
                this.noteBl.UpdateTrash(note);
                return Ok(new { success = true, message = "Trash Updated Successfully " });

            }
            catch (Exception e)
            {
                return BadRequest(new { success = false, message = "Note is null" });
            }
        }
        [HttpPut("UpdateArchive")]
        public ActionResult UpdateArchive(Note note)
        {
            try
            {
                this.noteBl.UpdateArchive(note);
                return Ok(new { success = true, message = "Archive Updated Successfully " });

            }
            catch (Exception e)
            {
                return BadRequest(new { success = false, message = "Note is null" });
            }
        }
    }
}
