namespace MobilePhones
{
    using System;

    class EntryPoint
    {
        static void Main()
        {
            GSMTest.StartGSMTest();
            Console.WriteLine();
            Console.WriteLine();
            GSMCallHistoryTest.StartCallHistoryTest();
        }
    }
}
