namespace MobilePhone
{
    using System;

    public enum BatteryType
    {
        LiIon,
        NiMh,
        NiCd,
        LiPolyester
    }

   public class Battery
    {
        private BatteryType batteryModel;
        private int hoursIdle;
        private int hoursTalk;

        public Battery(BatteryType batteryModel, int hoursIdle, int hoursTalk)
        {
            this.BatteryModel = batteryModel;
            this.HoursIdle = hoursIdle;
            this.HoursTalk = hoursTalk;
        }

        public BatteryType BatteryModel { get { return this.batteryModel; } set { this.batteryModel = value; } }

        public int HoursIdle
        {
            get
            {
                return this.hoursIdle;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Hours Idle cannot be negative nunber");
                }
                this.hoursIdle = value;
            }
        }

        public int HoursTalk
        {
            get
            {
                return this.hoursTalk;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Hours talked cannot be a negative number");
                }
                this.hoursTalk = value;
            }
        }

    }
}
