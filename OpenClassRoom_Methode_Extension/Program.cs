using System;
using System.Text;

namespace OpenClassRoom_Methode_Extension
{
    class Program
    {
        static void Main(string[] args)
        {
            string chaineNormale = "Bonjour à tous";
            string chaineCryptee = chaineNormale.Crypte();
            Console.WriteLine(chaineCryptee);
            chaineNormale = chaineCryptee.Decrypte();
            Console.WriteLine(chaineNormale);
        }
    }

    public static class Encodage
    {
        public static string Crypte(this string chaine)
        {
            return Convert.ToBase64String(Encoding.Default.GetBytes(chaine));
        }

        public static string Decrypte(this string chaine)
        {
            return Encoding.Default.GetString(Convert.FromBase64String(chaine));
        }
    }
}
