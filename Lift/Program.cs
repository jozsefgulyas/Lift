using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lift
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FileStream folyam = new FileStream("lift.txt", FileMode.Open);
            StreamReader olvaso = new StreamReader(folyam);
            List<Hasznalat> hasznalatok = new List<Hasznalat>();
            while (!olvaso.EndOfStream)
            {


                string[] tomb = olvaso.ReadLine().Split(' ');
                DateTime datum = DateTime.Parse(tomb[0]);
                hasznalatok.Add(
                new Hasznalat(
                datum,
                int.Parse(tomb[1]),
                int.Parse(tomb[2]),
                int.Parse(tomb[3]

                )));

            }

            olvaso.Close();
            Console.WriteLine("Összes lift használat: " + hasznalatok.Count);

           DateTime legkisebb = hasznalatok.Min(x => x.datum);
           DateTime legnagyobb = hasznalatok.Max(x => x.datum);

            Console.WriteLine("A vizsgált időszak: ", legkisebb + " - " + legnagyobb);

            Console.WriteLine("Kérem a kártya számat: ");
            string kartyaSzam = Console.ReadLine();
            Console.WriteLine("Kérem a célemeletet: ");
            string celEmelet = Console.ReadLine();

            int kartyaSzamNumber = 0;
            int celEmeletNumber =0;

            try 
            {
             kartyaSzamNumber = int.Parse(kartyaSzam);
            }
            catch {
                Console.WriteLine("Konverziós hiba. Alap kártyaszám beállítva");    
                kartyaSzamNumber = 5;
            }
            try
            {                
                celEmeletNumber = int.Parse(celEmelet);
            }
            catch {
                Console.WriteLine("Konverziós hiba. Alap emeletszám beállítva");
                celEmeletNumber = 5;
            }


            Console.WriteLine("Vége");



             

           int legnagyobbEmeltek = hasznalatok.Max(x => x.celEmelet);
       
        }
    }
}
