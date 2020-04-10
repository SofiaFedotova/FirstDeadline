using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDeadline
{
    class Task42
    {
        public void Task4()
        {
            /*/Console.WriteLine("Введите элементы массива через пробел");
            string[] s = Console.ReadLine().Split(' ');
            double[] a = new double[s.Length];*/
            try
            {
                /*for (int i = 0; i < s.Length; i++)
                {
                    a[i] = Double.Parse(s[i]);
                    Console.WriteLine($"{a[i]}");
                }
                */
                
                Console.Write("Столбцов: ");
                int x = int.Parse(Console.ReadLine());
                Console.Write("Строк: ");
                int y = int.Parse(Console.ReadLine());
                int[,] mas = new int[x, y];
                Console.WriteLine();

                Console.WriteLine("Заполни матрицу");

                for (int i = 0; i < x; i++)
                {
                    for (int j = 0; j < y; j++)
                    {
                        Console.Write("mas[" + i + "," + j + "]: ");
                        mas[i, j] = int.Parse(Console.ReadLine());
                    }
                }
                Console.WriteLine("Произведения элементов строк с положительными символами");
                for (int i = 0; i < x; i++)
                {
                    double product = 1;
                    int flag = 0;
                    for (int j = 0; j < y; j++)
                    {
                        if (mas[i, j] <= 0)
                            flag = 1;
                        product = product * mas[i, j];
                    }
                    if (flag == 0)
                        Console.WriteLine($"Входная строка {i} product {product}");
                }
                Console.WriteLine("Произведение элементов диагонали");
                double diag = 1;
                for (int i = 0; i < x; i++)
                {
                    for (int j = 0; j < y; j++)
                    {
                        if (i == j)
                            diag = diag * mas[i, j];
                    }
                }
                Console.WriteLine($"Diag product {diag}");
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
