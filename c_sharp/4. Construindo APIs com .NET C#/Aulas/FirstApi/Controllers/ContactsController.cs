using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FirstApi.Context;
using FirstApi.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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
        public IActionResult GetId(int id)
        {
            var contact = _context.Contacts.Find(id);
            if (contact == null) {
                return NotFound();
            } else {
                return Ok(contact);
            }
        }
        
        [HttpGet("{name:string}")]
        public IActionResult GetName(string name)
        {
            var contact = _context.Contacts.Where(x => x.Name.Contains(name));
            if (contact == null) {
                return NotFound();
            } else {
                return Ok(contact);
            }
        }

        [HttpPost]
        public IActionResult Create(Contacts contact)
        {
            _context.Add(contact);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetId), new {id = contact.Id}, contact);
        }

        [HttpPut]
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

        [HttpDelete]
        public IActionResult DeleteContact (int id)
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
