using System.ComponentModel.DataAnnotations;

namespace ControlLab.Data
{
    public class Quimico
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio.")]
        [StringLength(50, ErrorMessage = "El nombre no puede exceder los 50 caracteres.")]
        [RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "El nombre solo puede contener letras y espacios.")]
        public string? Nombre { get; set; }

        [Required(ErrorMessage = "La cédula es obligatoria.")]
        [StringLength(20, ErrorMessage = "La cédula no puede exceder los 20 caracteres.")]
        [RegularExpression(@"^\d+$", ErrorMessage = "La cédula solo puede contener números.")]
        public string? Cedula { get; set;  }


        virtual public ICollection<AnalisisClinico>? AnalisisClinicos { get; set; }
    }
}
