using ListaDeCompras.WebApplication.Compartilhado.Dominio;

public class Categoria : EntidadeBase<Categoria>
{
    public string Nome { get; set; } = string.Empty;
    public int Cor { get; set; } = 0;

    public Categoria(string nome, int cor)
    {
        Nome = nome;
        Cor = cor;
    }

    public override void AtualizarDados(Categoria entidadeAtualizada)
    {
        Nome = entidadeAtualizada.Nome;
        Cor = entidadeAtualizada.Cor;
    }

    public override List<string> Validar()
    {
        throw new NotImplementedException();
    }
}
