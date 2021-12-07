namespace FancyCalc
{
    public class FancyCalc
    {
        public IStorage Storage { get; set; }

        public double Add(int a, int b)
        {
//             throw new NotImplementedException();
            return a + b;
        }


        public double Subtract(int a, int b)
        {
//             throw new NotImplementedException();
            return a - b;
        }


        public double Multiply(int a, int b)
        {
            return a * b;
//              throw new NotImplementedException();
            
        }
    }
}
