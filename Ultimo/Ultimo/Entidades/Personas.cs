using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ultimo.Entidades
{
    public class Personas
    {
        [Key]
        public int PersonaId { get; set; }
        public string Nombre { get; set; }

        public Personas()
        {

        }
        public Personas(int id, string nombre)
        {
            this.PersonaId = id;
            this.Nombre = nombre;
        }
    }
}
