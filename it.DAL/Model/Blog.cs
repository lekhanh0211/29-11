using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace it.DAL.Model
{
    public class Blog
    {
        public int id { get; set; }
        public string name { get; set; }
        public string title { get; set; }
        public string content { get; set; }
        public bool status { get; set; }
    }
}
