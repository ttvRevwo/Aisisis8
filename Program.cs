namespace Linqmuvletek
{
    public class Program
    {
        public static List<Kuldetes> kuldetesek = new List<Kuldetes>();
        static void Main(string[] args)
        {
            Beolvas("NASAmissions.txt");
            Console.WriteLine($"3. feladat: {kuldetesek.Count} db sikeres küldetés volt.");
            //max koltseg
            Console.WriteLine(kuldetesek.Max(x => x.Koltseg));
            //szűrés adott tulajdonságra pl. küldetés neve alapján keresünk, mekkora volt a hasznos teher
            Console.WriteLine(kuldetesek.Where(x => x.Nev == "Hubble Űrtávcső").First().HasznosTeher);
            //első találat használata
            if(kuldetesek.FirstOrDefault(x => x.Nev == "Hubble Űrtávcső") != null)
                Console.WriteLine(kuldetesek.FirstOrDefault(x => x.Nev == "Hubble Űrtávcső").HasznosTeher);
            else
                Console.WriteLine("Nincs ilyen nevű küldetés");

            //adott tulajdonságú elemek mindegyikét szűrhetjük, pl Az összes Apollo küldetés költsége kell
            foreach (Kuldetes kuldi in kuldetesek.Where(x => x.Nev.Contains("Apollo")).ToList())
            {
                Console.WriteLine(kuldi.Koltseg);
            }
            //azoknak a küldetéseknek a neve, ahol a legénység több, mint 3 fő
            foreach (Kuldetes kuldi in kuldetesek.Where(x => x.Legenyseg > 3).ToList())
            {
                Console.WriteLine(kuldi.Nev);
            }
        }

        public static void Beolvas(string fileName)
        {
            string[] sorok = File.ReadAllLines(fileName).Skip(1).ToArray();            
            foreach (string sor in sorok)
            {
                kuldetesek.Add(new Kuldetes(sor));
            }
        }
    }
}
