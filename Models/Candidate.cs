using System.ComponentModel.DataAnnotations;

namespace MbkAkademi.Models
{
    public class Candidate
    {
        [Required(ErrorMessage ="E-mail is required")]
        public String? Email { get; set; } = String.Empty; // "";
        [Required(ErrorMessage ="First Name is required")]
        public String? FirstName { get; set; } = String.Empty;
        [Required(ErrorMessage ="Last Name is required")]
        public String? LastName { get; set; } = String.Empty;
        public String? FullName => $"{FirstName} {LastName?.ToUpper()}"; //sadece get bloğu
        public int? Age { get; set; }
        public String? SelectedCourse { get; set; } = String.Empty;
        public DateTime ApplyAt { get; set; }
        public Candidate() //nesne üretilirken değerin atanması
        {
            ApplyAt = DateTime.Now; 
        }


    }
}