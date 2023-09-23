namespace Задача_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Write number 1: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Write number 2: ");
            int m = Convert.ToInt32(Console.ReadLine());
            if (n < m)
            {
                for (int i = n; i <= m; i++)
                {
                    if (i % 2 == 0)
                    {
                        Console.Write(i + " ");
                    }
                }
            }
            else 
            {
                int tmp = m;
                m = n;
                n=tmp;
                for (int i = n; i <= m; i++)
                {
                    if (i % 2 == 0)
                    {
                        Console.Write(i + " ");
                    }
                }
            }
        }
    }
}