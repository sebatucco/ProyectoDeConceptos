using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateActionFuncPredicate1
{
    public delegate void Imprimir<T>(string valor); 
    public class ExampleDelegateGeneric
    {
        public void ImprimiPantalla(string v)
        { 
            Console.WriteLine(v);
        }

        public void EjecucionDelegado() 
        { 
            Imprimir<string> ejecutaDelegado = new Imprimir<string>(ImprimiPantalla);
        }
    }
}
