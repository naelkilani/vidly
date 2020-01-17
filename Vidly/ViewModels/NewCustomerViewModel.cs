using System.Collections.Generic;
using Vidly.Models;

namespace Vidly.ViewModels
{
    public class NewCustomerViewModel
    {
        public IEnumerable<Membership> Memberships { get; set; }
        public Customer Customer { get; set; }
    }
}