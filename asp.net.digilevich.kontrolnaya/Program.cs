using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asp.net.digilevich.kontrolnaya
{
    class Program
    {
        static void Main(string[] args)
        {
            TwoDirectionList<int> mylist = new TwoDirectionList<int>();
            mylist.Add(1);
            mylist.Add(2);
            mylist.Add(3);
            foreach(var item in mylist)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
