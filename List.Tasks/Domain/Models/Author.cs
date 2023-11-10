using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List.Models
{
    public class Author : BaseEntity
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
    }
}
