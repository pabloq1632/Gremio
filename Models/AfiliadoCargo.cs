using System;
using System.ComponentModel.DataAnnotations;

namespace Gremio.Models
{
    public class AfiliadoCargo
    {
        [Key]
        public int Id { get; set; }

        public virtual Afiliado Afiliado {get; set;}
        public virtual Cargo Cargo { get; set; }

        public DateTime FechaAlta { get; set; }
        public double Tipo { get; set; }
        public string Escuela { get; set; }
    
    }
}