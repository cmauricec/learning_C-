//Christopher Maurice 
//Lab 3 
//Task 5 
namespace MyMaxLib
{
    public class Max
    {
        public static double Mymax(double a, double b, double c, double number)
        {
            double max;
            if (number == 3)
            {
                double[] arr = { a, b, c };
                max = arr.Max();
                Console.WriteLine("The max of " + a + ", " + b + ", " 
                + c + " is " + max);
            }
            else
            {
                max = Math.Max(a, b);
                Console.WriteLine("The max of " + a + ", " + b + "is" + max);
            }
            return max;

        }

    }

}


