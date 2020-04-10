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
        public void Task51(string Name)
        {
            string line;
            int i = 0;
            
            try
            {
                using (StreamReader sr = new StreamReader(Name))
                {
                    string[] x = { };
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] lines = line.Split('.');
                        for(int r = 0; r < lines.Length; r++)
                        {
                            x[i] = lines[r];
                            i++;
                        }
                        Console.WriteLine(line);
                        //text += line;
                    }
                }
                Console.WriteLine($"{line}");
                Console.ReadKey();
                
            }
            catch (IOException e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
        }
    }
}
