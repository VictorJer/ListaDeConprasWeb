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
        List<string> erros = new List<string>();

        if (string.IsNullOrWhiteSpace(Nome))
            erros.Add("o campo \"Nome\" e obrigatorio.");

        else if (Nome.Length > 50)
            erros.Add("O campo \"Nome\" deve conter no maximo 50 caracteres");

        if (Cor > 5)
            erros.Add("A cor deve conter um numero entre 1 e 5");

        return erros;
    }
}
