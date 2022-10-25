namespace todolist
{
    public class KartDüzeni
    {
        public static void KartGöster(string line, List<Kart> listeismi)
        {
            Console.WriteLine(line);
            Console.WriteLine("**************************************");
            foreach (var item in listeismi)
            {
                Console.WriteLine("Başlık     : " + item.başlık);
                Console.WriteLine("İçerik     : " + item.içerik);
                Console.WriteLine("Atanan kişi: " + item.kişi);
                Console.WriteLine("Büyüklük   : " + item.size);
                Console.WriteLine("----------------------------------");
            }
        }

    }

}