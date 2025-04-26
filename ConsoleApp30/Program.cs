namespace ConsoleApp30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 ve 100 arasinda natural n ededini daxil edin: !");
            int n = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            if (n > 0 || n < 100)
            {
                for (int i = 0; i <= n; i++)
                {
                    if (i % 2 == 1)
                    {
                        sum += i;
                    }
                }
                if (sum > 0)
                {
                    Console.WriteLine("Tek ededlerin cemi: " + sum);
                }
                else
                {
                    Console.WriteLine("Tek eded tapilmadi.");
                }
            }
            else
            {
                Console.WriteLine("1 ile 100 arasinda natural eded secin ");
            }
        }
    }
}

