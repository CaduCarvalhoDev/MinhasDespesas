using System.ComponentModel.DataAnnotations;

namespace MinhasDespesas.Models
{
    public class Categoria
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "O nome da categoria é obrigatório")]
        [StringLength(50, ErrorMessage = "O nome não pode passar de 50 caracteres")]
        public string Nome { get; set; }

        [StringLength(100, ErrorMessage = "A descrição não pode passar de 100 caracteres")]
        public string? Descricao { get; set; }
    }
}