namespace todolist
{
    public class Silmeİşlemi : Veri
    {
        public static void Sil()
        {
            Console.WriteLine("Öncelikle silmek istediğiniz kartı seçmeniz gerekiyor.");
            Console.WriteLine("Lütfen kart başlığını yazınız: ");
            string input = Console.ReadLine();
            bool silDurumu=false;

            foreach (var item in Kartlar)
            {
                if (item.başlık == input)
                {
                    silDurumu=true;
                    Kartlar.Remove(item);
                    break;
                }
            }
            if(!silDurumu)
                {

                    Console.WriteLine("Aradığınız kriterlere uygun kart board'da bulunamadı. Lütfen seçim yapınız.");
                    Console.WriteLine("* Silmeyi sonlandırmak için (1)");
                    Console.WriteLine("* Yeniden denemek için (2)");
                    string input1 = Console.ReadLine();

                    if (input1 == "1")
                    {
                        Console.WriteLine("Çıkış yapılıyor.");
                        
                    }
                    else if(input1 == "2")
                    {
                        Sil();
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
