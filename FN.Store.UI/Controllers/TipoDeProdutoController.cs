using FN.Store.Domain.Contracts.Repositories;
using FN.Store.UI.ViewModels.TipoDeProdutos;
using FN.Store.UI.ViewModels.TipoDeProdutos.Map;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace FN.Store.UI.Controllers
{
    public class TipoDeProdutoController : Controller
    {
        private readonly ITipoDeProdutoRepository _tipoDeProdutoRepository;

        public TipoDeProdutoController(ITipoDeProdutoRepository tipoDeProdutoRepository)
        {
            _tipoDeProdutoRepository = tipoDeProdutoRepository;
        }

        [HttpGet]
        public ActionResult Index()
        {
            var tipos = _tipoDeProdutoRepository.Get().ToProdutoIndexVM();
            return View(tipos);
        }

        [HttpGet]
        public ActionResult AddEdit(int? id)
        {
            TipoDeProdutoVM prod = new TipoDeProdutoVM();

            if (id != null)
                prod = _tipoDeProdutoRepository.Get((int)id).ToTipoDeProdutoVM();

            return View(prod);
        }

        [HttpPost]
        public ActionResult AddEdit(TipoDeProdutoVM tipoProdutoVM)
        {
            var tipoProduto = tipoProdutoVM.ToTipoDeProduto();

            if (ModelState.IsValid)
            {
                if (tipoProduto.Id == 0)
                    _tipoDeProdutoRepository.Add(tipoProduto);
                else
                    _tipoDeProdutoRepository.Edit(tipoProduto);

                return RedirectToAction("Index");
            }
            
            return View(tipoProduto);
        }


        [HttpGet]
        public ActionResult AddEditModal(int? id)
        {
            TipoDeProdutoVM prod = new TipoDeProdutoVM();

            if (id != null)
                prod = _tipoDeProdutoRepository.Get((int)id).ToTipoDeProdutoVM();

            return PartialView("_AddEditModalPartial", prod);
        }

        [HttpPost]
        public ActionResult AddEditModal(TipoDeProdutoVM tipoProdutoVM)
        {
            var tipoProduto = tipoProdutoVM.ToTipoDeProduto();

            if (ModelState.IsValid)
            {
                if (tipoProduto.Id == 0)
                    _tipoDeProdutoRepository.Add(tipoProduto);
                else
                    _tipoDeProdutoRepository.Edit(tipoProduto);

                return PartialView("_AddEditModalPartial");
            }

            return PartialView("_AddEditModalPartial", tipoProdutoVM);
        }

        public ActionResult DelProd(int id)
        {
            var produto = _tipoDeProdutoRepository.Get(id);

            if (produto == null)
                return HttpNotFound();

            _tipoDeProdutoRepository.Delete(produto);

            return null;
        }

    }
}
