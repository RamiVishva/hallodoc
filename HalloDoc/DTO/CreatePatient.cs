using System.ComponentModel.DataAnnotations;

namespace HalloDoc.DTO
{
    public class CreatePatient
    {
        [Required(ErrorMessage ="Please enter email")]
        public string email { get; set; }
        [Required(ErrorMessage = "Please enter password")]
        public string password { get; set; }

        [Required(ErrorMessage ="Please enter confirm password")]
        [Compare("password", ErrorMessage = "Password and confirm password should be same")]
        public int confirmPassword { get; set; }
    }
}

