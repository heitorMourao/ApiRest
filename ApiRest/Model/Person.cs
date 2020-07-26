using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiRest.Model
{
    public class Person
    {
        public long Id { get; set; }
        public string FirstName { get; set; }
        public string LastNamè { get; set; }
        public string Address { get; set; }
        public string Gender { get; set; }
    }
}
