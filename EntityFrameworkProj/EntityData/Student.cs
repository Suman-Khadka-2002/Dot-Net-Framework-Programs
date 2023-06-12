using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EntityFrameworkProj.EntityData
{
    [Table("Student")]
    public class Student
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        //[Required]
        //[Column(TypeName = "varchar(50)")]
        public string Name { get; set; }

        //[Required]
        public string Address { get; set; }
        public string Contact { get; set; }
    }

    [Table("Teacher")]
    public class Teacher
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        //[Required]
        //[Column(TypeName ="varchar(50)")]

        public string TeacherName { get; set; }
        //[Required]
        public string Address { get; set; }
        public string Contact { get; set; }

    }
}
