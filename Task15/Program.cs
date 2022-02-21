using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            int x = Convert.ToInt32(Console.ReadLine());
            ArithProgression arithProgression = new ArithProgression();
            
            arithProgression.SetStart(x);
            Console.WriteLine("Арифметическая прогрессия с шагом 5:");

            for (int i = 0; i < 10; i++)
            {
                Console.Write("{0}  ",arithProgression.GetNext());
            }
            
            arithProgression.Reset();
            Console.WriteLine();

            GeomProgression geomProgression = new GeomProgression();
            
            geomProgression.SetStart(x);
            
            Console.WriteLine("Геометрическая прогрессия с шагом 5:");

            for (int i = 0; i < 10; i++)
            {
                Console.Write("{0}  ", geomProgression.GetNext());
            }

            geomProgression.Reset();

            Console.ReadKey();


        }

        interface ISeries
        {
            void SetStart(int x);
            int GetNext();
            void Reset();
        }

        class ArithProgression : ISeries
        {
            public int X { get; set; }
            public int X1 { get; set; }


            public void SetStart(int x)
            {
                X = x;
                X1 = x;
            }
            public int GetNext()
            {
                X += 5;
                return (X);
            }
            public void Reset()
            {
                X = X1;
                
            }
        }
        class GeomProgression : ISeries
        {
            public int X { get; set; }
            public int X1 { get; set; }


            public void SetStart(int x)
            {
                X = x;
                X1 = x;
            }
            public int GetNext()
            {
                X *= 5;
                return (X);
            }
            public void Reset()
            {
                X = X1;

            }
        }


    }
}
