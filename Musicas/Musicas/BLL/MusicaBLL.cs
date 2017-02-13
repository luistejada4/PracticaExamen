using Musicas.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Musicas.BLL
{
    public class MusicaBLL
    {
        public static int Guardar(Entidades.Musicas m)
        {
            using(var db = new MusicasDB())
            {
                try
                {
                    if(Buscar(m.MusicaID) == null)
                    {
                        db.Musicas.Add(m);
                        db.SaveChanges();
                        return m.MusicaID;
                    }
                    else
                    {
                        db.Entry(m).State = System.Data.Entity.EntityState.Modified;
                        db.SaveChanges();
                        return m.MusicaID;
                    }
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }
        public static Entidades.Musicas Buscar(int id)
        {
            using (var db = new MusicasDB())
            {
                try
                {
                    Entidades.Musicas m = db.Musicas.Find(id);
                    if(m != null)
                    {
                        db.SaveChanges();
                        return m;
                    }
                    else
                    {
                        return null;
                    }
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }
        public static bool Eliminar(int id)
        {
            using(var db = new MusicasDB())
            {
                try
                {
                    Entidades.Musicas m = Buscar(id);
                    if(m != null)
                    {
                        db.Entry(m).State = System.Data.Entity.EntityState.Deleted;
                        db.SaveChanges();
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                }
                catch (Exception)
                {

                    throw;
                }
            }
        }
        public static List<Entidades.Musicas> GetListArtista(string artista)
        {
            using(var db = new MusicasDB())
            {
                try
                {
                   return db.Musicas.Where(m => m.Artista.Contains(artista)).ToList();
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }
        public static List<Entidades.Musicas> GetListNombre(string nombre)
        {
            using (var db = new MusicasDB())
            {
                try
                {
                    return db.Musicas.Where(m => m.Nombre.Contains(nombre)).ToList();
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }
        public static List<Entidades.Musicas> GetListFecha(DateTime desde, DateTime hasta)
        {
            using (var db = new MusicasDB())
            {
                try
                {
                    return db.Musicas.Where(m => m.Fecha >= desde.Date && m.Fecha <= hasta.Date).ToList();
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }
    }
}
