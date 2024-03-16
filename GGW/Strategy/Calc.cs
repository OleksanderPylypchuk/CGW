using Strategy.Interfaces;

namespace Strategy
{
    public class Calc
    {
        public IMethod Method;
        public Calc(IMethod method)
        {
            Method = method;
        }
        public void Calculate(int A, int B)
        {
            Method.Action(A, B);
        }
    }
}
