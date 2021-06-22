using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CommonLayer.DataBase
{
  public class LabelNotes
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int LabelId { get; set; }
        public int Label_Id { get; set; }
        public Label Label { get; set; }
        public int UserId { get; set; }
        public Users User { get; set; }
    }
}
