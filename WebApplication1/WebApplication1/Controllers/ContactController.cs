using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication1.Models;
using WebApplication1.Services;

namespace WebApplication1.Controllers
{
    public class ContactController : ApiController
    {
        private ContactRepository contactRepository;
        public ContactController()
        {
            this.contactRepository = new ContactRepository();
        }
        public Contact[] Get()
        {
            return contactRepository.GetAllContacts();
            //return new Contact[]
            //{
            //    new Contact
            //    {
            //        Id = 1,
            //        Name = "Glenn great Bloke"
            //    },
            //    new Contact
            //    {
            //        Id = 2,
            //        Name = "Dan Roth"
            //    }
            //};
        }
    }

    
}
