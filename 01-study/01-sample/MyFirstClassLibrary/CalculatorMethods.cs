namespace MyFirstClassLibrary
{
    public class CalculatorMethods
    {
        public static float Add(float a, float b)
        {
            return a + b;
        }

        public static float Subtract(float a, float b)
        {
            return a - b;
        }

        public static float Multiply(float a, float b)
        {
            return a * b;
        }

        public static float Divide(float a, float b)
        {
            if (a == 0)
                return 0;
            else
                return a / b;
        }
    }
}
