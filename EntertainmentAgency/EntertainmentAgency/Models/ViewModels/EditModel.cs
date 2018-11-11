using System.ComponentModel.DataAnnotations;

namespace EntertainmentAgency.Models
{
    public class EditModel
    {
        public string Surname { get; set; }
        public string Name { get; set; }
        [Phone]
        public string PhoneNumber { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [Compare("Password", ErrorMessage = "Пароли не совпадают")]
        [DataType(DataType.Password)]
        public string PasswordConfirm { get; set; }
    }
}