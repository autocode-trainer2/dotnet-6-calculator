namespace FancyCalc
{
    public class FancyCalc
    {
        public double Add(int a, int b)
        {
            fun1(1);
            return a + b;
        }


        public double Subtract(int a, int b)
        {
            return a - b;
        }


        public double Multiply(int a, int b)
        {
            return a * b;
        }

        void fun1(int n)
        {
            if (n > 0)
            {
                fun1(n + 1);
            }
        }
    }
}