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

        static int iCommun = 0;

        static void A()
        {
            lock (verrou)
            {
                Console.WriteLine("A " + iCommun);
                iCommun++;
            }
        }

        static void B()
        {
            lock (verrou)
            {
                Console.WriteLine("B " + iCommun);
                iCommun++;
            }
        }

        static object verrou = new object();

        static void Main()
            {
                Thread t1 = new Thread(A);
                Thread t2 = new Thread(B);

                t1.Start();
                t2.Start();

                t1.Join();
                t2.Join();


                Console.WriteLine("\nFin des threads");
                Console.ReadLine();
            }

        
    }
}
