using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asp.net.digilevich.kontrolnaya.binarnoe_derevo_poiska
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree<int> tree = new BinaryTree<int>();
            tree.Add(1);
            tree.Add(4);
            tree.Add(2);
            tree.Add(55);
            tree.Add(3);
            tree.Remove(55);
            tree.Add(56);
            tree.Print();
            Console.Read();
        }
    }
}
