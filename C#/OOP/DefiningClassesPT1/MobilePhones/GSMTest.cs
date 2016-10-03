namespace MobilePhones
{
    using System;
    using System.Collections.Generic;

    class GSMTest
    {
        public static void StartGSMTest()
        {
            List<GSM> phones = new List<GSM>();

            try
            {
                phones.Add(new GSM("OnePlus 2", "OnePlus", "Alexander", 600, new Display(5.5, 100000),
                    new Battery("oneplus", 60, 30, BatteryType.LiIon)));
                phones.Add(new GSM("Sony Xperia z5", "Sony"));
                phones.Add(new GSM("Samsung Galaxy S7", "Samsung", gsmPrice: 1500, gsmDisplay: new Display(5, 90000), gsmBattery: new Battery("samsung")));
                phones.Add(new GSM("Nexus 6P", "Google"));
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
            }

            Console.Write(string.Join("\n======================\n", phones));

            Console.Write("\n======================\n{0}", GSM.iPhone);
        }
    }
}
