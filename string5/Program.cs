using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace string5
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int x = Convert.ToInt32(s.Substring(0, s.IndexOf(' ')));
            float y = float.Parse(s.Substring(
                s.IndexOf(' '),s.Length-s.IndexOf(' ')) );
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.ReadKey();
        }
    }
}
