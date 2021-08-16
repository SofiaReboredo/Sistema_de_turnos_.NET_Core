using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Turnos.Models
{
    public class Medico
    {
        [Key]
        public int IdMedico { get; set; }
        [Required(ErrorMessage = "Debe ingresar un nombre")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "Debe ingresar un apellido")]
        public string Apellido { get; set; }
        [Required(ErrorMessage = "Debe ingresar una dirección")]
        [Display(Name = "Dirección")]
        public string Direccion { get; set; }
        [Required(ErrorMessage = "Debe ingresar un email")]
        [Display(Name = "E-mail")]
        [EmailAddress(ErrorMessage = "No es una dirección de email válida")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Debe ingresar un horario de atención desde el cual atenderá")]
        [Display(Name = "Horario desde")]
        [DataType(DataType.Time)]
        [DisplayFormat(DataFormatString = "{0:hh:mm tt}", ApplyFormatInEditMode = true)]
        public DateTime HorarioAtencionDesde { get; set; }
        [Required(ErrorMessage = "Debe ingresar un horario de atención hasta el cual atenderá")]
        [Display(Name = "Horario hasta")]
        [DataType(DataType.Time)]
        [DisplayFormat(DataFormatString = "{0:hh:mm tt}", ApplyFormatInEditMode = true)]
        public DateTime HorarioAtencionHasta { get; set; }
        [Required(ErrorMessage = "Debe ingresar una especialidad")]
        public List<MedicoEspecialidad> MedicoEspecialidad { get; set; }
        public List<Turno> Turno {get; set;}
    }
}