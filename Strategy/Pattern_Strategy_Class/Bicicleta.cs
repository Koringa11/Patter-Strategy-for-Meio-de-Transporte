using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Pattern_Strategy_Class
{
    public class Bicicleta : Interface_Transporte
    {
        public void Locomocao()
        {
            Console.WriteLine("Viajando de Bicicleta, mil e uma pedaladas por minuto");
        }
    }
}
