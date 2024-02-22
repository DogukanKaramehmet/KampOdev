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

    public class InstructorDal : IDal
    {
        List<IBaseEntitiy> ınstructor;

        public InstructorDal()
        {
            Instructor ınstructor =new Instructor();
            ınstructor.Id = 1;
            ınstructor.Name = "Engin";
            ınstructor.LastName = "Demirog";
            ınstructor.Explanation = "Üniversite hayatıma ÖSS 2003 Türkiye " +
                "derecesiyle başladım. Sırasıyla Başkent ve ODTÜ'de Yönetim Bilişim Sistemleri" +
                " (Lisans-Burslu) ve Tıp Bilişimi(Yüksek Lisans) okudum. Profesyonel iş " +
                "hayatıma ise henüz üniversite birinci sınıftayken başladım.";

            Instructor ınstructor2 = new Instructor();
            ınstructor.Id = 2;
            ınstructor.Name = "Halit Enes";
            ınstructor.LastName = "Kalaycı";
            ınstructor.Explanation = "Yazılım geliştirme sürecine lise sonuncu sınıfta başladım.\r\n\r\nSakarya " +
                "Üniversitesi Yönetim Bilişim Sistemleri programından mezun oldum. \r\n\r\nProfesyonel iş hayatım üniversite 3. sınıfta başladı.";


        }

        public void Add()
        {
            Console.WriteLine("Kategory eklendi...");
        }

        public void Delte()
        {
            Console.WriteLine("Kategory Silindi...");
        }

        public void Update()
        {
            Console.WriteLine("Kategory Güncellendi...");
        }
    }
}
