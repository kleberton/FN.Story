using System;
using System.ComponentModel.DataAnnotations;

namespace FN.Store.UI.ViewModels.TipoDeProdutos
{
    public class TipoDeProdutoVM
    {
        public TipoDeProdutoVM()
        {
            DataCadastro = DateTime.Now;
        }

        public int Id { get; set; }

        [Required, MaxLength(100)]
        public string Nome { get; set; }
        public DateTime DataCadastro { get; set; }
    }
}
