using System;
using System.ComponentModel.DataAnnotations;
using Vidly.Validation;

namespace Vidly.ModelsDtos
{
    public class CustomerDto
    {
        public static readonly int Unkown = 0;
        public static readonly int PayAsYouGo = 1;

        public int? Id { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Please enter customer's name.")]
        [StringLength(255)]
        public string Name { get; set; }

        public bool IsSubscribedToNewsletter { get; set; }

        [Min18YearsIfAMember]
        [Display(Name = "Date of Birth")]
        public DateTime? Birthdate { get; set; }

        [Required]
        [Display(Name = "Membership Type")]
        public int? MembershipId { get; set; }

        public CustomerDto()
        {
            Id = 0;
        }
    }
}