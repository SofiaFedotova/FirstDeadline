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
                    //List<string> mas = new List<string>();
                   
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] lines = line.Split('.');
                        /*for (int r = 0; r < lines.Length; r++)
                        {
                            x[i] = lines[r];
                            i++;
                        }
                        */
                       for (int j = 0; j < lines.Length; j++)
                       {
                          string[] a = lines[j].Split(' ');
                          for (int f = a.Length-1; f >= 0; f--)
                            {

                                Random rnd = new Random(f);
                                    int k = rnd.Next(f);
                                    string temp = a[f];
                                    a[f] = a[k];
                                    a[k] = temp;
                                
                            }
                            for (int t = 0; t < a.Length; t++)
                                Console.WriteLine($"{a}");
                        }
                        
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
