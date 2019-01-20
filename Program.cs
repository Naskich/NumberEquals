using System;

namespace NumberEquals
{
    class Program
    {
        static void Main()
        {
            Console.Write("Въведете стойност а = ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Въведете стойност b = ");
            int b = int.Parse(Console.ReadLine());
        
            int sum = a + b;
            Console.WriteLine("Sum = {0}", sum);
            
            if (sum > 10)
            {
                Console.WriteLine(" The number {0} is true", sum);
                Console.WriteLine(DateTime.Now);
            }
            else if (sum < 10)
            {
                Console.WriteLine("The number {0} is false", sum);
            }
            else
            {
                Console.WriteLine("The number {0} is error", sum);
            } 
        }
    }
}
