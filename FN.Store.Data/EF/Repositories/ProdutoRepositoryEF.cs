using FN.Store.Domain.Contracts.Repositories;
using FN.Store.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FN.Store.Data.EF.Repositories
{

    public class ProdutoRepositoryEF : RepositoryEF<Produto>, IProdutoRepository
    {
        public IEnumerable<Produto> GetByNameContains(string contains)
        {
            return _ctx.Produtos.Where(p => p.Nome.Contains(contains)) ;
        }
    }

}
