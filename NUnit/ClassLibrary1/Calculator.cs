namespace ClassLibrary1
{
    public class Calculator
    {
        public List<int> NumberRange = new();
        public static int AddNumbers(int a, int b) => a + b;
        public static bool IsOddNumber(int a) => a % 2 == 0;
        public static double AddDoubles(double a, double b) => a + b;
        public List<int> GetOddRange(int min, int max)
        {
            NumberRange.Clear();
            for (int i = min; i < max; i++)
            {
                if (i % 2 != 0)
                {
                    NumberRange.Add(i);
                }
            }
            return NumberRange;
        }
    }
}