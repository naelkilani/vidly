using System;
using System.ComponentModel.DataAnnotations;
using Vidly.Validation;

namespace Vidly.ModelsDtos
{
    public class CustomerDto
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter customer's name.")]
        [StringLength(255)]
        public string Name { get; set; }

        public bool IsSubscribedToNewsletter { get; set; }

        [Min18YearsIfAMember]
        [Display(Name = "Date of Birth")]
        public DateTime? Birthdate { get; set; }

        [Display(Name = "Membership Type")]
        public int MembershipId { get; set; }

        public static readonly int Unkown = 0;
        public static readonly int PayAsYouGo = 1;
    }
}