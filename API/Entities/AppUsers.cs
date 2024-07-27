using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Entities
{
    public class AppUser
    {
        public int ID { get; set; }
        public required string UserNames { get; set; }
        public required byte[] PassworrdHash { get; set; }
        public required byte[] PassworrdSalt { get; set; }
    }
}