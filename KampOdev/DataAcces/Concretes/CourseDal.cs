using KampOdev.DataAcces.Abstracts;
using KampOdev.Entities.Abstracts;
using KampOdev.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KampOdev.DataAcces.Concretes
{
    public class CourseDal : IDal
    {
        List<IBaseEntitiy> courses;
        public CourseDal()
        {
            Course course = new Course();
            course.Id = 1;
            course.Name = "Senior Yazılım Geliştirme Kampı";
            
            Course course2 = new Course();
            course2.Id = 2;
            course.Name = "Yazılım Geliştirici Yetiştime Kampı";


        }




        public void Add()
        {
            Console.WriteLine("Kurs eklendi...");
        }

        public void Delte()
        {
            Console.WriteLine("Kurs Silindi...");
        }

        public void Update()
        {
            Console.WriteLine("Kurs Güncellendi...");
        }


    }
}
