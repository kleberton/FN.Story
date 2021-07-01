using FN.Store.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FN.Store.UI.ViewModels.Usuarios.Index.Map
{
    public static class Extensions
    {
        public static IEnumerable<UsuarioIndexVM> ToUsuarioIndexVM(this IEnumerable<Usuario> data)
        {
            return data.Select(u => new UsuarioIndexVM
            {
                Id = u.Id,
                Nome = u.Nome,
                Email = u.Email,
                Senha = u.Senha,
                DataCadastro = u.DataCadastro
            });
        }
    }
}
