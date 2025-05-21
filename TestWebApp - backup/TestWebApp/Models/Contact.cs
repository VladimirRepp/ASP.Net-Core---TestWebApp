using System.ComponentModel.DataAnnotations;

namespace TestWebApp.Models
{
    public class Contact
    {
        [Display(Name = "Введите ФИО")]
        [Required(ErrorMessage = "необходимо ввести имя")]
        public string Fullname { get; set; }

        [Display(Name = "Введите возрас")]
        [Required(ErrorMessage = "необходимо ввести возраст")]
        public int Age { get; set; }

        [Display(Name = "Введите email")]
        [Required(ErrorMessage = "необходимо ввести email")]
        public string Email { get; set; }

        [Display(Name = "Введите сообщение")]
        [Required(ErrorMessage = "необходимо ввести сообщение")]
        [StringLength(10, ErrorMessage = "привышен лимит в 10 символов")]
        public string Message { get; set; }
    }
}
