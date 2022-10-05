using System;

namespace gensifre
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sifra = "";
            Random rnd = new Random();
            char velikarandom;
            char malarandom, cifrerandom, specrandom;
            string velika = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string mala = velika.ToLower();
            string cifre = "0123456789";
            string spec = "!@#$%&/.,:;";
            Console.WriteLine("-----------Generator Sifre-----------");
            for (int i = 1; i <= 1; i++)
            {
                velikarandom = velika[rnd.Next(velika.Length)];
                sifra = sifra.Insert(rnd.Next(sifra.Length + 1), velikarandom.ToString());

            }
            for (int i = 1; i <= 5; i++)
            {
                malarandom = mala[rnd.Next(mala.Length)];
                sifra = sifra.Insert(rnd.Next(sifra.Length + 1), malarandom.ToString());
            }
            for (int i = 1; i <= 2; i++)
            {
                cifrerandom = cifre[rnd.Next(cifre.Length)];
                sifra = sifra.Insert(rnd.Next(sifra.Length + 1), cifrerandom.ToString());
            }
            Console.WriteLine("Ako zelite specijalnih karaktera u sifri [!@#$%&/.,:;] napisite da ili ne: ");
            string a = Console.ReadLine();
            if (a == "da" || a == "DA" || a == "dA" || a == "Da")
            {
                int specbroj = 1;
                for (int i = 1; i <= specbroj; i++)
                {
                    specrandom = spec[rnd.Next(spec.Length)];
                    sifra = sifra.Insert(rnd.Next(sifra.Length + 1), specrandom.ToString());

                }
            }
            Console.WriteLine(sifra);
            Console.ReadLine();

        }
    }
}
