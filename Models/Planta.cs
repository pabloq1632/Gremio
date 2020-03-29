using System;
using System.ComponentModel.DataAnnotations;

namespace Gremio.Models
{
    public class Planta
    {
        [Key]
        public int Id { get; set; }
        public string Tipo { get; set; }
                

    }
}