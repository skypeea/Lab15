using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArithProgression ap = new ArithProgression(); // Арифметическая прогрессия
            ap.SetStart(12);
            ap.setStep(10);
            Console.WriteLine(ap.GetNext());//22
            Console.WriteLine(ap.GetNext());//32
            Console.WriteLine(ap.GetNext());//42
            Console.WriteLine(ap.GetNext());//52
            ap.Reset();
            Console.WriteLine(ap.GetNext());//22

            GeomProgression gp = new GeomProgression(); //Геометрическая прогрессия
            gp.SetStart(1);
            gp.setStep(2);
            Console.WriteLine(gp.GetNext());//2
            Console.WriteLine(gp.GetNext());//4
            Console.WriteLine(gp.GetNext());//8
            Console.WriteLine(gp.GetNext());//16
            gp.Reset();
            Console.WriteLine(gp.GetNext());//2

            Console.ReadKey(); 
        }
    }
}
