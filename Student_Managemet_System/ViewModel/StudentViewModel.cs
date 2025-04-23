using System.ComponentModel.DataAnnotations;

namespace Student_Managemet_System.ViewModel
{
    public class StudentViewModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Firstname is required")]
        public string? FirstName { get; set; }
        [Required(ErrorMessage = "Lastname is required")]
        public string? LastName { get; set; }
        [Required(ErrorMessage = "Address is required")]
        public string? Address { get; set; }
        [Required(ErrorMessage = "City is required")]
        public string? City { get; set; }
        [Required(ErrorMessage = "Username is required")]
        public string? Username { get; set; }
        [Required(ErrorMessage = "Password is required")]
        public int? Password { get; set; }
        [Required(ErrorMessage = "Std_id is required")]
        public int? std_id { get; set; }
        [Required(ErrorMessage = "Email is required")]
        public string? Email { get; set; }
        [Required(ErrorMessage = "Rank is required")]
        public int? Rank { get; set; }
        [Required(ErrorMessage = "Document is required")]
        public string? Document { get; set; }
        public List<IFormFile>? documents { get; set; }
        [Required(ErrorMessage = "Phone is required")]
        public string? Phone { get; set; }
        [Required(ErrorMessage = "Education is required")]
        public string? Education { get; set; }
        [Required(ErrorMessage = "Description is required")]
        public string? Description { get; set; }
        [Required(ErrorMessage = "Createby is required")]
        public DateTime? CreateBy { get; set; }
        [Required(ErrorMessage = "createdate is required")]
        public DateTime? ModifiedDate { get; set; }
        [Required(ErrorMessage = "Modifieldby is required")]
        public DateTime? DeleteDate { get; set; }
    }
}
