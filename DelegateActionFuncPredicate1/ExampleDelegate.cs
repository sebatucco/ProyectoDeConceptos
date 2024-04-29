using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateActionFuncPredicate1
{
    // func<>, action<>, predicate<> se usan sin necesidad de definir
    // void action<in T> (T obj)
    // TResult Func<in T, out TResult> (T arg)
    // bool predicate<in T> (T obj)
    public delegate void Imprimir(string valor);    // Tipo delegado de una determinada firma
    public class ExampleDelegate
    {
        public void ImprimiPantalla(string v)
        { 
            Console.WriteLine(v);
        }

        public void EjecucionDelegado() 
        { 
            Imprimir ejecutaDelegado = new Imprimir(ImprimiPantalla); // implementa delegado y es asignado a una variable de tipo delegado

        }
    }
}



