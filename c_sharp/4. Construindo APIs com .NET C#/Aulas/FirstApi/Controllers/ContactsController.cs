using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FirstApi.Context;
using FirstApi.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FirstApi.DTOs.Contact;

namespace FirstApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ContactsController(AgendaContext context) : ControllerBase
    {
        private readonly AgendaContext _context = context;

        [HttpGet("")]
        public IActionResult GetAll()
        {
            return Ok(_context.Contacts.ToList());
        }

        //rotas com parametros não podem ter o mesmo nome, como contacts/{name} e contacts/{id}, O roteador não terá como saber se o valor fornecido deve ser tratado como um name ou um id.
        //Para rotas nomeadas assim usar constraints para indicar e limitar o tipo do parametro de rota
        [HttpGet("{id:int}")]
        public IActionResult GetById(int id)
        {
            var contact = _context.Contacts.Find(id);
            if (contact == null) {
                return NotFound();
            }

            var response = new ContactResponse
            {
                Id = contact.Id,
                Name = contact.Name,
                Phone = contact.Phone,
                Active = contact.Active
            };
            return Ok(response);
        }

        [HttpGet("{name}")]
        public IActionResult GetByName(string name)
        {
            var contact = _context.Contacts.Where(x => x.Name.Contains(name));
            if (contact == null) {
                return NotFound();
            } else {
                return Ok(contact);
            }
        }

        [HttpPost]
        public IActionResult Create(ContactRequest request)
        {
            //criando classe Entity/Model de contact para salvar no banco
            var contact = new Contacts
            {
                Name = request.Name,
                Phone = request.Phone,
                Active = request.Active
            };
            _context.Add(contact);
            _context.SaveChanges();

            //criando classe resposta de contact
            var response = new ContactResponse
            {
                Id = contact.Id,
                Name = contact.Name,
                Phone = contact.Phone,
                Active = contact.Active
            };
            return CreatedAtAction(nameof(GetById), new {id = contact.Id}, response);
        }

        [HttpPut("{id:int}")]
        public IActionResult Update(int id, Contacts contact)
        {
            var contactDb = _context.Contacts.Find(id);
            if (contactDb == null) {
                return NotFound();
            }
            contactDb.Name = contact.Name;
            contactDb.Phone = contact.Phone;
            contactDb.Active = contact.Active;

            _context.Contacts.Update(contactDb);
            _context.SaveChanges();

            return Ok();
        }

        [HttpDelete("{id:int}")]
        public IActionResult DeleteContact(int id)
        {
            var contactDb = _context.Contacts.Find(id);
            if (contactDb == null) {
                return NotFound();
            }
            _context.Contacts.Remove(contactDb);
            _context.SaveChanges();
            return NoContent();
        }
    }
}
