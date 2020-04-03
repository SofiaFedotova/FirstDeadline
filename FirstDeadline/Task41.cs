using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDeadline
{
    class Task41
    {
        public void Task4()
        {
            Console.WriteLine("Введите элементы массива через пробел");
            string[] s = Console.ReadLine().Split(' ');
            int[] a = new int[s.Length];
            for (int i = 0; i < s.Length; i++)
                a[i] = Int32.Parse(s[i]);
            int product = 1, minzero = -1, maxzero = -1, summ = 0;
            for(int i = 0; i < s.Length; i = i + 2){
                product *= a[i];
            }
            Console.WriteLine($"Product of elements with is{product}");
            for (int i = 0; i < s.Length; i = i + 1)
            {
                if (a[i] != 0)
                    if (minzero == -1) 
                        minzero = i;
                    if(minzero != a[i])
                       maxzero = i;
            }
            for (int i = minzero + 1; i < maxzero; i = i + 1)
                summ += a[i];

            Console.WriteLine($"Summ between nonzeros is {summ}");
            Console.ReadKey();
        }
    }
}
