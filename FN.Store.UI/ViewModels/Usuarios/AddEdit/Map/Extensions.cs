using FN.Store.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FN.Store.UI.ViewModels.Usuarios.AddEdit.Map
{
    public static class Extensions
    {
        public static UsuarioAddEditVM ToUsuarioAddEditVM(this Usuario u)
        {
            return new UsuarioAddEditVM
            {
                Id = u.Id,
                Nome = u.Nome,
                Email = u.Email,
                Senha = u.Senha,
                DataCadastro = u.DataCadastro
            };

        }

        public static Usuario ToUsuario(this UsuarioAddEditVM u)
        {
            return new Usuario
            {
                Id = u.Id,
                Nome = u.Nome,
                Email = u.Email,
                Senha = u.Senha,
                DataCadastro = u.DataCadastro
            };

        }
    }
}
