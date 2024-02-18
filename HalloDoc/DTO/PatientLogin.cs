using System.ComponentModel.DataAnnotations;

namespace HalloDoc.DTO
{
    public class PatientLogin
    {
        [Required(ErrorMessage ="Please enter email")]
        public string Email { get; set; }
        [Required(ErrorMessage ="Please enter password")]
        public string Password { get; set; }
    }
}
