using System.ComponentModel.DataAnnotations;

namespace JqueryExample.Models
{
    public class UserModel
    {
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Age is required")]
        public int Age { get; set; }

        [Required(ErrorMessage = "Gender is required")]
        public string Gender { get; set; }

        public bool Married { get; set; }
    }
}
