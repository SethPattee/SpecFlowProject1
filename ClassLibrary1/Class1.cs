namespace ClassLibrary1
{
    public class Calculator
    {
        public float AddTwoIntegers(float a, float b)
        { 
            if (float.MaxValue - Math.Abs(a) < Math.Abs(b) )
            {
                throw new Exception("Numbers get too large");
            }
            else
            {
                return a + b;
            }
            
        }

        public float SubtractTwoIntegers(float a, float b)
        {
            return a - b;
        }

        public float MultiplyTwoIntegers(float a, float b)
        {
            return a * b;
        }

        public float DivideTwoIntegers(float a, float b)
        {
            if(b == 0)
            {
                throw new Exception("Divide by zero");
            }
            else
            {
                return a / b;
            }
            
        }

    }
}