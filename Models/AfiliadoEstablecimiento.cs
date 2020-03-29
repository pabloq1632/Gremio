using System;
using System.ComponentModel.DataAnnotations;

namespace Gremio.Models
{
    public class AfiliadoEstablecimiento
    {
        [Key]
        public int Id { get; set; }

        public virtual Afiliado Afiliado {get; set;}
        public virtual Establecimiento  Establecimiento { get; set; }

        public DateTime FechaAlta { get; set; }
        public double Tipo { get; set; }
        public string Localidad { get; set; }
    
    }
}