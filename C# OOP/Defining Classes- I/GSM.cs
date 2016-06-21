namespace MobilePhone
{
    using System;
    using System.Text;
    using System.Collections.Generic;

   public class GSM
    {

        public static GSM Iphone4s = new GSM("4s", "Apple", 300, "Ivan", new Battery(BatteryType.LiIon, 250, 145), new Display(3.5, 16000000));
         public const double CallPrice = 0.35;

        private string model;
        private string manufacturer;
        private double price;
        private string owner;
        private Battery battery;
        private Display display;
        private List<Call> callHistory = new List<Call>();


        public GSM(string model, string manufacturer, double price, string owner, Battery battery, Display display)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Price = price;
            this.Owner = owner;
            this.battery = battery;
            this.display = display;
        }

        public GSM(string model, string manufacturer)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
        }

        public void DisplayInfo()
        {
            Console.WriteLine(" Model: {0} \n Manufacturer: {1} \n\r Price: {2} \n Owner: {3} \n Battery: [Type: {4}] [Idle: {5}h] [Talk: {6}h] \n Display:[Number of colors: {7}] [Size: {8} inch] \n\n  ", Model, Manufacturer, Price, Owner, battery.BatteryModel,
                battery.HoursIdle, battery.HoursTalk, display.NumberOfColors, display.Size);
        }

        public string CallHistoryInfo()
        {
            var callHistoryInfo = new StringBuilder();

            if (this.callHistory.Count == 0)
            {
                return "Call history is empty!";
            }

            callHistoryInfo.Append("Date\t\tTime\t\tDailed number\tDuration seconds\n");

            for (int i = 0; i < this.callHistory.Count; i++)
            {
                callHistoryInfo.Append(this.callHistory[i].ToString());
                callHistoryInfo.Append("\n");
            }

            return callHistoryInfo.ToString();
        }


        public void AddCall(Call calling)
        {
            this.callHistory.Add(calling);
        }


        public void ClearHistory()
        {
            this.callHistory.Clear();
        }



        public List<Call> CallHistory
        {
            get
            {
                return this.callHistory;
            }
            set
            {
                this.callHistory = value;
            }

        }

        public string Model
        {
            get
            {
                return this.model;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("You must set the model");
                }
                this.model = value;
            }
        }

        public string Manufacturer
        {
            get
            {
                return this.manufacturer;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("You must set the manufacturer");
                }
                this.manufacturer = value;
            }
        }

        public double Price
        {
            get
            {
                return this.price;
            }
            set
            {
                if (price < 0)
                {
                    throw new ArgumentException("Price cannot be negative number");
                }
                this.price = value;
            }
        }

        public string Owner
        {
            get
            {
                return this.owner;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("You should insert Owner's name");
                }
                this.owner = value;
            }
        }

        public Display Display
        {
            get
            {
                return this.display;
            }

            set
            {
                this.display = value;
            }
        }

        public Battery Battery
        {
            get
            {
                return this.battery;
            }

            set
            {
                this.battery = value;
            }
        }
    }
}
