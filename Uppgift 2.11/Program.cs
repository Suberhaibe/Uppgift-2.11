using System;
namespace Uppgift_2_11
{
    class program
    {
        static void Main(string[]arg)
        {
            Console.WriteLine("HUR LÅNGT HAR ELIN HOPPAT.");
            int ELIN = int.Parse(Console.ReadLine());

            Console.WriteLine("HUR LÅNGT HAR ELMA HOPPAT.");
            int ELMA = int.Parse(Console.ReadLine());
            int RESULTAT = ELIN - ELMA;
            Console.WriteLine("ELIN HAR HOPPAT " + RESULTAT + " METER MER ÄN ELMA");
        }
    }
}
