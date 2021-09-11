using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Comment
    {
        [Key]
        public int CommentId { get; set; }
        public string CommentUserName { get; set; }
        public string Content { get; set; }
        public string Title { get; set; }
        public DateTime CommentDate { get; set; }
        public bool Status { get; set; }

    }
}
