using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone
{
   public class Display
    {
        private double size;
        private int numberOfColors;

        public Display(double size, int numberOfColors)
        {
            this.Size = size;
            this.NumberOfColors = numberOfColors;
        }
        
        public double Size
        {
            get
            {
                return this.size;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Display size should be biiger than zero");
                }
                this.size = value;
            }
        }
        public int NumberOfColors
        {
            get
            {
                return this.numberOfColors;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Display color count cannot be negative number");
                }
                this.numberOfColors = value;
            }
        }

    }
}
