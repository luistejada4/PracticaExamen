using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Musicas.DAL
{
    public class MusicasDB : DbContext
    {
        public MusicasDB() : base("ConStr")
        {

        }
        public DbSet<Entidades.Musicas> Musicas { get; set; }
    }
}
