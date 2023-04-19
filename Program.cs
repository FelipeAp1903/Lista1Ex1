using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1EX_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Double b;
            Double h;
            Double a;
            
            Console.WriteLine("coloque o valor da base(b):");
            b = Double.Parse(Console.ReadLine());
            Console.WriteLine("coloque o valor da altura(h):");
            h = Double.Parse(Console.ReadLine());
            a = b * h;
            Console.WriteLine("o valor da Área é: {0}", a);



        }
    }
}
