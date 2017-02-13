using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ultimo.Entidades;

namespace Ultimo.DAL
{
    public class UltimoDB : DbContext
    {
        public UltimoDB() : base("ConStr")
        {

        }
        public DbSet<Personas> Personas { get; set; }
    }
}
