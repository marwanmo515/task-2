namespace task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter an integer number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            // Print numbers from 1 to the entered number
            Console.WriteLine($"Numbers from 1 to {number}:");
            for (int i = 1; i <= number; i++)
            {
                Console.Write(i + " ");
            }
        }
    }
}
