using System;
using System.ComponentModel.DataAnnotations;

namespace Gremio.Models
{
    public class Establecimiento
    {
        [Key]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Localidad {get; set; }

        public string Numero {get; set; }


    }
}