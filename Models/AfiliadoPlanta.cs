using System;
using System.ComponentModel.DataAnnotations;

namespace Gremio.Models
{
    public class AfiliadoPlanta
    {
        [Key]
        public int Id { get; set; }

        public virtual Afiliado Afiliado {get; set;}
        public virtual Planta   Planta { get; set; }

        public double Tipo { get; set; }
        public string Descripcion { get; set; }
    
    }
}