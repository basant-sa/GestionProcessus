namespace ThreadsApp
{
    internal class Program
    {
      
            const int N = 5;

            static void f()
            {
                for (int i = 0; i < N; i++)
                {
                    Console.Write("FFFFFFFF ");
                }
            }

            static void g()
            {
                for (int i = 0; i < N; i++)
                {
                    Console.Write("GGGGGGGG ");
                }
            }

            static void Main()
            {
                Thread t1 = new Thread(f);
                Thread t2 = new Thread(g);

                t1.Start();
                t2.Start();

                t1.Join();
                t2.Join();


                Console.WriteLine("\nFin des threads");
                Console.ReadLine();
            }

        
    }
}
