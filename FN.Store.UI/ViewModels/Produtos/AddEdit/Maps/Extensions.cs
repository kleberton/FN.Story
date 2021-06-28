using FN.Store.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FN.Store.UI.ViewModels.Produtos.AddEdit.Maps
{
    public static class Extensions
    {
        public static ProdutoAddEditVM ToProdutoAddEditVM( this Produto p)
        {
            return new ProdutoAddEditVM
            {
                Id = p.Id,
                Nome = p.Nome,
                Preco = p.Preco,
                TipoDeProdutoId = p.TipoDeProduto.Id,
                Qtde = p.Qtde,
                DataCadastro = p.DataCadastro
            };
        
        }

        public static Produto ToProduto(this ProdutoAddEditVM p)
        {
            return new Produto
            {
                Id = p.Id,
                Nome = p.Nome,
                Preco = p.Preco,
                TipoDeProdutoId = p.TipoDeProdutoId,
                Qtde = p.Qtde,
                DataCadastro = p.DataCadastro
            };

        }
    }
}
