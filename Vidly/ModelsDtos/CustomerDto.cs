using System;
using Vidly.Models;

namespace Vidly.ModelsDtos
{
    public class CustomerDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsSubscribedToNewsletter { get; set; }
        public DateTime? Birthdate { get; set; }
        public Membership Membership { get; set; }
        public int MembershipId { get; set; }
    }
}