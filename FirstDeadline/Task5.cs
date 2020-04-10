using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDeadline
{
    class Task5
    {
        public void Task51()
        {
            string line;
            
            try
            {
                using (StreamReader sr = new StreamReader("C:1.txt"))
                {
                    string[] x = { };
                    int i = 0;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] lines = line.Split('.');
                        for (int r = 0; r < lines.Length; r++)
                        {
                            x[i] = lines[r];
                            i++;
                        }
                        Console.WriteLine(line);
                        //text += line;
                    }
                    for (int j = 0; j < x.Length; j++)
                    {
                        string[] a = x[i].Split(' ');
                        string[] y = { };
                        for (int f = 0; f < a.Length; f++)
                            y[j] = a[f];
                        int n = y.Length;
                        Random rnd = new Random();
                        while (n > 1)
                        {
                            int k = rnd.Next(n--);
                            string temp = y[n];
                            y[n] = y[k];
                            y[k] = temp;
                        }
                        for (int t = 0; t < y.Length; t++)
                            Console.WriteLine($"{y}");
                    }
                    Console.ReadKey();

                }
            }
            catch (IOException e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
                Console.ReadKey();
            }
        }
    }
}
