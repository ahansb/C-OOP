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
    public class Battery
    {
        // field declarations
        private string model;
        private double? hoursIdle;
        private double? hoursTalk;

    //    Problem 3. Enumeration
    //Add an enumeration BatteryType (Li-Ion, NiMH, NiCd, …) and use it as a new field for the batteries.
        public enum BatteryType 
        {LiIon, NiMH, NiCd,LiPoly,}

    //    Problem 5. Properties
    //Use properties to encapsulate the data fields inside the GSM, Battery and Display classes.
    //Ensure all fields hold correct data at any given time.


        public string Model
        {
            get
            {
                return this.model; 
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Enter model");
                }
                else
                {
                    this.model = value;
                }
            }
        }
        
        public double? HoursIdle
        {
            get
            {
                return hoursIdle;
            }
            set
            {
                if (value == null || value > 0)
                {
                    this.hoursIdle = value;
                }
                else
                {
                    throw new IndexOutOfRangeException("The value of hours idle must be positive or null.");
                }
                
            }
        }
        public double? HoursTalk
        {
            get { return hoursTalk; }
            set
            {
                if (value == null || value>0)
                {
                    this.hoursTalk = value;
                }
                else
                {
                    throw new IndexOutOfRangeException("The value of hours talk must be positive or null.");
                }
            }
        }


        //    Problem 2. Constructors
        //Define several constructors for the defined classes that take different sets of arguments (the full information for the class or part of it).
        //Assume that model and manufacturer are mandatory (the others are optional). All unknown data fill with null.
        public Battery(string model)
        {
            this.model = model;
            this.hoursIdle = null;
            this.hoursTalk = null;
        }
        public Battery(string model, double hoursIdle):this(model)
        {
            this.hoursIdle = hoursIdle;
        }
        public Battery(string model, double hoursIdle, double hoursTalk):this(model,hoursIdle)
        {
            this.hoursTalk = hoursTalk;
        }
    
        

    }
}
