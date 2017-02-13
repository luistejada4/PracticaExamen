using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ultimo.DAL;
using Ultimo.Entidades;

namespace Ultimo
{
    public class PersonaBLL
    {
        public static bool Guardar(Personas p)
        {
            using (var db = new UltimoDB())
            {
                try
                {
                    db.Personas.Add(p);
                    db.SaveChanges();
                    return true;
                }
                catch (Exception)
                {

                    throw;
                }
            }
            return false;
        }
        public static Personas Buscar(int id)
        {
            using (var db = new UltimoDB())
            {
                try
                {
                    return db.Personas.Find(id);

                }
                catch (Exception)
                {

                    throw;
                }
                return null;
            }
        }
        public static List<Personas> GetList()
        {
            using (var db = new UltimoDB())
            {
                try
                {
                    return db.Personas.ToList();
                }
                catch (Exception)
                {

                    throw;
                }
                return null;
            }
        }
        public static bool Eliminar(Personas p)
        {
            using (var db = new UltimoDB())
            {


                try
                {
                    db.Entry(p).State = EntityState.Deleted;
                    db.SaveChanges();
                }
                catch (Exception)
                {

                    throw;
                }
            }
            return false;
        }
    }
}
