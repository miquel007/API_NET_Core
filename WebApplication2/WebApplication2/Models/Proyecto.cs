using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class Proyecto
    {
        public int ID { get; set; }
        public string nom { get; set; }
        public int horas { get; set; }

        public ICollection<Asignado_A> asignados { get; set; }
    }
}
