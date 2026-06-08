using ListaDeCompras.WebApp.ModuloCategorias.Dominio;
using Microsoft.AspNetCore.Mvc;

namespace ListaDeCompras.WebApp.ModuloCategorias.Apresentacao;

public class CategoriaController : Controller
{
    private readonly IRepositorioCategoria repositorioCategoria;

    public CategoriaController(IRepositorioCategoria repositorioCategoria)
    {
        this.repositorioCategoria = repositorioCategoria;
    }

    [HttpGet]
    public ActionResult Listar()
    {
        List<Categoria> categorias = repositorioCategoria.SelecionarTodos();

        List<ListarCategoriaViewModel> listarVms = new List<ListarCategoriaViewModel>();

        foreach (Categoria categoria in categorias)
        {
            ListarCategoriaViewModel viewModel = new ListarCategoriaViewModel(
                categoria.Id,
                categoria.Nome,
                categoria.Cor
            );

            listarVms.Add(viewModel);
        }

        return View(listarVms);
    }

    [HttpGet]
    public ActionResult Cadastrar()
    {
        CadastrarCategoriaViewModel cadastrarVm = new CadastrarCategoriaViewModel(
            string.Empty,
            0
        );


        return View(cadastrarVm);
    }

    [HttpPost]
    public ActionResult Cadastrar(CadastrarCategoriaViewModel cadastrarVm)
    {
        if (!ModelState.IsValid)
        {
            return View(cadastrarVm);
        }

        Categoria categoria = new Categoria(
            cadastrarVm.Nome,
            cadastrarVm.Cor
        );

        repositorioCategoria.Cadastrar(categoria);

        return RedirectToAction(nameof(Listar));
    }

    [HttpGet]
    public ActionResult Editar(string id)
    {
        Categoria? categoria = repositorioCategoria.SelecionarPorId(id);

        if (categoria == null)
        {
            return RedirectToAction(nameof(Listar));
        }

        EditarCategoriaViewModel editarVm = new EditarCategoriaViewModel(
            categoria.Id,
            categoria.Nome,
            categoria.Cor
        );

        return View(editarVm);
    }

    [HttpPost]
    public ActionResult Editar(string id, EditarCategoriaViewModel editarVm)
    {
        if (!ModelState.IsValid)
        {
            return View(editarVm);
        }

        Categoria categoria = new Categoria(
            editarVm.Nome,
            editarVm.Cor
        );

        repositorioCategoria.Editar(id, categoria);

        return RedirectToAction(nameof(Listar));
    }

    [HttpGet]
    public ActionResult Excluir(string id)
    {
        Categoria? categoria = repositorioCategoria.SelecionarPorId(id);

        if (categoria == null)
        {
            return NotFound();
        }

        return View(categoria);
    }

    [HttpPost]
    [ActionName("Excluir")]
    public ActionResult ConfirmarExclusao(string id)
    {
        repositorioCategoria.Excluir(id);

        return RedirectToAction(nameof(Listar));
    }
}
