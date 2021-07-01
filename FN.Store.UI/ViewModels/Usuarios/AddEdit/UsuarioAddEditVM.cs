using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FN.Store.UI.ViewModels.Usuarios.AddEdit
{
    public class UsuarioAddEditVM
    {
        public UsuarioAddEditVM()
        {
            DataCadastro = DateTime.Now;
        }

        public int Id { get; set; }

        [Required, MaxLength(100)]
        public string Nome { get; set; }

        [Required, MaxLength(100)]
        public string Email { get; set; }

        [Required, MaxLength(100)]
        public string Senha { get; set; }
        public DateTime DataCadastro { get; set; }
    }
}
