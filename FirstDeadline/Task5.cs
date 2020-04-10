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
            string line, text;
            try
            {
                using (StreamReader sr = new StreamReader(Name))
                {
                    while ((line = sr.ReadLine()) != null)
                    {
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
