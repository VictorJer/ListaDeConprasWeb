using ListaDeCompras.WebApp.Compartilhado.Infra.Arquivo;
using ListaDeCompras.WebApp.Compartilhado.Infra.Arquivos;
using ListaDeCompras.WebApp.ModuloCategorias.Dominio;

namespace ListaDeCompras.WebApp.ModuloCategorias.Infra;

public class RepositorioCategoriaEmArquivo : RepositorioBaseEmArquivo<Categoria>, IRepositorioCategoria
{
    public RepositorioCategoriaEmArquivo(ContextoJson contexto) : base(contexto) { }

    protected override List<Categoria> CarregarRegistros()
    {
        return contexto.Categorias;
    }
}
