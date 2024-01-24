using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rettangolo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rettangolo rettangolo = new Rettangolo();
            Console.WriteLine(" ");
            rettangolo.latominore=double.Parse(Console.ReadLine());
            Console.WriteLine(" ");
            rettangolo.latomaggiore = double.Parse(Console.ReadLine());
            Console.WriteLine("{0}",rettangolo.area());
            Console.WriteLine("{0}", rettangolo.perimetro());
            Console.ReadLine();
        }
    }
}
