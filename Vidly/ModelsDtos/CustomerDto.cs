using System;
using System.ComponentModel.DataAnnotations;
using Vidly.Models;

namespace Vidly.ModelsDtos
{
    public class CustomerDto
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public bool IsSubscribedToNewsletter { get; set; }

        [Display(Name = "Date of Birth")]
        public DateTime? Birthdate { get; set; }

        public Membership Membership { get; set; }

        [Display(Name = "Membership Type")]
        public int MembershipId { get; set; }
    }
}