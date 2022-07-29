using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CREDITOS_DOÑALOLA.Models
{
    public class PersonaCE
    {
        [Required]
        [Display(Name = "Ingrese nombre")]
        public string Nombre { get; set; }
        [Required]
        [Display(Name = "Ingrese apellido paterno")]
        public string ApellidoPaterno { get; set; }
        [Required]
        [Display(Name = "Ingrese apellido materno")]
        public string ApellidoMaterno { get; set; }
        [Required]
        [Display(Name = "Ingrese cantidad prestada")]
        public decimal CantidadPrestada { get; set; }
        [Required]
        [Display(Name = "Ingrese telefono")]
        public string Telefono { get; set; }
        [Required]
        [Display(Name = "Ingrese email")]
        public string Email { get; set; }
        [Required]
        [Display(Name = "Ingrese dia de cobro")]
        public short DiaCobro { get; set; }
        [Required]
        [Display(Name = "Ingrese meses del prestamo")]
        public int MesesPrestamo { get; set; }
        [Required]
        [Display(Name = "Ingrese intereses")]

        public short Intereses { get; set; }
    }
    [MetadataType(typeof(PersonaCE))]

    public partial class Persona
    {
        public string NombreCompleto { get { return Nombre + " " + ApellidoPaterno + " " + ApellidoMaterno; } }

        public float MontoDebe { get; set; }
        public float MontoPagado { get; set; }
        public float MontoFinal { get; set; }


    }
}