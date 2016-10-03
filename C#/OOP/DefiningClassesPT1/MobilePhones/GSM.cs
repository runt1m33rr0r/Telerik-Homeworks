namespace MobilePhones
{
    using System;
    using System.Text;
    using System.Collections.Generic;

    class GSM
    {
        private string model;
        private string manufacturer;
        private string owner;
        private int? price;
        private Display phoneDisplay;
        private Battery phoneBattery;
        private List<Call> callHistory;
        private double callPrice = 0.37;

        private static GSM iPhone4S = new GSM("iPhone 4S", "Apple", "Kifla", 2500, new Display(5, 1000), new Battery("Ruski akumulator XD", 24, 10));

        public GSM(string gsmModel, string gsmManufacturer)
        {
            callHistory = new List<Call>();

            PhoneModel = gsmModel;
            PhoneManufacturer = gsmManufacturer;
        }

        public GSM(string gsmModel, string gsmManufacturer, string gsmOwner = null, int? gsmPrice = null, Display gsmDisplay = null,
            Battery gsmBattery = null) : this(gsmModel, gsmManufacturer)
        {
            PhoneOwner = gsmOwner;
            PhonePrice = gsmPrice;

            phoneDisplay = gsmDisplay;
            phoneBattery = gsmBattery;
        }

        public static GSM iPhone
        {
            get
            {
                return iPhone4S;
            }
        }

        public List<Call> CallHistory
        {
            get
            {
                return callHistory;
            }
        }

        public string PhoneModel
        {
            get
            {
                return model;
            }
            private set
            {
                if (value == null || value == string.Empty)
                {
                    throw new ArgumentException("The phone model can not be empty!");
                }
                else
                {
                    model = value;
                }
            }
        }
        public string PhoneManufacturer
        {
            get
            {
                return manufacturer;
            }
            private set
            {
                if (value == null || value == string.Empty)
                {
                    throw new ArgumentException("The manufacturer of the phone can not be empty!");
                }
                else
                {
                    manufacturer = value;
                }
            }
        }
        public string PhoneOwner
        {
            get
            {
                return owner;
            }
            private set
            {
                if (value == string.Empty)
                {
                    throw new ArgumentException("The owner can not be empty!");
                }
                else
                {
                    owner = value;
                }
            }
        }
        public int? PhonePrice
        {
            get
            {
                return price;
            }
            private set
            {
                if (value > 0 || value == null)
                {
                    price = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("The price of the phone must fit in int32 and be a positive number!");
                }
            }
        }

        public void AddCall(Call someCall)
        {
            callHistory.Add(someCall);
        }

        public void RemoveCall(Call someCall)
        {
            callHistory.Remove(someCall);
        }

        public void RemoveCall(int callIndex)
        {
            callHistory.RemoveAt(callIndex);
        }

        public void ClearCallHistory()
        {
            callHistory.Clear();
        }

        public double TotalCallsPrice()
        {
            double result = 0;

            if (callHistory.Count > 0)
            {
                double allDuration = 0;

                foreach (var call in callHistory)
                {
                    allDuration += call.Duration;
                }

                result = callPrice * (allDuration / 60.0);
            }

            return result;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.Append(string.Format("GSM model: {0}\n", model));
            result.Append(string.Format("GSM manufacturer: {0}\n", manufacturer));

            if (owner != null)
            {
                result.Append(string.Format("GSM owner: {0}\n", owner));
            }
            else
            {
                result.Append(string.Format("GSM owner: unknown\n"));
            }

            if (price != null)
            {
                result.Append(string.Format("GSM price: {0}\n", price));
            }
            else
            {
                result.Append(string.Format("GSM price: unknown\n"));
            }

            if (phoneDisplay != null)
            {
                result.Append(string.Format("\nGSM display: {0}\n", phoneDisplay.ToString()));
            }
            else
            {
                result.Append(string.Format("GSM display: unknown\n"));
            }

            if (phoneBattery != null)
            {
                result.Append(string.Format("\nGSM battery: {0}", phoneBattery.ToString()));
            }
            else
            {
                result.Append(string.Format("GSM battery: unknown"));
            }

            return result.ToString();
        }
    }
}
