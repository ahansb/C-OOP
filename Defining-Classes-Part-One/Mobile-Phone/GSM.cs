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

    class GSM
    {

        public const double pricePMinute = 0.37;

        private string model;
        private string manufacturer;
        private double? price;
        private string owner;
        //Problem 9:
        public  List<Call> callHistory = new List<Call>();

    //    Problem 6. Static field
    //Add a static field and a property IPhone4S in the GSM class to hold the information about iPhone 4S.
        public static GSM IPhone4S = new GSM("IPhone 4S", "Apple", 845.50, "John Doe", new Battery("Apple", 12, 6), new Display(4, 16000000));


        // istance
        Battery battery = new Battery("Apple");

        Display display = new Display();

    //    Problem 2. Constructors
    //Define several constructors for the defined classes that take different sets of arguments (the full information for the class or part of it).
    //Assume that model and manufacturer are mandatory (the others are optional). All unknown data fill with null.

        public GSM(string model, string manufacturer)
        {
            this.model = model;
            this.manufacturer = manufacturer;
            this.price = null;
            this.owner = null;
        }
        public GSM(string model, string manufacturer, double price) 
            : this(model,manufacturer)
        {
            this.price = price;
        }
        public GSM(string model, string manufacturer, double price, string owner)
            : this(model,manufacturer,price)
        {
            this.owner = owner;
        }
         public GSM(string model, string manufacturer, double price, string owner, Battery battery)
            : this( model,  manufacturer,  price,  owner)
         {
             this.battery = battery;
         }
        public GSM(string model, string manufacturer, double price, string owner, Battery battery, Display display)
            :this( model,  manufacturer,  price,  owner, battery)
         {
             this.display = display;
         }
        public GSM(string model, string manufacturer, double price, string owner, Battery battery, Display display, List<Call> callHistory)
            : this(model, manufacturer, price, owner, battery, display)
        {
            this.callHistory = callHistory;
        }

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
        public string Manufacturer
        {
            get
            {
                return this.manufacturer;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Enter manufacturer");
                }
                else
                {
                    this.manufacturer = value;
                }
            }
        }
        public double? Price
        {
            get { return price; }
            set
            {
                if (value == null || value >= 0)
                {
                    this.price = value;
                }
                else
                {
                    throw new IndexOutOfRangeException("The price must be positive or null.");
                }

            }
        }
        public string Owner { get; set; }

    //    Problem 9. Call history
    //Add a property CallHistory in the GSM class to hold a list of the performed calls.
    //Try to use the system class List<Call>.

        public List<Call> CallHistory { get; set; }
        
    //    Problem 4. ToString
    //Add a method in the GSM class for displaying all information about it.
    //Try to override ToString().

        public override string ToString()
        {
            StringBuilder nfo = new StringBuilder();
            nfo.AppendFormat("Mobile phone model: {0}\n", this.model);
            nfo.AppendFormat("Mobile phone manufacturer: {0}\n", this.manufacturer);
            nfo.AppendFormat("Mobile phone price: {0}\n", this.price);
            nfo.AppendFormat("Mobile phone owner: {0}\n", this.owner);
            nfo.AppendFormat("Mobile phone battery model: {0}\n", battery.Model);
            nfo.AppendFormat("Mobile phone hours idle: {0}\n", battery.HoursIdle);
            nfo.AppendFormat("Mobile phone hours talk: {0}\n", battery.HoursTalk);
            nfo.AppendFormat("Mobile phone display size: {0}\n", display.Size);
            nfo.AppendFormat("Mobile phone display colors: {0}\n", display.NumberColors);
            return nfo.ToString();
        }
        
        
    //    Problem 10. Add/Delete calls
    //Add methods in the GSM class for adding and deleting calls from the calls history.
    //Add a method to clear the call history.

        public void AddCalls(Call curCall)
        {
           this.callHistory.Add(curCall);
        }
        public void DeleteCalls(int idxCall)
        {
            this.callHistory.RemoveAt(idxCall);
        }
        public void ClearCalls()
        {
            this.callHistory.Clear();
        }

    //    Problem 11. Call price
    //Add a method that calculates the total price of the calls in the call history.
    //Assume the price per minute is fixed and is provided as a parameter.
        public decimal CalcTotalPrice(decimal pricePMinute)
        {
            decimal totalPrice = 0;
            decimal totMin = 0;
            foreach (var call in callHistory)
            {
                totMin += call.Duration / 60;
            }

            return totalPrice = totMin*pricePMinute;
        }
    }
}
