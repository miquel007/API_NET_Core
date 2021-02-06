using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Cliente
    {
        public int ID { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public int DNI { get; set; }
        public DateTime fecha { get; set; }
        public ICollection<Videos> video { get; set; }
    }
}
