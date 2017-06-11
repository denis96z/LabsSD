using System;
using Lab2.Queue;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            MQueue queue = new MQueue();
            for (int i = 0; i < 5; i++)
            {
                queue.Enqueue(i);
            }

            while (true)
            {
                Console.WriteLine("Нажмите любую клавишу...");

                queue.Dequeue();
                queue.Enqueue(new Random().Next(-10, 10));

                ConsoleKeyInfo c = Console.ReadKey();
                Console.Clear();

                Console.WriteLine("Состояние очереди:");
                foreach (var item in queue)
                {
                    Console.Write("{0}\t", item);
                }
                Console.WriteLine("\nМинимум:{0}\nМаксимум:{1}",
                    queue.Min(), queue.Max());
            }
        }
    }
}
