using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chat.Models
{
    public class Conversation
    {

        [Key]
        public int ConversationID { get; set; }
        [ForeignKey("Visitor")]
        public int? VisitorID { get; set; }

        [ForeignKey("Operator")]
        public int? OperatorID { get; set; }
 
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string Website { get; set; }
        public string PageName { get; set; }
        public string PageURL { get; set; }
        public virtual Visitor visitor { get; set; }
        public virtual Operator Operator { get; set; }
        public virtual ICollection<Messages> Conversations { get; set; }
    }
}
