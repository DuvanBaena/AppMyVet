using System.ComponentModel.DataAnnotations;

namespace AppMyVet.Common.Models
{
    public class EmailRequest
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
