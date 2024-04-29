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
    public class ExampleMetodoAnonimo
    {
        public delegate int OperacionDeNumeros(int numero1, int numero2);

        public static void EjecucionDelegados()
        {
            OperacionDeNumeros sumaDeNumeros = delegate(int a, int b) { return a + b; }; // metodo anonimo
            sumaDeNumeros(2, 3);

            OperacionDeNumeros sumaDeNumerosLambda = (a, b) => a + b; // lambda
            sumaDeNumerosLambda(2, 3);

        }
    }
}



