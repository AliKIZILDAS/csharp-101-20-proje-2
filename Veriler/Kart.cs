namespace todolist
{
    public class Kart
    {
        private string Başlık; 
        private string İçerik; 
        private string Kişi; 
        private string Size; 
        private string Line;

        public string başlık { get => Başlık; set => Başlık = value; }
        public string içerik { get => İçerik; set => İçerik = value; }
        public string kişi { get => Kişi; set => Kişi = value; }
        public string size { get => Size; set => Size = value; }
        public string line { get => Line; set => Line = value; }

        public Kart(string başlık, string içerik, string kişi, string size, string line)
        {
            Başlık = başlık;
            İçerik = içerik;
            Kişi = kişi;
            Size = size;
            Line = line;
        }

        public Kart(){}
    }
}