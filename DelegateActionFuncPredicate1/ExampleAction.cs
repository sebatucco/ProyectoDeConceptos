using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//action siempre devuelve void y recibe de 1 a 16
//https://www.youtube.com/watch?v=v1vTB5J315Q&ab_channel=ConsejosC%23
//https://www.youtube.com/watch?v=E1mOAWAuLRs&list=PLesmOrW3mp4gLW0jV9tdQn1LaZjRUAslm&ab_channel=NetMentor
//https://www.youtube.com/watch?v=I_fdCzza2mg&ab_channel=hdeleon.net
//https://www.youtube.com/watch?v=FBotA7GebeY&ab_channel=EddyCode
//https://www.youtube.com/watch?v=GMoabxgdGo8&ab_channel=hdeleon.net
namespace DelegateActionFuncPredicate1
{
    public delegate void ImprimirAction<T>(string valor); 
    public class ExampleAction
    {
        public void ImprimiPantalla(string v)
        { 
            Console.WriteLine(v);
        }

        public void EjecucionAction() 
        { 
            Action<string> ejecutaDelegado = ImprimiPantalla;
        }
    }
}
