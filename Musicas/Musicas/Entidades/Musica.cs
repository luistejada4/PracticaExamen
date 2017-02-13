using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Musicas.Entidades
{
    public class Musicas
    {
        [Key]
        public int MusicaID { get; set; }
        public string Artista { get; set; }
        public string Nombre { get; set; }
        public DateTime Fecha { get; set; }

        public Musicas()
        {

        }
        public Musicas(int musicaId, string artista, string nombre, DateTime fecha)
        {
            this.MusicaID = musicaId;
            this.Artista = artista;
            this.Nombre = nombre;
            this.Fecha = fecha;
        }
    }
}
