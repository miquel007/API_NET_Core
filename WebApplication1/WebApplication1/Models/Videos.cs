using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Videos
    {

        public int ID { get; set; }
        public string title { get; set; }
        public string director { get; set; }
        public Cliente cli_id { get; set; }
    }
}
