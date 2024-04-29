using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DelegateActionFuncPredicate1
{
    // func<>, action<>, predicate<> se usan sin necesidad de definir
    // void action<in T> (T obj)
    // TResult Func<in T, out TResult> (T arg)
    // bool predicate<in T> (T obj)
    public class ExampleCompleto
    {
        public delegate int OperacionDeNumeros(int numero1, int numero2);

        public static int SumaDeNumeros(int numero1, int numero2)
        {
            return (numero1 + numero2);        
        }

        public static int RestaDeNumeros(int numero1, int numero2)
        {
            return (numero1 - numero2);
        }

        public static void Mostrar(OperacionDeNumeros valor)
        {
            valor(2, 3);
        }

        public static void Mostrar2(Action<int, int> obj)
        { 
         obj(2, 3);
        }

        

        public static void EjecucionDelegados()
        {
            OperacionDeNumeros sumaDeNumeros = SumaDeNumeros;
            Mostrar(sumaDeNumeros);
            Func<int, int, int> restaDeNumeros = RestaDeNumeros; // ultimo parametro es lo que regreso
            restaDeNumeros(2, 3);
            Action<int, int> exampleAction = (x,y) => Console.WriteLine($"{x+y}");// action no devuelve nada
            var numbre = new List<int> { 1, 2, 3, 4 };
            var predicate = new Predicate<int>(x => x%2 == 0); // devuelve un bool
            var dividers2 = numbre.FindAll(predicate);
            dividers2.ForEach(x => Console.WriteLine(x));

        }

    }
}



