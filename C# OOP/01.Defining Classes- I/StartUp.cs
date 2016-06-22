namespace MobilePhone
{
    using System;
  

   public class StartUp
    {
        static void Main()
        {

            GSMTest.PhoneTest();


            var callTest = new GSMCallHistoryTest();
            callTest.Test();

   




        }
    }
}
