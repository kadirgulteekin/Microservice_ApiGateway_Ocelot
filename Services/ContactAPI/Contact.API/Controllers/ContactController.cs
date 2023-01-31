using ContactAPI.Infrastructure;
using ContactAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Contact.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        private readonly IContactService contactService;

        public ContactController(IContactService ContactService)
        {
            contactService = ContactService;
        }


        [HttpGet("{Id}")]
        public ContactDto Get(int Id)
        {
            return contactService.GetContactById(Id);
        }
    }
}
