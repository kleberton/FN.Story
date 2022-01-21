using FN.Store.Domain.Entities;
using System.Collections.Generic;
using System.Linq;

namespace FN.Store.UI.ViewModels.TipoDeProdutos.Map
{
    public static class Extensions
    {
        public static TipoDeProdutoVM ToTipoDeProdutoVM(this TipoDeProduto tipo)
        {
            return new TipoDeProdutoVM
            {
                Id = tipo.Id,
                Nome = tipo.Nome,
                DataCadastro = tipo.DataCadastro
            };

        }

        public static TipoDeProduto ToTipoDeProduto(this TipoDeProdutoVM tipo)
        {
            return new TipoDeProduto
            {
                Id = tipo.Id,
                Nome = tipo.Nome,
                DataCadastro = tipo.DataCadastro
            };

        }

        public static IEnumerable<TipoDeProdutoVM> ToProdutoIndexVM(this IEnumerable<TipoDeProduto> data)
        {
            return data.Select(p => new TipoDeProdutoVM
            {
                Id = p.Id,
                Nome = p.Nome,
                DataCadastro = p.DataCadastro
            });
        }
    }
}
