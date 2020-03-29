using System;
using System.ComponentModel.DataAnnotations;

namespace Gremio.Models
{
    public class Afiliado
    {
        [Key]
        public int Id { get; set; }
        public string DNI { get; set; }
        public string   Nombre  {get; set; }
        public string   Direccion {get; set; }
        public string   localidad {get; set; }
        public string   telefono {get; set; }
        public string   email {get; set; }
        public string   control {get; set; }
        
                

    }
}