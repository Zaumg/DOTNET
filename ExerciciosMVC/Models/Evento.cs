using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ExerciciosMVC.Models
{
    public class Evento
    {

               public int Id { get; set;}

                [Required(ErrorMessage = "O nome é obrigatório")] 
                [StringLength(80, MinimumLength = 5, ErrorMessage = "Nome deve ter entre 3 e 50 caracteres")]
               public string? Nome { get; set;}

               [Required(ErrorMessage = "A descrição obrigatória")] 
               [MinLength(10, ErrorMessage = "A descrição tem que ter no mínimo 10 caracteres")]
               public string? Descricao {get; set;}

                [Required(ErrorMessage = "O local é obrigatório")] 
                [StringLength(100, MinimumLength = 3, ErrorMessage = "Informar o endereço do local é obrigatório")]
               public string? Local {get; set;}

                public DateTime DataEvento {get; set;}

                [Range(1, 1000, ErrorMessage = "A quantidade de vagas deve ser de 1 à 1000")]
                public int QuantidadeVagas {get; set;}

                [Required] [Range(0, int.MaxValue, ErrorMessage = "Adicione o valor.")]
                public decimal ValorIngresso {get; set;}
            
    }
}