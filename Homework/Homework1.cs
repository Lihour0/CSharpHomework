namespace Homework
{
    internal class Homework1
    {
        private int num1, num2;

        public int sum(int lh, int rh)
        {
            return (lh + rh);
        }

        public void run()
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Enter 2 Integer to Sum:");
                    Console.Write("Enter Integer 1: ");
                    num1 = int.Parse(Console.ReadLine());
                    Console.Write("Enter Integer 2: ");
                    num2 = int.Parse(Console.ReadLine());
                    Console.WriteLine("The sum is: {0}", sum(num1, num2));
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid Input. Only Integer is accepted");
                }
            }
        }
    }
}
