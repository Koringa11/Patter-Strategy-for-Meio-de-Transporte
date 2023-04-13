using Strategy.Pattern_Strategy_Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            var Context_Pessoa = new Context_Pessoa(new Carro());
            Context_Pessoa.Locomocao();
            Console.ReadKey();
        }
    }
}
