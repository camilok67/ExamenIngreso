using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ExamenIngreso.Models
{
    public class Tienda
    {
        public int Id { get; set; }

        [Display(Name = "Nombre")]
        [StringLength(40, ErrorMessage = "El número de caracteres de {0} debe ser al menos {2}.", MinimumLength = 3)]
        public int Nombre { get; set; }

        [Display(Name = "Fecha de Apertura")]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]
        public string FechaApertura { get; set; }
    }
}