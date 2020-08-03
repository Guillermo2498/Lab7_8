using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace CapaDatos
{
     public class Idioma
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CodigoIdioma { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(30)]
        public string DescripcionIdioma { get; set; }
    }
}
