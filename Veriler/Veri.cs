using System;
using System.Collections.Generic;

namespace todolist
{
    public class Veri
    {
        private static List<Kart> kartlar = new List<Kart>();
        private static List<Kişi> kişiler = new List<Kişi>();
        private static Dictionary<int, string> kişiler1 = new Dictionary<int, string>();

        public static List<Kart> Kartlar { get => kartlar; }
        public static List<Kişi> Kişiler { get => kişiler;  }
        public static Dictionary<int, string> Kişiler1 { get => kişiler1;  }

        static Veri()
        {
            
            kişiler = new List<Kişi>()
            {
                new Kişi{id = 1, isim = "Ceren"},
                new Kişi{id = 2, isim = "Kaan"},
                new Kişi{id = 3, isim = "İrem"},
                new Kişi{id = 4, isim = "Meriç"}
            };

            kartlar = new List<Kart>()
            {
                new Kart{başlık = "Ödev" , içerik = "C# ödevi yapılacak", kişi = "Ceren", size = "S", line = "TODO"},
                new Kart{başlık = "Toplantı" , içerik = "28.09.20222-14.30 toplantı yapılacak.", kişi = "İrem", size = "XS", line = "DONE"},
                new Kart{başlık = "Eğitim" , içerik = "OOP videoları izlenecek", kişi = "Kaan", size = "L", line = "INPROGRESS"},
                new Kart{başlık = "Proje" , içerik = "TODO Projesi tamamlanacak", kişi = "Meriç", size = "M", line = "TODO"}
            };
             
             kişiler1.Add(1,"ali");
             kişiler1.Add(2,"ali2");
             kişiler1.Add(3,"ali3");
             kişiler1.Add(4,"ali4");
        }
        public static void VeriYaz()
        {
            foreach (var item in kartlar)
            {
                Console.WriteLine(item.başlık+ " " + item.içerik + " " + item.kişi + " " + item.size + " " + item.line);
            }
        }
    }
    
}