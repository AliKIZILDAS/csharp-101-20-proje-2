
namespace todolist
{
    class Taşımaİşlemi:Veri
    {
        public static void Taşı()
        {
            Console.WriteLine("Öncelikle silmek istediğiniz kartı seçmeniz gerekiyor.");
            Console.WriteLine("Lütfen kart başlığını yazınız: ");
            string input = Console.ReadLine();
            bool tasıS=false;

            foreach (var item in Kartlar)
            {
                if(item.başlık == input)
                {
                    tasıS=true;
                    Console.WriteLine("Bulunan Kart Bigileri");
                    Console.WriteLine("*******************************");
                    Console.WriteLine("Başlık     : " + item.başlık);
                    Console.WriteLine("İçerik     : " + item.içerik);
                    Console.WriteLine("Atanan Kişi: " + item.kişi);
                    Console.WriteLine("Büyüklük   : " + item.size);
                    Console.WriteLine("Line       : " + item.line);
                    Console.WriteLine();
                    Console.WriteLine("Lütfen taşıman istediğiniz Line'ı seçiniz:");
                    Console.WriteLine("(1) TODO");
                    Console.WriteLine("(2) INPROGRESS");
                    Console.WriteLine("(3) DONE");
                    int input1 = Convert.ToInt32(Console.ReadLine());

                    switch (input1)
                    {                        
                        case 1:
                        item.line = "TODO";
                        break;
                        case 2:
                        item.line = "INPROGRESS";
                        break;
                        case 3:
                        item.line = "DONE";
                        break;
                    }                    
                }
                
            }
            if (!tasıS)
            {
                Console.WriteLine("Aradığınız kriterlere uygun veri rehberde bulunamadı. Lütfen seçim yapınız: ");
                Console.WriteLine("* Silmeyi sonlandırmak için (1)");
                Console.WriteLine("* Yeniden denemek için (2)");
                string input2 = Console.ReadLine();

                if(input2 == "1")
                {
                    Console.WriteLine("İşlem sonlandırıldı.");
                    //break;
                 }
                else if(input2 == "2")
                {
                    Taşı();
                }
                else
                {
                    Console.WriteLine("Gecersiz bir karakter girdiniz "); 
                    Console.ReadKey();                               
                }
            }            
              
        }
    }  
}