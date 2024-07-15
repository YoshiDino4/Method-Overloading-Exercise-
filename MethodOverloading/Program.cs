namespace MethodOverloading
{
    public class Program
    {

        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static decimal Add(decimal a, decimal b)
        {
            return a + b;
        }

        public static string Add(int a, int b, bool moneys)
        {
            int sum = a + b;
            
            if (moneys == true)
            {
                if (sum == 1)
                {
                    return "1 dollar";
                }
                else
                {
                    return $"{sum} dollars";
                }
            }
            else
            {
                return $"{sum}";
            }
        }
        static void Main(string[] args)
        {
            var sum = Add(2, 2, false);
            var sumTwo = Add(.5m, .2m);
            var sumThree = Add(1, 0, true);
            var sumFour = Add(1, 5, true);
            Console.WriteLine(sum);
            Console.WriteLine(sumTwo);
            Console.WriteLine(sumThree);
            Console.WriteLine(sumFour);
        }
    }
}
