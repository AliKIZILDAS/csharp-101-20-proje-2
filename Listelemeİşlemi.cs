
namespace todolist
{
    public class Listelemeİşlemi
    {
        private static Board boards;
        
        
        public static void Listele()
        {
            KartDüzeni.KartGöster("TODO Line", Veri.Kartlar.Where(x => x.line == "TODO").ToList());
            KartDüzeni.KartGöster("INPROGRESS Line", Veri.Kartlar.Where(x => x.line == "INPROGRESS").ToList());
            KartDüzeni.KartGöster("DONE Line", Veri.Kartlar.Where(x => x.line == "DONE").ToList());

        }
    }
}