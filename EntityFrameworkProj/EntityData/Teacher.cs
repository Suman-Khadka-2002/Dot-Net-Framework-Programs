namespace EntityFrameworkProj.EntityData
{
    [Table("Teacher")]
    public class Teacher
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [Column(TypeName = "varchar(50)")]
        public string TeacherName { get; set; }
        public string Address { get; set; }
        public string Contact { get; set; }

    }
}
