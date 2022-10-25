namespace todolist
{
    public class EklemeIslemi:Veri
    {
        public static void Ekle()
        {
            

            Console.WriteLine("Başlık giriniz: ");
            string input = Console.ReadLine();
            Console.WriteLine("İçerik giriniz: ");
            string input1 = Console.ReadLine();
            Console.WriteLine("Büyüklük seçiniz XS(1), S(2), M(3), L(4), XL(5) ");
            int input2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Atanacak kişiyi giriniz: ");
            int input3 = Convert.ToInt32(Console.ReadLine());
            

            Kart yeniKart = new Kart();
            yeniKart.başlık = input;
            yeniKart.içerik = input1;
            yeniKart.size=Enum.GetName(typeof(EnumSize), input2);
            yeniKart.kişi=Kişiler1[input3];
            yeniKart.line= "INPROGRESS";
            Veri.Kartlar.Add(yeniKart);

            Console.WriteLine(input+" "+input1+" "+yeniKart.size+" "+yeniKart.kişi+" rehbere eklenmiştir." );
            Console.ReadKey();  

            
        }
    }
}