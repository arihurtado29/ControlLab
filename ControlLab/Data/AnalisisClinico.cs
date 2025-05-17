using System.ComponentModel.DataAnnotations;

namespace ControlLab.Data
{
    public class AnalisisClinico
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "El nombre es obligatorio.")]
        [StringLength(30, ErrorMessage = "El nombre no puede exceder los 30 caracteres.")]
        public string? Estudio { get; set; }
        [Required(ErrorMessage = "La fecha es obligatoria.")]
        [DataType(DataType.Date, ErrorMessage = "El formato de fecha no es válido.")]
        public DateTime Fecha { get; set; }
        [Required(ErrorMessage = "Debes seleeccionar un tipo de muestra.")]
        public string? TipodeMuestra { get; set; }
        [Required(ErrorMessage = "El resultado es obligatorio.")]
        [StringLength(400, ErrorMessage = "El resultado no puede exceder los 400 caracteres.")]
        public string? Resultados { get; set; }
    }
}
