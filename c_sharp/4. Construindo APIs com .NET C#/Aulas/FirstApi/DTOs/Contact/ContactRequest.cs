using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstApi.DTOs.Contact
{
    public class ContactRequest
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public bool Active { get; set; }
    }
}