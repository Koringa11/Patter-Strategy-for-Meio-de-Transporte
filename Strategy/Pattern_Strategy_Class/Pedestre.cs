using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Pattern_Strategy_Class
{
    public class Pedestre : Interface_Transporte
    {
        public void Locomocao()
        {
            Console.WriteLine("O homem mais rápido do mundo!");
        }
    }
}
