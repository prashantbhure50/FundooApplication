using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CommonLayer.DataBase
{
  public class Note
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int NotesId { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public string Reminder { get; set; }
        public string Colour { get; set; }
        public string Archive { get; set; }
        public string PinNote { get; set; }
        public string Trash { get; set; }
        public int LabelId { get; set; }
        public int UserId { get; set; }
        public Users user { get; set; }

        public List<LabelNotes> LabelNotes { get; set; }
    

    }
}
