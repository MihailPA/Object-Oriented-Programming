using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSM_Project
{
    public class GSM
    {

        //fields
        private static GSM iPhone4S = new GSM("Apple", "IPhone4S", 500, "Steve", new Battery("Apple", Battery.BatteryTypes.LiIon, 200, 8), new Display("640x960", "16 000 000"));

        private List<Call> callHistory;


        //constructors
        public GSM(string manufacturer, string model, decimal? price)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Price = price;
        }


        public GSM(string manufacturer, string model, decimal? price = null, string owner = null, Battery battery = null, Display display = null)
            : this(model, manufacturer, price)
        {
            this.Owner = owner;
            this.Battery = battery;
            this.Display = display;

        }

        //properties
        public string Model { get; set; }

        public string Manufacturer { get; set; }

        public decimal? Price { get; set; }

        public string Owner { get; set; }

        public Battery Battery { get; set; }

        public Display Display { get; set; }

        public decimal TotalCallPrice { get; set; }

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




        public static GSM IPhone4S
        {
            get
            {
                return iPhone4S;
            }


        }





        //methods

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine("Model: " + this.Model);
            sb.AppendLine("Manufacturer: " + this.Manufacturer);
            sb.AppendLine("Price: " + Convert.ToString(this.Price));
            sb.AppendLine("Owner: " + this.Owner);
            sb.Append(Battery);
            sb.Append(Display);
            return sb.ToString();
        }

        public void AddCalls(Call newCall)
        {
            if (this.callHistory == null)
            {
                this.callHistory = new List<Call>();
            }
            this.callHistory.Add(newCall);
        }

        public void DeleteCall(Call callToDelete)
        {
            this.callHistory.Remove(callToDelete);
        }

        public void ClearHistory()
        {
            this.callHistory = new List<Call>();
        }

        public decimal CalculateTotalCallPrice(decimal price)
        {
            int totalCallduration = 0;
            foreach (var call in this.CallHistory)
            {
                totalCallduration += call.Duration;

            }
            return (totalCallduration / (decimal)60) * price;

        }


    }
}