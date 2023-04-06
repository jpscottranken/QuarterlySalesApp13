using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace QuarterlySalesApp.Models.DomainModels
{
    public class Employee
    {
        public int EmployeeId { get; set; }

        [Required(ErrorMessage = "Please enter a first name.")]
        [StringLength(100)]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Please enter a last name.")]
        [StringLength(100)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Please enter a birth date.")]
        [PastDate(ErrorMessage = "Birth date must be valid date in the past")]
        [Remote("CheckEmployee", "Validation", AdditionalFields = "FirstName, LastName")]
        [Display(Name = "Birth Date")]
        public DateTime? DOB { get; set; }

        [Required(ErrorMessage = "Please enter a hire date.")]
        [PastDate(ErrorMessage = "Hire date must be valid date in the past")]
        [GreaterThan("1/1/1995", ErrorMessage = "Hire date can't be before company formed")]
        [Display(Name = "Hire Date")]
        public DateTime? DateOfHire { get; set; }

        [GreaterThan(0, ErrorMessage = "Please select a manager")]
        [Remote("CheckManager", "Validation", AdditionalFields = "FirstName, LastName, DOB")]
        [Display(Name = "Manager")]
        public int ManagerId { get; set; }

        public string FullName => $"{FirstName} {LastName}";
    }
}
