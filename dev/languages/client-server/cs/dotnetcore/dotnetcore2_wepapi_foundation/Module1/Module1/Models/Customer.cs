using System.ComponentModel.DataAnnotations;

namespace Module1.Models
{
    public class Customer
    {
        // NOTE: Data annotations added as a way to validate user input
        // in the POST method

        public int Id { get; set; }

        [Required, StringLength(15)]
        public string Name { get; set; }

        [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", ErrorMessage = "Invalid Email")]
        public string Email { get; set; }


        public string Phone { get; set; }
    }
}
