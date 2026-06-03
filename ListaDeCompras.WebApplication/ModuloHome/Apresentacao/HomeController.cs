using Microsoft.AspNetCore.Mvc;

namespace ListaDeCompras.WebApp.ModuloHome.Apresentacao;

public class HomeController : Controller
{
    [HttpGet]
    public ActionResult Index()
    {
        return View();
    }
}
