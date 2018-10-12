using System;
namespace HelloWorld
{
    public class Numbers
    {
        int a;
        int b, c, d;

        public Numbers(int _a, int _b, int _c, int _d)
        {
            a = _a;
            b = _b;
            c = _c;
            d = _d;
        }

        public int add() {
            return a + b;
        }

        public int divide()
        {
            return a / b;
        }

    }
}
