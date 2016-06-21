using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone
{
   public class GSMCallHistoryTest

    {
        private GSM Telephone = new GSM("Galaxy Tab", "Samsung", 720.99, "Slavcho", new Battery(BatteryType.LiIon, 400, 200), new Display(5.7, 16000000));

        public void Test()
        {
            

            Telephone.AddCall(new Call(new DateTime(2016, 06, 11), 0889312119, 350));
            Telephone.AddCall(new Call(new DateTime(2016, 06, 12), 0887568431, 120));
            Telephone.AddCall(new Call(new DateTime(2016, 06, 13), 0898658479, 280));
            Console.WriteLine(Telephone.CallHistoryInfo());
            double totalPrice = 0;
            foreach (Call item in Telephone.CallHistory)
            {
                totalPrice += (double)(item.Duration / 60) * GSM.CallPrice;
            }
            Console.WriteLine("Total price of calls is: {0} BGN",totalPrice);
            Console.WriteLine("Removing longest call.....");
            double longestcall = 0;
            foreach (Call item in Telephone.CallHistory)
            {
                longestcall = Math.Max(item.Duration, longestcall);
                longestcall /= 60;
            }
            totalPrice = 0;
            foreach (Call item in Telephone.CallHistory)
            {
                totalPrice += ((double)(item.Duration / 60) )* GSM.CallPrice;  
            }
            totalPrice -= longestcall * GSM.CallPrice;
            Console.WriteLine("Total price of calls without longest call is is: {0:F2} BGN", totalPrice);
            Telephone.ClearHistory();
            Console.WriteLine(Telephone.CallHistoryInfo()); 



        }

        

    }
             
    }


   