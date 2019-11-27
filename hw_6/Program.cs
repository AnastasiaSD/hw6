using System;
using System.Linq;

namespace hw_6
{
    class Program
    {
        static void Main(string[] args)
        {
            var b = new Bancomat();
            
            Console.WriteLine("Выдать: slvhk");
            b.GetCash("slvhk");
            Console.WriteLine("===================================");
            
            Console.WriteLine("Выдать: 111₽");
            b.GetCash("111₽");
            Console.WriteLine("===================================");
            
            var cash = b.GetCash("1234$");
            Console.WriteLine("Выдать: 1234$");
            foreach (var banknote in cash)
            {
                Console.WriteLine(banknote);
            }
            Console.WriteLine("===================================");
            
            cash = b.GetCash("8470₽");
            Console.WriteLine("Выдать: 8470₽");
            foreach (var banknote in cash)
            {
                Console.WriteLine(banknote);
            }
            Console.WriteLine("===================================");
            
            cash = b.GetCash("2490€");
            Console.WriteLine("Выдать: 2490€");
            foreach (var banknote in cash)
            {
                Console.WriteLine(banknote);
            }
            Console.WriteLine("===================================");
        }
    }
}