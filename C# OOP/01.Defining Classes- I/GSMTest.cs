namespace MobilePhone
{
    using System;

   public class GSMTest
    {
        public static void PhoneTest()
        {

            GSM[] ArrOfGSMs = new GSM[]
            {
           new GSM("G3", "LG", 470.99, "Krisko", new Battery(BatteryType.LiIon,150,55), new Display(5.5, 16000000)),
           new GSM("6s", "Apple", 800, "Stoyan", new Battery(BatteryType.NiCd,230,45), new Display(5, 32000000)),
           new GSM("Galaxy s7 Edge", "Sumsung", 750, "Batman", new Battery(BatteryType.NiMh,420,230), new Display(5.8, 18000000))
            };

            foreach (GSM gsm in ArrOfGSMs)
            {
                gsm.DisplayInfo();
            }
            GSM.Iphone4s.DisplayInfo();
        }
    }
}
