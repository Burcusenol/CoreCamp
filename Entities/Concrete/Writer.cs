using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Writer
    {
        [Key]
        public int WriterId{ get; set; }
        public string WriterName { get; set; }
        public string WriterAbout{ get; set; }
        public int WriterImage{ get; set; }
        public string WriterMail{ get; set; }
        public string Password { get; set; }
        public bool Status { get; set; }
    }
}
