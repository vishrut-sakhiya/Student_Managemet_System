using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Student_Managemet_System.Models
{
    [Table("student")]
    public class Student
    {
        [Key]
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Address { get; set; }
        public string? City { get; set; }
        public string? Username { get; set; }
        public int? Password { get; set; }
        public int? std_id { get; set; }
        public string? Email { get; set; }
        public int? Rank { get; set; }
        public string? Document { get; set; }
        public string? Phone { get; set; }
        public string? Education { get; set; }
        public string? Description { get; set; }

        [Column("CreateBy", TypeName = "timestamp without time zone")]
        public DateTime? CreateBy { get; set; }

        [Column("ModifiedDate", TypeName = "timestamp without time zone")]
        public DateTime? ModifiedDate { get; set; }

        [Column("ModifiedBy", TypeName = "timestamp without time zone")]
        public DateTime? ModifiedBy { get; set; }

        [Column("DeleteDate", TypeName = "timestamp without time zone")]
        public DateTime? DeleteDate { get; set; }
    }
}
