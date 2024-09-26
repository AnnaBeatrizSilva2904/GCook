using System.ComponentModel.DataAnnotations;

namespace GCook.ViewModels;

public class RegistroVM
{
    [Display(Name = "Nome completo", Prompt = "Informe seu Nome Completo")]
    [Required(ErrorMessage = "Por favor, informe seu nome")]
    [StringLength(60, ErrorMessage = "O nome deve possuir no máximo 60 caracteres")]
    public string Nome { get; set; }

    [DataType(DataType.Date)]
    [Display(Name = "Data de nascimento", Prompt = "Informe sua data de nascimento")]
    [Required(ErrorMessage = "Por favor, informe sua data de nascimento")]
    public DateTime? DataNascimento { get; set; } = null;

    [Display(Prompt = "Informe seu Email")]
    [Required(ErrorMessage = "Por favor, informe seu email")]
    [EmailAddress(ErrorMessage = "Por favor, informe um email válido!")]
    [StringLength(100, ErrorMessage = "O email deve possuir no máximo 100 caracteres")]
    public string Email { get; set; }

    [DataType(DataType.Password)]
    [Display(Name = "Senha de acesso", Prompt = "Informe uma senha para acesso")]
    [Required(ErrorMessage = "Por favor, informe sua senha de acesso!")]
    [StringLength(20, MinimumLength = 6, ErrorMessage = "A senha deve possuir no mínimo 6 e no máximo 20")]
    public string Senha { get; set; }

    [DataType(DataType.Password)]
    [Display(Name = "Conformar senha de acesso", Prompt = "Confirme sua senha de acesso")]
    [Compare("Senha", ErrorMessage = "As senhas não conferem.")]
    public string ConfirmacaoSenha { get; set; }

    public IFormFile Foto { get; set; }

    public bool Termos { get; set; } = false;

    public bool Enviado { get; set; }
}
