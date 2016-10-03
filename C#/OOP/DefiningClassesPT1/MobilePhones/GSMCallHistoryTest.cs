namespace MobilePhones
{
    using System;

    class GSMCallHistoryTest
    {
        public static void StartCallHistoryTest()
        {
            try
            {
                GSM myPhone = new GSM("OnePlus 2", "OnePlus", "Alexander", 600, new Display(5.5, 100000),
                    new Battery("oneplus", 60, 30, BatteryType.LiIon));

                myPhone.AddCall(new Call("6/15/2016", "11:00", "0898541024", 104));
                myPhone.AddCall(new Call("6/14/2016", "10:00", "0898541025", 511));
                myPhone.AddCall(new Call("6/13/2016", "09:00", "0898541026", 151));

                Console.Write(string.Join("\n", myPhone.CallHistory));

                Console.WriteLine("\nTotal price of calls: {0:F2}", myPhone.TotalCallsPrice());

                RemoveLongestCall(myPhone);

                Console.WriteLine("\nTotal price of calls after removing the longest call: {0:F2}\n", myPhone.TotalCallsPrice());

                myPhone.ClearCallHistory();
                Console.WriteLine("Cleared the call history!");
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
            }
        }

        private static void RemoveLongestCall(GSM somePhone)
        {
            Call currentCall = new Call("0", "0", "0", 1);

            for (int i = 0; i < somePhone.CallHistory.Count; i++)
            {
                if (currentCall.Duration < somePhone.CallHistory[i].Duration)
                {
                    currentCall = somePhone.CallHistory[i];
                }
            }

            somePhone.RemoveCall(currentCall);
        }
    }
}
