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
            try
            {
                Console.WriteLine("Enter R1");
                double R1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter R2");
                double R2 = Convert.ToDouble(Console.ReadLine());
                Console.ReadKey();
                double[] mas = new double[400];
                for (int j = 0; j < 400; j++)
                {
                    double i = j - 200;
                    if (i <= 2 * R1)
                        mas[j] = -i;
                    if (i >= 2 * R1 && i <= 0)
                        mas[j] = -Math.Pow(Math.Pow(R1, 2) - Math.Pow(i + R2, 2), 0.5);
                    if (i <= 2 * R2 && i >= 0)
                        mas[j] = Math.Pow(Math.Pow(R2, 2) - Math.Pow(i - R2, 2), 0.5);
                    if (i >= 2 * R2 && i <= 2 * R2 + 5)
                        mas[j] = -0.5 * i;
                    if (i >= 2 * R2 + 5)
                        mas[j] = -1 * R2 + 2.5;
                }
                for (int i = 0; i < 400; i++)
                {
                    Console.WriteLine($"x = {i - 200} y = {mas[i]} ");
                }
                Console.ReadKey();
            }
            catch (System.FormatException)
            {
                Console.WriteLine("Входная строка имела неверный формат");
                Console.ReadKey();
            }
            }
        }
}
