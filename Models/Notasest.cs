using Microsoft.Build.Framework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using RequiredAttribute = System.ComponentModel.DataAnnotations.RequiredAttribute;

namespace ProyectoMVCCRUD.Models
{
    public partial class Notasest
    {
        [DisplayName("Id")]
        public int Id { get; set; }

        [DisplayName("Carnet")]
        [Required]
        public string? Carnet { get; set; }

        [DisplayName("Apellidos")]
        [Required]
        public string? Apellido { get; set; }

        [DisplayName("Nombres")]
        [Required]
        public string? Nombre { get; set; }

        [DisplayName("Parcial I")]
        [Required]
        [Range(0, 35)]
        public short? Ipn { get; set; }

        [DisplayName("Parcial II")]
        [Required]
        [Range(0, 35)]
        public short? Iipn { get; set; }

        [DisplayName("Sistemáticos")]
        [Required]
        [Range(0, 30)]
        public short? Sist { get; set; }

        [DisplayName("Proyecto")]
        [Required]
        [Range(0, 35)]
        public short? Proyec { get; set; }

        [DisplayName("Nota Final")]
        public short? Nf { get; set; }
    }
}
