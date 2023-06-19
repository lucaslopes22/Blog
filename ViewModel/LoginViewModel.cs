using System.ComponentModel.DataAnnotations;

namespace Blog.ViewModel {
    public class LoginViewModel {
        [Required(ErrorMessage = "E-Mail é obrigatório")]
        [EmailAddress(ErrorMessage = "E-Mail é inválido")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Informe a Senha")]
        public string Password { get; set; }
    }
}
