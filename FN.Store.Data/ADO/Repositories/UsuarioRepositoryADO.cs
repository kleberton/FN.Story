using FN.Store.Domain.Contracts.Repositories;
using FN.Store.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FN.Store.Data.ADO.Repositories
{
    public class UsuarioRepositoryADO : IUsuarioRepository
    {
        private readonly FNStoreDataContextADO _ctx;

        public UsuarioRepositoryADO(FNStoreDataContextADO ctx)
        {
            _ctx = ctx;
        }

        public Usuario Get(string email)
        {
            var query = $@"select  
                            u.Id,
	                        u.Nome,
	                        u.Email,
                            u.Senha,
	                        u.DataCadastro
                        from Usuario u where u.Email = '{email}' ";

            var dr = _ctx.ExecuteCommandWithData(query);

            if (dr.HasRows)
            {
                var usuarios = new List<Usuario>();
                while (dr.Read())
                {
                    usuarios.Add(new Usuario
                    {
                        Id = (int)dr["Id"],
                        Nome = dr["Nome"].ToString(),
                        Email = dr["Email"].ToString(),
                        Senha = dr["Senha"].ToString(),
                        DataCadastro = (DateTime)dr["DataCadastro"]
                    });
                    dr.Close();
                    return usuarios.First();
                }
            }

            return null;

        }

        public void Dispose()
        {
        }

        public Usuario Get(int id)
        {
            throw new NotImplementedException();
        }

        public void Add(Usuario entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Usuario entity)
        {
            throw new NotImplementedException();
        }

        public void Edit(Usuario entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Usuario> Get()
        {
            throw new NotImplementedException();
        }
    }
}
