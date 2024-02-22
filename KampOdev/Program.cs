using KampOdev.Business;
using KampOdev.DataAcces.Concretes;
using KampOdev.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KampOdev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Deneme deneme = new Deneme();

            deneme.Add(new CategoryDal());
            deneme.Update(new CategoryDal());
            deneme.Delete(new CategoryDal());
            Console.WriteLine("****************************");

            deneme.Add(new CourseDal());
            deneme.Update(new CourseDal());
            deneme.Delete(new CourseDal());
            Console.WriteLine("****************************");

            deneme.Add(new InstructorDal());
            deneme.Update(new InstructorDal());
            deneme.Delete(new InstructorDal());

            Console.WriteLine();


            Console.ReadLine();

        }
    }
}
