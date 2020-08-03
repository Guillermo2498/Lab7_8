using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
namespace CapaDatos
{
     public class ModeloPaises : DbContext
    {
        public ModeloPaises() : base("name=bdPaises")  //Constructor
        {

        }

        public virtual DbSet<Pais> Pais { get; set; }
        public virtual DbSet<Idioma> Idioma { get; set; }
        public virtual DbSet<GestionP> GestionP { get; set; }
    }
}
