using System;
using System.Collections.Generic;
using System.Text;

namespace CommonLayer.RequestModle
{
   public class ReqNote
    {
        public string Title { get; set; }
        public string Body { get; set; }
        public string Reminder { get; set; }
        public string Color { get; set; }
        public string Archive { get; set; }
        public string Trash { get; set; }
        public string Pin { get; set; }
        public int UserId { get; set; }
    }
}
