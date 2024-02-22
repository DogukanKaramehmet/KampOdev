using KampOdev.Entities.Abstracts;
using KampOdev.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KampOdev.DataAcces.Abstracts
{
    public interface IDal
    {
        void Add();
        void Delte();
        void Update();
    }
}
