using System.ComponentModel.DataAnnotations;

namespace ProjetoMVC.Models
{
    public class Produto
    {
        public Guid ProdutoId { get; set; }

        [Display(Name = "Nome do Produto")]
        [Required(ErrorMessage = "O campo Nome do Produto é obrigatório.")]
        [StringLength(100, ErrorMessage = "O Nome do Produto deve ter no máximo 100 caracteres.")]
        [MinLength(3, ErrorMessage = "O Nome do Produto deve ter no mínimo 3 caracteres.")]
        [MaxLength(100, ErrorMessage = "O Nome do Produto deve ter no máximo 100 caracteres.")]
        public string Nome { get; set; }

        [Display(Name = "Preço")]
        [Required(ErrorMessage = "O campo Preço é obrigatório.")]
        [Range(0.01, 999999.99, ErrorMessage = "O Preço deve estar entre R$ 0,01 e R$ 999.999,99.")]
        public double Preco { get; set; }

        [Display(Name = "Estoque")]
        [Required(ErrorMessage = "O campo Estoque é obrigatório.")]
        [Range(0, int.MaxValue, ErrorMessage = "A quantidade em estoque deve ser um número positivo.")]
        public int QtdadeEstoque { get; set; }

        [Display(Name = "Data de Cadastro")]
        [Required(ErrorMessage = "O campo Data de Cadastro é obrigatório.")]
        public DateTime DataCadastro { get; set; }

        [Display(Name = "Categoria")]
        [Required(ErrorMessage = "O campo Categoria é obrigatório.")]
        public Guid CategoriaId { get; set; }
        public Categoria? Categoria { get; set; } // Navegação para a categoria

    }
}
