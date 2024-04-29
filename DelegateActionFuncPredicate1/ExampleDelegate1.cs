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
    public class ExampleDelegate1
    {

        public static string ReverseString(string s)
        {
            return new string(s.Reverse().ToArray());

        }
    }
}



