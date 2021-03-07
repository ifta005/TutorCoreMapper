using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreWebAPI.DTO
{
    public class StudentNewDTO
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string CurrentCity { get; set; }
        public AddressDTO Address { get; set; }
    }
}
