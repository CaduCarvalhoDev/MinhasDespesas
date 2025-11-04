using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MinhasDespesas.Models
{
    public class Despesa
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "A descrição é obrigatória")]
        [StringLength(100, ErrorMessage = "A descrição não pode passar de 100 caracteres")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "O valor é obrigatório")]
        [Column(TypeName = "decimal(10, 2)")] // Define o tipo no banco (bom para dinheiro)
        [Range(0.01, 1000000.00, ErrorMessage = "O valor deve ser maior que zero")]
        public decimal Valor { get; set; }

        [Required(ErrorMessage = "A data é obrigatória")]
        [DataType(DataType.Date)]
        public DateTime Data { get; set; }

        // --- Relacionamento com Categoria ---

        [Required(ErrorMessage = "A categoria é obrigatória")]
        public int CategoriaId { get; set; } // Chave Estrangeira

        [ForeignKey("CategoriaId")]
        public Categoria? Categoria { get; set; } // Propriedade de Navegação
    }
}