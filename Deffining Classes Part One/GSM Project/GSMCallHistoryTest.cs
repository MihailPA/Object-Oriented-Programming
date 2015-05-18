using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSM_Project
{
    public class GSMCallHistoryTest
    {
        public static void GSMCallHistTest()
        {
            var GSMToTest = new GSM("Sony", "Xperia Z", 200, "VanCho", new Battery("Sony", Battery.BatteryTypes.LiIon, 180, 12), new Display("500x600", "65000"));

            GSMToTest.AddCalls(new Call("12/12/2014 12:54:40", "+35988887799", 500));
            GSMToTest.AddCalls(new Call("13/12/2014 16:55:12", "+35988881199", 320));
            GSMToTest.AddCalls(new Call("14/12/2014 19:20:30", "+35988884499", 123));

            PrintCallHistory(GSMToTest);

            Console.WriteLine("The total price of all cals is: {0:F2}", GSMToTest.CalculateTotalCallPrice(0.37M));

            var longestCall = 0;
            var longestCallIndex = 0;
            for (int i = 0; i < GSMToTest.CallHistory.Count; i++)
            {
                if (GSMToTest.CallHistory[i].Duration > longestCall)
                {
                    longestCall = GSMToTest.CallHistory[i].Duration;
                    longestCallIndex = i;
                }
            }

            GSMToTest.DeleteCall(GSMToTest.CallHistory[longestCallIndex]);

            Console.WriteLine("The total price of all cals is: {0:F2}", GSMToTest.CalculateTotalCallPrice(0.37M));

            GSMToTest.ClearHistory();

            PrintCallHistory(GSMToTest);


        }

        public static void PrintCallHistory(GSM GSMToTest)
        {
            foreach (var call in GSMToTest.CallHistory)
            {
                Console.WriteLine(call);
            }
        }

    }
}
