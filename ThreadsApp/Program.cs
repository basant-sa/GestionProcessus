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

        static void B()
        {
            mutex.WaitOne();

            Console.WriteLine("B " + iCommun);
            iCommun++;

            mutex.ReleaseMutex();
        }

        static void A()
        {
            mutex.WaitOne();

            Console.WriteLine("A " + iCommun);
            iCommun++;

            mutex.ReleaseMutex();
        }

        static Mutex mutex = new Mutex();
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
