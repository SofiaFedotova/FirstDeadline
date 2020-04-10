using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDeadline
{
    class Task8
    {
        public void Srch(List<Do> A, string Tg)
        {
            string[] str = { "" };
            int num = 0;
            foreach (Do i in A)
            {
                foreach (string s in i.Tags1)
                {
                    if (s == Tg)
                    {
                        str[num] = i.Title1;
                        num++;
                    }
                }
            }
            if (num == 0)
                   Console.WriteLine("Not Found");
            else
                foreach (string a in str) { Console.WriteLine($"{a}"); }
            Console.WriteLine("Finish");
        }
    
    }
}
