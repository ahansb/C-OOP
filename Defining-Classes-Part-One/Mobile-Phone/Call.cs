namespace MobilePhone
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    //Problem 8. Calls
    //Create a class Call to hold a call performed through a GSM.
    //It should contain date, time, dialled phone number and duration (in seconds).

    class Call
    {
        private DateTime? date;
        private string dialedPhone;
        private decimal duration;


        public DateTime? Date
        {
            get 
            { 
                return date; 
            }
            set
            {
                try
                {
                    this.date = value;
                }
                catch (FormatException)
                {
                    
                    throw new FormatException("The date is not in correct format.");
                }
            }
        }
        public string DialedNumbers
        {
            get
            {
                return dialedPhone;
            }
            set
            {
                this.dialedPhone = dialedPhone;
            }
        }
        public decimal Duration
        {
            get
            {
                return duration;
            }
            set
            {
                this.duration = duration;
            }
        }


        //public Call()
        //{
        //    this.date = null;
        //    this.dialedPhone = null;
        //    this.duration = null;
        //}
        public Call(DateTime date, string dialedPhone, decimal duration)
        {
            this.date = date;
            this.dialedPhone = dialedPhone;
            this.duration = duration;
        }

        public override string ToString()
        {
            StringBuilder callInfo = new StringBuilder();
            callInfo.AppendFormat("Date and time of call: {0}\n", this.date);
            callInfo.AppendFormat("Dialed number: {0}\n", this.dialedPhone);
            callInfo.AppendFormat("Duration of call: {0} sec.\n", this.duration);
            
            return callInfo.ToString();
        }
    }
}
