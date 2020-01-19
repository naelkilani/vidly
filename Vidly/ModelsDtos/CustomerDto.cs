using System;
using System.ComponentModel.DataAnnotations;

namespace Vidly.ModelsDtos
{
    public class CustomerDto
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter customer's name.")]
        [StringLength(255)]
        public string Name { get; set; }

        public bool IsSubscribedToNewsletter { get; set; }

        [Display(Name = "Date of Birth")]
        public DateTime? Birthdate { get; set; }

        [Display(Name = "Membership Type")]
        public int MembershipId { get; set; }
    }
}