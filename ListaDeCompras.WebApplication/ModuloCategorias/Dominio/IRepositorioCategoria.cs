using ListaDeCompras.WebApp.Compartilhado.Dominio;
using ListaDeCompras.WebApp.Compartilhado.Infra;

namespace ListaDeCompras.WebApp.ModuloCategorias.Dominio;

public interface IRepositorioCategoria : IRepositorio<Categoria>
{
    Categoria? SelecionarPorId(string id);
}
