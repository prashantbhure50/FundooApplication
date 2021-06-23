using BussinessLayer.Interface;
using CommonLayer.DataBase;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace FundooApplication.Controllers
{
    [Authorize]
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
        public IActionResult GetNoteById(int id)
        {
            Note note = this.noteBl.GetNoteById(id);
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
        public IActionResult DeleteNote(int id)
        {
            Note note = this.noteBl.GetNoteById(id);
            if (note == null)
            {
                return NotFound("The Employee record couldn't be found.");
            }
            this.noteBl.DeleteNote(note);
            return NoContent();
        }
        //[HttpPut("UpdateNote")]
        //public ActionResult UpdateNotes(Note note,Note entity)
        //{
        //    try
        //    {
        //        this.userBl.UpdateNotes(note,entity);
        //        return this.Ok(new { success = true, message = "Notes Added Successful " });
        //    }

        //    catch (Exception e)
        //    {
        //        return this.BadRequest(new { success = false, message = e.Message });
        //    }
        //}
    }
}
