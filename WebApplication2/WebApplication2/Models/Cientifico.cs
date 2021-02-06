using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class Cientifico
    {
        public int ID { get; set; }
        public string DNI { get; set; }
        public string nom { get; set; }        
        public Asignado_A asignado { get; set; }
    }
}
