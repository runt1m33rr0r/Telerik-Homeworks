namespace _7_Timer
{
    using System.Diagnostics;

    public class Timer
    {
        private readonly int seconds;
        private Method someMethod;

        public Timer(int seconds, Method currentMethod)
        {
            this.seconds = seconds;
            this.someMethod = currentMethod;
        }

        public delegate void Method();

        public void InvokeDelegate()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            var myDelegate = new Method(this.someMethod);

            while (true)
            {
                if (stopwatch.Elapsed.Seconds != this.seconds)
                {
                    continue;
                }

                myDelegate.Invoke();
                stopwatch.Restart();
            }
        }    
    }
}
