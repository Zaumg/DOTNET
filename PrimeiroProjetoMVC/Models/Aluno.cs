using System.ComponentModel.DataAnnotations;

namespace PrimeiroProjetoMVC.Models
{
    public class Aluno
    {
        public int Id { get; set;}

        [Required(ErrorMessage = "O nome é obrigatório")] //obrigatorio, torna colocar o nome obrigatório
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Nome deve ter entre 2 e 50 caracteres")] //coloca restriões ao tamanho do nome
        public string Nome { get; set; } = string.Empty; //ou string empty


        [Required(ErrorMessage = "O email é obrigatório")]
        [EmailAddress(ErrorMessage = "Email inválido")]
        public string Email { get; set; } = "";

        [Range(16, 100, ErrorMessage = "Idade deve ser entre 16 e 100")] //coloca limitações para cadastrar uma idade
        public int Idade { get; set; }
    }

}
