using CodeBaseStrongAssembly;
using DependentRedirectAssembly;
using HowToLoad;
using PrivatePathAssembly;
using System;
using System.Threading;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Worker worker = new Worker();
            Thread workerThread = new Thread(worker.DoWork);

            workerThread.Start();
            Console.WriteLine("Main thread: starting worker thread...");

            while (!workerThread.IsAlive)
            {
            }

            Thread.Sleep(1);

            worker.Stop();

            workerThread.Join();
            Console.WriteLine("Main Thread: worker thread terminated.");
            new PrivatePathAssemblyClass().Print();
            new CodeBaseStrongAssemblyClass().Print();
            new DependentRedirectAssemblyClass().Print();
            Console.ReadKey();
        }
    }
}
