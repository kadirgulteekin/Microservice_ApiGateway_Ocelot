using ContactAPI.Infrastructure;
using ContactAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contact.API.Services
{
    public class ContactService : IContactService
    {
        public ContactDto GetContactById(int Id)
        {
            return new ContactDto()
            {
                Id = Id,
                FirstName = "Kadir",
                LastName = "Gültekin"
            };
        }
    }
}
