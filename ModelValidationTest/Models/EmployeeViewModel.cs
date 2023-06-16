using System.ComponentModel.DataAnnotations;

namespace ModelValidationTest.Models
{
    public class EmployeeViewModel
    {
        [Required]
        public string Name { get; set; } = "";

        public string? Surname { get; set; }

        [MaxLength(10)]
        [EmailAddress(ErrorMessage = "Es mail chi")]
        public string Email { get; set; } = "";

        public int? Age { get; set; }
    }
}