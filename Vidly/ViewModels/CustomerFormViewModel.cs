using System.Collections.Generic;
using Vidly.Models;
using Vidly.Dtos;

namespace Vidly.ViewModels
{
    public class CustomerFormViewModel
    {
        public IEnumerable<Membership> Memberships { get; set; }
        public CustomerDto CustomerDto { get; set; }
        public string Title => CustomerDto != null && CustomerDto.Id != 0 ? "Edit Customer" : "New Customer";
    }
}