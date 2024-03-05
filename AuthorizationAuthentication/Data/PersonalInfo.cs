using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AuthorizationAuthentication.Data
{
    [Table("PersonalInfo")]
    public class PersonalInfo
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string FullName { get; set; }
    }
}
