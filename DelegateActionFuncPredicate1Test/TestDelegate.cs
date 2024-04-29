using DelegateActionFuncPredicate1;

namespace DelegateActionFuncPredicate1Test
{
    public class TestDelegate
    {
        [Fact]
        public void Test1()
        {
           ExampleDelegate exampleDelegate = new ExampleDelegate();
           exampleDelegate.EjecucionDelegado();

        }
    }
}