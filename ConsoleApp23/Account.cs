using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    internal class Account
    {
        public int Id { get; set; }
        public string? Name { get; set; }

        public string? Surname { get; set; }

        public decimal Money { get; set; }

        public string? Role { get; set; }
    }
}
