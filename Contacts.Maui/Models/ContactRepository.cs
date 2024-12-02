using Microsoft.Maui.ApplicationModel.Communication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contacts.Maui.Models
{
    public static class ContactRepository
    {
        public static List<Contact> _contacts = new List<Contact>(){
            new Contact{ContactId= 1, Name="John Doe", Address="100 NE Dr", City="New York", State="NY", ZipCode="11232", Country="United States", Phone="714-234-4432", Email="john.doe@example.com"},
            new Contact{ContactId= 2, Name="Jane Doe", Address="100 NE Dr", City="New York", State="NY", ZipCode="11232", Country="United States", Phone="714-234-4444", Email="jane.doe@example.com"},
            new Contact{ContactId= 3, Name="Tom Hanks", Address="86 SE Ter", City="Strougthon", State="MA", ZipCode="23786", Country="United States", Phone="525-452-4432", Email="john.doe@example.com"},
            new Contact{ContactId= 4, Name="Fank Liu", Address="51 NW AVE", City="Columbus", State="OH", ZipCode="43210", Country="United States", Phone="805-234-9952", Email="frank.lui@example.com"},
        };

        public static List<Contact> GetAllContacts() => _contacts;


        public static Contact? GetContactById(int contactid)
        {
            var contact = _contacts.FirstOrDefault(x => x.ContactId == contactid);
            if (contact != null)
            {
                return new Contact
                {
                    Name = contact.Name,
                    Address = contact.Address,
                    City = contact.City,
                    State = contact.State,
                    ZipCode = contact.ZipCode,
                    Country = contact.Country,
                    Phone = contact.Phone,
                    Email = contact.Email
                };
            }
           
           return null;
          
        }

        public static void UpdateContact(int contactid, Contact contact)
        {
            if (contactid != contact.ContactId) return;

            var contactToUpdate = _contacts.FirstOrDefault(x => x.ContactId == contactid);
            if (contactToUpdate != null)
            {
                // AutoMapper
                contactToUpdate.Name = contact.Name;
                contactToUpdate.Address = contact.Address;
                contactToUpdate.City = contact.City;
                contactToUpdate.State = contact.State;
                contactToUpdate.ZipCode = contact.ZipCode;
                contactToUpdate.Country = contact.Country;
                contactToUpdate.Phone = contact.Phone;
                contactToUpdate.Email = contact.Email;
            }

                //var contactToUpdate = GetContactById(contactid);

            //if (contactToUpdate != null)
            //{
                
            //}
        }
    }
}
