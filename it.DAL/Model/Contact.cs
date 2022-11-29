using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace it.DAL.Model
{
    public class Contact
    {
        [Key]
        public int id { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
        public string address { get; set; }

    }
}
