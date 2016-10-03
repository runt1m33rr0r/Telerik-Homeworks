namespace MobilePhones
{
    using System;
    using System.Text;

    class Call
    {
        private string date;
        private string time;
        private string dialledPhoneNumber;
        private int duration;

        public Call(string callDate, string callTime, string callDialNumber, int callDuration)
        {
            Date = callDate;
            Time = callTime;
            DialledPhoneNumber = callDialNumber;
            Duration = callDuration;
        }

        public string Date
        {
            get
            {
                return date;
            }
            private set
            {
                if (value != string.Empty && value != null)
                {
                    date = value;
                }
                else
                {
                    throw new ArgumentException("The date cannot be empty!");
                }
            }
        }
        public string Time
        {
            get
            {
                return time;
            }
            private set
            {
                if (value != string.Empty && value != null)
                {
                    time = value;
                }
                else
                {
                    throw new ArgumentException("The time cannot be empty!");
                }
            }
        }
        public string DialledPhoneNumber
        {
            get
            {
                return dialledPhoneNumber;
            }
            private set
            {
                if (value != string.Empty && value != null)
                {
                    dialledPhoneNumber = value;
                }
                else
                {
                    throw new ArgumentException("The phone number cannot be empty!");
                }
            }
        }
        public int Duration
        {
            get
            {
                return duration;
            }
            private set
            {
                if (value > 0)
                {
                    duration = value;
                }
                else
                {
                    throw new ArgumentException("The duration must be a positive number!");
                }
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.Append(string.Format("Call date: {0}\n", date));
            result.Append(string.Format("Call time: {0}\n", time));
            result.Append(string.Format("Dialled phone number: {0}\n", dialledPhoneNumber));
            result.Append(string.Format("Call duration: {0}\n", duration));

            return result.ToString();
        }
    }
}
