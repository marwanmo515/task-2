namespace task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region question 1 
            Console.Write("Enter an integer number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Numbers from 1 to {number}:");
            for (int i = 1; i <= number; i++)
            {
                Console.Write(i + " ");
            }
            #endregion
        }
    }
}
