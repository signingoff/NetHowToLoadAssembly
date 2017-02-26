using System;

namespace HowToLoad
{
    public class Worker
    {
        private   bool _stoped;

        public void DoWork()
        {
            while (!_stoped)
            {
                Console.WriteLine("Worker Thread is working...");
            }
            
            Console.WriteLine("Work Thread stoppped.");
        }

        public void Stop()
        {
            _stoped = true;
        }
    }
}