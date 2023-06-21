using System.ComponentModel.DataAnnotations;

namespace Blog.ViewModel.Categories
{
    public class EditorCategoryViewModel
    {
        [Required(ErrorMessage = "O Name é obrigatório")]
        [StringLength(40, MinimumLength = 3, ErrorMessage = "O campo Name deve conter entre 3 e 40 caracteres")]
        public string Name { get; set; }

        [Required(ErrorMessage = "O Slug é obrigatório")]
        [StringLength(40, MinimumLength = 3, ErrorMessage = "O campo Slug deve conter entre 3 e 40 caracteres")]
        public string Slug { get; set; }
    }
}
