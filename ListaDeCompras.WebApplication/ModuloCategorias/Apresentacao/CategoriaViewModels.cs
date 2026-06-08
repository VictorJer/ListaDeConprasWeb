using System.ComponentModel.DataAnnotations;

namespace ListaDeCompras.WebApp.ModuloCategorias.Apresentacao;

public record ListarCategoriaViewModel(
    string Id,
    string Nome,
    int Cor
);

public record CadastrarCategoriaViewModel(
    [Required(ErrorMessage = "O nome é obrigatório")]
    [StringLength(50, ErrorMessage = "O nome deve ter no máximo 50 caracteres")]
    string Nome,


    [Required(ErrorMessage = "A cor é obrigatória")]
    [Range(0, 5, ErrorMessage = "A cor deve ser um número entre 0 e 5")]
    int Cor
);

public record EditarCategoriaViewModel(
    string Id,
    [Required(ErrorMessage = "O nome é obrigatório")]
    [StringLength(50, ErrorMessage = "O nome deve ter no máximo 50 caracteres")]
    string Nome,

    [Required(ErrorMessage = "A cor é obrigatória")]
    [Range(0, 5, ErrorMessage = "A cor deve ser um número entre 0 e 5")]
    int Cor
);

public record ExcluirCategoriaViewModel(
    int Id,
    string Nome
);
