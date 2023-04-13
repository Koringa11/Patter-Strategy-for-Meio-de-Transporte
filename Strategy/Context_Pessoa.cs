using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class Context_Pessoa
    {
        public readonly Interface_Transporte Transporte;

        public Context_Pessoa(Interface_Transporte meioTransporte)
        {
            Transporte = meioTransporte;
        }

        public void Locomocao()
        {
            Transporte.Locomocao();
        }
    }
}
