using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace CapaDatos
{
     public class GestionP
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CodigoPais { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(30)]
        public int Habitantes { get; set; }

        [StringLength(50)]
        public char Idioma { get; set; }

        [StringLength(50)]
        public int PIB { get; set; }

        [StringLength(50)]
        public int Superficie { get; set; }
        [StringLength(50)]
        public char Riesgo { get; set; }
        [StringLength(50)]
        public byte SujetoP { get; set; }


    }
}
