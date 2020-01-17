﻿using System.Collections.Generic;
using Vidly.Models;

namespace Vidly.ViewModels
{
    public class CustomerFormViewModel
    {
        public IEnumerable<Membership> Memberships { get; set; }
        public Customer Customer { get; set; }
    }
}