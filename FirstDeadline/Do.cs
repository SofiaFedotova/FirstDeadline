using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDeadline
{
    public struct Date
    {
        public int day;
        public int month;
        public int year;

        public void DisplayInfo()
        {
            Console.WriteLine($"{day}.{month}.{year}");
        }
    }
      public class Do
    {
        private string Title;
        private string Description;
        private Date Deadline;
        private string[] Tags;

        public string Title1 { get => Title; set => Title = value; }
        public string Description1 { get => Description; set => Description = value; }
        public string[] Tags1 { get => Tags; set => Tags = value; }
        internal Date Deadline1 { get => Deadline; set => Deadline = value; }

        public Do(string T, string D, int Day, int Month, int Year, string[] Tag) {
            Title1 = T;
            Description1 = D;
            Deadline.day = Day;
            Deadline.month = Month;
            Deadline.year = Year;
            Tags = Tag;
        }
        public Do(){ }

    }
}
