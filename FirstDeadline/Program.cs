using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDeadline
{
    class Program
    {
        static void Main(string[] args)
        {
            Task1 first = new Task1();
            Vector fourf = new Vector();
            Vector ff = new Vector(1,1,1);
            Vector fif = new Vector(5,6,7);
            Task8 Eight = new Task8();
            //first.Task11();
            var f = new List<Do>() { };
            //Console.WriteLine($"{ff.x}");
            //fourf.Task51(@"C:\Users\Asus\Desktop\учеба\programmes\1.txt");
            int Run = 0;
            double x = 0;
            while (Run != 1)
              x = Convert.ToDouble(Console.ReadLine());
              switch (x)
              { 
                  case 1:
                    {
                        Console.WriteLine("Title:");
                        string A = Console.ReadLine();
                        Console.WriteLine("Discription:");
                        string B = Console.ReadLine();
                        Console.WriteLine("Deadline Day:");
                        int C = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Deadline Month(Number):");
                        int D = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Deadline Year:");
                        int E = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Введите Tags через пробел");
                        string[] s = Console.ReadLine().Split(' ');
                        Do it = new Do(A, B, C, D, E, s);
                        f.Add(it);
                        Console.WriteLine("Added");
                        break;       
                    }
                  case 2:
                    {
                        string t = Console.ReadLine();
                        Eight.Srch(f, t);
                        break;
                    }
                   case 3:
                    {
                        Run = 1;
                        Console.WriteLine("Finish");
                        break;
                    }
                   default:
                    {
                        Console.WriteLine("Use another number");
                        break;
                    }

              }
        }

    }
}
