using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSM_Project
{
    public class Battery
    {

        //fields
        private string batteryModel;
        private double? hoursIdle;
        private double? hoursTalk;

        //constructors
        public Battery(string batteryModel, BatteryTypes batteryType)
        {
            this.BatteryModel = batteryModel;
            this.BatteryType = batteryType;
        }

        public Battery(string batteryModel, BatteryTypes batteryType, double? hoursIdle, double? hoursTalk)
            : this(batteryModel, batteryType)
        {
            this.HoursIdle = hoursIdle;
            this.HoursTalk = hoursTalk;
        }

        //properties
        public string BatteryModel
        {
            get
            {
                return this.batteryModel;
            }
            set
            {
                this.batteryModel = value;

            }
        }

        public double? HoursIdle
        {
            get
            {
                return this.hoursIdle;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Iddle hours must be a positive number.");
                }
                else
                {
                    this.hoursIdle = value;
                }
            }

        }

        public double? HoursTalk
        {
            get
            {
                return this.hoursTalk;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Talk hours must be a positive number.");
                }
                else
                {
                    this.hoursTalk = value;
                }
            }
        }

        public BatteryTypes BatteryType { get; set; }

        //enumerators
        public enum BatteryTypes
        {
            Unknown = 0,
            LiIon = 1,
            NiMh = 2,
            NiCd = 3
        }

        //methods

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine("Battery model: " + this.BatteryModel);
            sb.AppendLine("Battery type: " + this.BatteryType);
            sb.AppendLine("Baterry hours iddle: " + this.HoursIdle);
            sb.AppendLine("Baterry hours talk: " + this.HoursTalk);

            return sb.ToString();
        }


    }
}
