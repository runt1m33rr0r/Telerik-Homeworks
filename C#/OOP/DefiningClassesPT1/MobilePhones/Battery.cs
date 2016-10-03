namespace MobilePhones
{
    using System;
    using System.Text;

    class Battery
    {
        private string model;
        private int? idleHours;
        private int? talkHours;
        private BatteryType batteryType;

        public Battery(string batModel)
        {
            Model = batModel;
        }

        public Battery(string batModel, int? batHoursIdle = null, int? batHoursTalk = null,
            BatteryType typeOfBattery = BatteryType.unknown) : this(batModel)
        {
            HoursIdle = batHoursIdle;
            HoursTalk = batHoursTalk;
            BatType = typeOfBattery;
        }

        public string Model
        {
            get
            {
                return model;
            }
            private set
            {
                if (value == null || value == string.Empty)
                {
                    throw new ArgumentException("The battery model can not be empty!");
                }
                else
                {
                    model = value;
                }
            }
        }
        public int? HoursIdle
        {
            get
            {
                return idleHours;
            }
            private set
            {
                if (value > 0 || value == null)
                {
                    idleHours = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("The idle hours of the battery must fit in int32 and be a positive number!");
                }
            }
        }
        public int? HoursTalk
        {
            get
            {
                return talkHours;
            }
            private set
            {
                if (value > 0 || value == null)
                {
                    talkHours = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("The talk hours of the battery must fit in int32 and be a positive number!");
                }
            }
        }
        public BatteryType BatType
        {
            get
            {
                return batteryType;
            }
            set
            {
                batteryType = value;
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.Append(string.Format("\nBattery model: {0}\n", model));

            if (idleHours != null)
            {
                result.Append(string.Format("Battery hours idle: {0}\n", idleHours));
            }
            else
            {
                result.Append(string.Format("Battery hours idle: unknown\n"));
            }

            if (talkHours != null)
            {
                result.Append(string.Format("Battery hours talk: {0}\n", talkHours));
            }
            else
            {
                result.Append(string.Format("Battery hours talk: unknown\n"));
            }

            result.Append(string.Format("Battery type: {0}", batteryType));

            return result.ToString();
        }
    }
}
