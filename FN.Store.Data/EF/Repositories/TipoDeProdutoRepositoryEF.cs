using FN.Store.Domain.Contracts.Repositories;
using FN.Store.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FN.Store.Data.EF.Repositories
{
    public class TipoDeProdutoRepositoryEF : RepositoryEF<TipoDeProduto>, ITipoDeProdutoRepository
    {
        public TipoDeProdutoRepositoryEF(FNStoreDataContextEF ctx) : base(ctx)
        {
        }
    }
}
