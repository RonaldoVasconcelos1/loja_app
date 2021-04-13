using System;
using System.Collections.Generic;

namespace src.Loja.Domain.Entities
{
    public class Client
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Cpf { get; set; }
        public DateTime BirthDate { get; set; }
        public string Gender { get; set; }
        public IEnumerable<Address> Address { get; set; }
    }
}