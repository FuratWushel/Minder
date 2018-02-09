using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Minder.Models
{
    public class Message
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public DateTime TimeSent { get; set; }
        public string Subject { get; set; }
        public string Content { get; set; }
        public int SenderId { get; set; }
        public virtual ApplicationUser Sender { get; set; }
        public int ReceiverId { get; set; }
        public virtual ApplicationUser Receiver { get; set; }
        public bool IsEdited { get; set; }
    }
}