using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDeadline
{
    class Task2
    {
        public void Task21()
        {
            Console.WriteLine("Enter R1");
            double R1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter R2");
            double R2 = Convert.ToDouble(Console.ReadLine());
            Console.ReadKey();
            double[] mas = { };
            for (int i = -200; i < 200; i++)
            {
                if (i <= 2 * R1)
                    mas[i] = -i;
                if (i >= 2 * R1 && i <= 0)
                    mas[i] = -Math.Pow(Math.Pow(R1, 2) - Math.Pow(i + R2, 2), 0.5);
                if (i <= 2 * R2 && i >= 0)
                    mas[i] = Math.Pow(Math.Pow(R2, 2) - Math.Pow(i - R2, 2), 0.5);
                if (i >= 2 * R2 && i <= 2 * R2 + 5)
                    mas[i] = -0.5 * i;
                if (i >= 2 * R2 + 5)
                    mas[i] = -1 * R2 + 2.5;
            }
            for (int i = -200; i < 200; i++)
            {
                Console.WriteLine($"x = {i} y = {mas[i]} ");
            }
        }
    }
}
