using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace it.DAL.Model
{
    public class Product
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }
        public int cat_id { get; set; }
        public string desc { get; set; }
        public float price { get; set; }
        public float salePrice { get; set; }
    }
}
