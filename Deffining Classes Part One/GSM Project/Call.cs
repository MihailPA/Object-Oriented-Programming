using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSM_Project
{
    public class Call
    {
        const string TimeFormat = "{0:g}";
        const string DateFormat = "dd/MM/yyy";



        //date
        private DateTime date;

        //time

        private string time;

        //dialed number

        private string numberDialed;

        //duration (in seconds)

        private int durataion;


        //constructor

        public Call(string date, string numberDialed, int duration)
        {
            this.Date = date;
            this.NumberDialed = numberDialed;
            this.Duration = duration;
        }



        //properties


        public string Date
        {
            get
            {
                return date.ToString(DateFormat);
            }
            private set
            {
                if (DateTime.TryParse(value, out this.date))
                {
                    this.time = String.Format(TimeFormat, this.date.TimeOfDay.ToString());
                    this.date = date.Date;
                }
                else
                {
                    throw new ArgumentException();
                }
            }

        }

        public string Time
        {
            get
            {
                return this.time;
            }

        }

        public string NumberDialed
        {
            get
            {
                return this.numberDialed;
            }
            set
            {

                for (int i = 0; i < value.Length; i++)
                {

                    if (!(char.IsDigit(value, i)) && value[i] != '+')
                    {
                        throw new ArgumentException("The number can only contain digits and the symbol +.");
                    }
                }

                this.numberDialed = value;

            }
        }

        public int Duration
        {
            get
            {
                return this.durataion;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("The duration must be a positive integer above 0.");
                }
                else
                {
                    this.durataion = value;
                }

            }

        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine("Date of call: " + this.Date);
            sb.AppendLine("Time of call: " + this.Time);
            sb.AppendLine("Number dialed: " + this.NumberDialed);
            sb.AppendLine("Call duratuin: " + this.Duration);

            return sb.ToString();
        }
    }
}
