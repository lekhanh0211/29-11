using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace it.DAL.Model
{
    public class BillDetail
    {
        [Key]
        public int bill_id { get; set; }
        public float price { get; set; }
        public int quạntity { get; set; }
    }
}
