using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KampOdev.Entities.Abstracts
{
    public interface IBaseEntitiy
    {
        int Id { get; set; }
        string Name { get; set; }
    }
}
