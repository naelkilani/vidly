using System.Collections.Generic;
using Vidly.Models;
using Vidly.ModelsDtos;

namespace Vidly.ViewModels
{
    public class CustomerFormViewModel
    {
        public IEnumerable<Membership> Memberships { get; set; }
        public CustomerDto CustomerDto { get; set; }
    }
}