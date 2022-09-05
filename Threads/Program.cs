namespace LINQ
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Thread.CurrentThread.Name = "Main Thread";
            Console.WriteLine($"Begin with the {Thread.CurrentThread.Name}");
            Thread func1 = new Thread(Function1);
            Thread func2 = new Thread(Function2);
            func1.Name = "First Thread";
            func2.Name = "Second Thread";

            func1.Start();
            func2.Start();


            Console.WriteLine($"End with the {Thread.CurrentThread.Name}");


        }
        static void Function1()
        {
            Console.WriteLine($"Begin with the {Thread.CurrentThread.Name}");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"From Function 1 : {i}");
                Thread.Sleep(1000);
            }
            Console.WriteLine($"End with the {Thread.CurrentThread.Name}");
        }
        static void Function2()
        {
            Console.WriteLine($"Begin with the {Thread.CurrentThread.Name}");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"From Function 2 : {i}");
                Thread.Sleep(1000);
            }
            Console.WriteLine($"End with the {Thread.CurrentThread.Name}");
        }

    }
}

