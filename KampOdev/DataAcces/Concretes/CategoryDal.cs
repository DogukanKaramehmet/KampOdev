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
    public class CategoryDal:IDal
    {
        List<IBaseEntitiy> categories;
        public CategoryDal()
        {
            Category category = new Category();
            category.Id = 1;
            category.Name = "Tümü";

            Category category2 = new Category();
            category.Id = 2;
            category.Name = "Programlama";

            categories=new List<IBaseEntitiy> { category,category2};
        }


        public void Add()
        {
            Console.WriteLine("Kategory eklendi...");
        }
        public void Delte()
        {
            Console.WriteLine("Kategory silindi...");
        }
        public void Update ()
        {
            Console.WriteLine("Kategory güncellendi...");
        }

    }
}
