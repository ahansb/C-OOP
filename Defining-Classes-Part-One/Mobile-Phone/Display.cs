namespace MobilePhone
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    //Problem 1. Define class
    //Define a class that holds information about a mobile phone device: model, manufacturer, price, owner, battery characteristics (model, hours idle and hours talk) and display characteristics (size and number of colors).
    //Define 3 separate classes (class GSM holding instances of the classes Battery and Display).
    public class Display
    {
        // field declarations
        private double? size;
        private int? numberColors;


        //    Problem 5. Properties
        //Use properties to encapsulate the data fields inside the GSM, Battery and Display classes.
        //Ensure all fields hold correct data at any given time.

        public double? Size
        {
            get { return size; }
            set
            {
                if (value == null || value > 0)
                {
                    this.size = value;
                }
                else
                {
                    throw new IndexOutOfRangeException("The size of display must be positive or null.");
                }
                
            }
        }

        public int? NumberColors
        {
            get { return numberColors; }
            set
            {
                if (value == null || value > 0)
                {
                    this.numberColors = value;
                }
                else
                {
                    throw new IndexOutOfRangeException("The number of colors of display must be positive or null.");
                }

            }
        }




        //    Problem 2. Constructors
        //Define several constructors for the defined classes that take different sets of arguments (the full information for the class or part of it).
        //Assume that model and manufacturer are mandatory (the others are optional). All unknown data fill with null.
        public Display()
        {
            this.size = null;
            this.numberColors = null;
        }
        public Display(double size):this()
        {
            this.size = size;
        }
        public Display(double size, int numberColors):this(size)
        {
            this.numberColors = numberColors;
        }
    }
}
