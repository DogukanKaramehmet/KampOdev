using KampOdev.DataAcces.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KampOdev.Business
{
    public class Deneme
    {
        

        public void Add(IDal dal)
        {
            dal.Add();
        }
        public void Delete(IDal dal)
        {
            dal.Delte();
        }
        public void Update(IDal dal)
        {
            dal.Update();
        }



    }
}
