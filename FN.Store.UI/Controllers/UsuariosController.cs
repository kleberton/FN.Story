using FN.Store.Domain.Contracts.Repositories;
using FN.Store.UI.ViewModels.Usuarios.AddEdit;
using FN.Store.UI.ViewModels.Usuarios.AddEdit.Map;
using FN.Store.Domain.Helpers;
using FN.Store.UI.ViewModels.Usuarios.Index;
using FN.Store.UI.ViewModels.Usuarios.Index.Map;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace FN.Store.UI.Controllers
{
    [Authorize]
    public class UsuariosController:Controller
    {
        private readonly IUsuarioRepository _usuarioRepository;

        public UsuariosController(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        [HttpGet]
        public ActionResult Index()
        {
            var usuario = _usuarioRepository.Get().ToUsuarioIndexVM();
            return View(usuario);
        }

        [HttpGet]
        public ActionResult AddEdit(int? id)
        {
            var usuario = new UsuarioAddEditVM();

            if (id != null)
                usuario = _usuarioRepository.Get((int)id).ToUsuarioAddEditVM();

            return View(usuario);
        }

        [HttpPost]
        public ActionResult AddEdit(UsuarioAddEditVM usuarioVM)
        {
            var produto = usuarioVM.ToUsuario();

            if (ModelState.IsValid)
            {
                if (usuarioVM.Id == 0)
                {
                    produto.Senha = produto.Senha.Encrypt();
                    _usuarioRepository.Add(produto);
                }
                else
                    _usuarioRepository.Edit(produto);

                return RedirectToAction("Index");
            }

            return View(usuarioVM);
        }

        public ActionResult DelProd(int id)
        {
            var usuario = _usuarioRepository.Get(id);

            if (usuario == null)
                return HttpNotFound();

            _usuarioRepository.Delete(usuario);

            return null;
        }
    }
}
