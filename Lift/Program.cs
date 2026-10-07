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
                hasznalatok.Add(
                new Hasznalat(
                int.Parse(tomb[0]),
                int.Parse(tomb[1]),
                int.Parse(tomb[2]),
                int.Parse(tomb[3]

                )));

            }

            olvaso.Close();



        }
    }
}
