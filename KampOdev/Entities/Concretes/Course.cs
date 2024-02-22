using KampOdev.Entities.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KampOdev.Entities.Concretes
{
    public class Course:IBaseEntitiy
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
