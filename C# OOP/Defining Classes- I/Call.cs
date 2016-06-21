namespace MobilePhone
{
    using System;

   public class Call
    {
        private DateTime date;
        private int dialedPhoneNumber;
        private int duration;

        public Call(DateTime date, int dialedPhoneNumber, int duration)
        {
            this.Date = date;
            this.DialedPhoneNumber = dialedPhoneNumber;
            this.Duration = duration;
        }

        public DateTime Date
        {
            get
            {
                return this.date;
            }
            set
            {
                this.date = value;
            }
        }

        public int DialedPhoneNumber
        {
            get
            {
                return this.dialedPhoneNumber;
            }
            set
            {
                this.dialedPhoneNumber = value;
            }
        }

        public int Duration
        {
            get
            {
                return this.duration;
            }
            set
            {
                this.duration = value;
            }

        }

        public override string ToString()
        {
            var callInfo = $"{this.Date}\t{this.Date}\t{this.dialedPhoneNumber}\t\t{this.Duration}";
            return callInfo;
        }

    }
}
