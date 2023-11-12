using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Test2
{
    internal class Customer
    {
        public string name;
        public string surname;
        public int Id { get; set; }
        public string Name { get => name; set => name = value.ToLower(); }
        public string Surname { get => surname; set => surname = value.ToUpper(); }

        public string Region { get; set; }

    }
}
