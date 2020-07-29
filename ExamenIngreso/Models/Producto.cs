using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ExamenIngreso.Models
{
    public class Producto
    {
        [Required]
        public string SKU { get; set; }

        [Display(Name = "Nombre")]
        [StringLength(40, ErrorMessage = "El número de caracteres de {0} debe ser al menos {2}.", MinimumLength = 3)]
        public string Nombre { get; set; }

        [Display(Name = "Descripción")]
        [StringLength(40, ErrorMessage = "El número de caracteres de {0} debe ser al menos {2}.", MinimumLength = 10)]
        public string Descripción { get; set; }

        [Display(Name = "Valor")]
        [Required(ErrorMessage = "Debe Ingresar el {0}")]
        [DataType(DataType.Currency)]
        public decimal Valor { get; set; }

        [Display(Name = "Tienda")]
        [StringLength(40, ErrorMessage = "El número de caracteres de {0} debe ser al menos {2}.", MinimumLength = 3)]
        public string Tienda { get; set; }

        [Display(Name = "Imagen")]
        public string Imagen { get; set; }

    }
}