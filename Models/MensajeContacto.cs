using System.ComponentModel.DataAnnotations;

namespace LuxeStep.Models
{
    public class MensajeContacto
    {
        public int MensajeContactoId { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio")]
        [Display(Name = "Nombre Completo")]
        public string NombreCompleto { get; set; } = string.Empty;

        [Required(ErrorMessage = "El correo es obligatorio")]
        [EmailAddress(ErrorMessage = "Correo inválido")]
        [Display(Name = "Correo Electrónico")]
        public string Correo { get; set; } = string.Empty;

        [Required(ErrorMessage = "El mensaje es obligatorio")]
        [DataType(DataType.MultilineText)]
        [Display(Name = "Mensaje")]
        public string Mensaje { get; set; } = string.Empty;

        public DateTime FechaEnvio { get; set; } = DateTime.UtcNow;
    }
}
