using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chat.Models
{
    public class Messages
    {
        [Key]
        public int MessageID { get; set; }
        [ForeignKey("Conversation")]
        public int? ConversationID { get; set; }

        [MaxLength()]
        public string Message { get; set; }
        [MaxLength(10, ErrorMessage = "Message From maximum length is 10")]
        public string MessageFrom { get; set; }
        public int? MessageUserID { get; set; }
        public DateTime? MessageDate { get; set; }
        public virtual Conversation Conversations {get; set;}

    }
}
