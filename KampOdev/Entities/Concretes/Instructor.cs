using KampOdev.Entities.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KampOdev.Entities.Concretes
{
    public class Instructor:IBaseEntitiy
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Explanation { get; set; }
    }
}
