using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            Arrays number = new Arrays(3);

            number.insert(0);
            number.insert(1);
            number.insert(2);
            number.insert(3);
            number.insert(4);
            number.print();

            number.removeAt(1);
            number.print();

            number.removeAt(2);
            number.print();

            Console.ReadLine();
        }
    }
}
