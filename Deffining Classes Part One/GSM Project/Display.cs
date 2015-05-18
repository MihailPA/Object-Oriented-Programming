using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSM_Project
{
    public class Display
    {
        //fields

        private string numberOfColors;


        //constructors
        public Display(string size)
        {
            this.Size = size;
        }

        public Display(string size, string numberOfColors)
            : this(size)
        {
            this.NumberOfColors = numberOfColors;
        }

        //properties
        public string Size { get; set; }
        public string NumberOfColors
        {
            get
            {
                return this.numberOfColors;
            }

            set
            {
                for (int i = 0; i < value.Length; i++)
                {
                    if (!(char.IsDigit(value[i])) && value[i] != ' ')
                    {
                        throw new ArgumentException("The number of colors could contain only digits.");
                    }
                }
                this.numberOfColors = value;

            }

        }

        //methods
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine("Display size: " + this.Size);
            sb.AppendLine("Display number of colors: " + this.NumberOfColors);
            return sb.ToString();
        }

    }
}
