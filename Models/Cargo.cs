using System;
using System.ComponentModel.DataAnnotations;

namespace Gremio.Models
{
    public class Cargo
    {
        [Key]
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public string puntaje {get; set; }

    }
}