namespace _7_Timer
{
    using System;

    public class Test
    {
        public void PrintText()
        {
            Console.WriteLine("invoked!");
        }

        private static void Main()
        {
            Timer timer = new Timer(1, new Test().PrintText);
            timer.InvokeDelegate();
        }
    }
}
