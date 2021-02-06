using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class Asignado_A
    {
        public int ID { get; set; }
        public ICollection<Cientifico> Cientificos { get; set; }
        public Proyecto Proyecto { get; set; }
    }
}
