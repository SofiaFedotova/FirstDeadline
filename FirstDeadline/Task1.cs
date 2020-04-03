using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDeadline
{
    class Task1
    {
        public void Task11()
        {
            Console.Write("Введите a: ");
            try
            {
                double a = Convert.ToDouble(Console.ReadLine());
                double z1 = (Math.Sin(2.0 * a) + Math.Sin(5.0 * a) - Math.Sin(3.0 * a)) / (Math.Cos(a) + 1 - 2 * Math.Pow(Math.Sin(2.0 * a), 2));
                Console.WriteLine($"Result is z1 = {z1} ");
                Console.ReadKey();
            }
            catch
            {
                Console.Write("В следующий раз введите double a");
            }

        }
    }
}
