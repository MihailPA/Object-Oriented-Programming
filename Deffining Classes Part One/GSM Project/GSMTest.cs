using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSM_Project
{
    class GSMTest
    {
        static void Main()
        {

            var arrayOfGSMs = new GSM[5];

            arrayOfGSMs[0] = new GSM("Sony", "Xperia Z", 200, "VanCho", new Battery("Sony", Battery.BatteryTypes.LiIon, 180, 12), new Display("500x600", "65000"));

            arrayOfGSMs[1] = new GSM("Samsung", "Galaxy S5");

            arrayOfGSMs[2] = new GSM("Nokia", "3310", 10);

            arrayOfGSMs[3] = new GSM("Samsung", "Galaxy S6", 600, "Gosho", new Battery("Samsung", Battery.BatteryTypes.NiMh, 250, 10), new Display("1280x920 HD", "16 000 000"));

            arrayOfGSMs[4] = new GSM("HTC", "One", null, "Ivan");


            for (int i = 0; i < arrayOfGSMs.Length; i++)
            {
                Console.WriteLine(arrayOfGSMs[i]);
            }


            Console.WriteLine(GSM.IPhone4S);


            GSMCallHistoryTest.GSMCallHistTest();



        }


    }
}
