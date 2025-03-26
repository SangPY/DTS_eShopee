using System;
using System.Collections.Generic;
using System.Text;

namespace DTS_eShopee.ViewModels.System.Users
{
    public class UserViewModel
    {
        public Guid Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string PhoneNumber { get; set; }

        public string UserName { get; set; }

        public string Email { get; set; }
    }
}