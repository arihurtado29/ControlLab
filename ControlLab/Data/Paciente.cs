using System.ComponentModel.DataAnnotations;

namespace ControlLab.Data
{
    public class Paciente
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio.")]
        [StringLength(50, ErrorMessage = "El nombre no puede exceder los 50 caracteres.")]
        [RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "El nombre solo puede contener letras y espacios.")]
        public string? Nombre { get; set; }

        [Required(ErrorMessage = "La edad es obligatoria.")]
        [Range(0, int.MaxValue, ErrorMessage = "La edad debe ser un número positivo.")]
        public int Edad { get; set; }

        [Required(ErrorMessage = "Debes seleccionar el sexo.")]
        public string? Sexo { get; set; }

        [Required(ErrorMessage = "La fecha es obligatoria.")]
        [DataType(DataType.Date, ErrorMessage = "El formato de fecha no es válido.")]
        public DateTime Fecha { get; set; }

        [Required(ErrorMessage = "El teléfono es obligatorio")]
        [Phone(ErrorMessage = "El teléfono no es válido")]
        [Length(10, 10, ErrorMessage = "El teléfono de contener 10 dígitos")]
        public string? Telefono { get; set; }

        [Required(ErrorMessage = "El correo es obligatorio")]
        [EmailAddress(ErrorMessage = "El correo no es válido")]
        [StringLength(100, ErrorMessage = "El correo no puede exceder los 100 caracteres")]
        public string? Correo { get; set; }

        //Propiedad de navegación para la relación con AnalisisClinicos
        virtual public ICollection<AnalisisClinico>? AnalisisClinicos { get; set; }

    }
}
