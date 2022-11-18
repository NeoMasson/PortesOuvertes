namespace Methods
{
    public class Method
    {
        public int Addition(int a, int b)
        {
            return a + b;
        }

        public int Substraction(int a, int b)
        {
            return a - b;
        }

        public int Multiplication(int a, int b)
        {
            return a * b;
        }

        public int Division(int a, int b)
        {
            return a / b;
        }

        public double Average(List<int> numbers)
        {
            double result = 0;
            //int result = numbers.Sum();
            foreach (int number in numbers)
            {
                result += number;
            }
            return result / numbers.Count;
        }

    }
}