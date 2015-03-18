namespace MobilePhone
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    //Problem 7. GSM test
    //Write a class GSMTest to test the GSM class:
    //    Create an array of few instances of the GSM class.
    //    Display the information about the GSMs in the array.
    //    Display the information about the static property IPhone4S.

    class GSMTest
    {


        static void Main()
        {
            int arrayLenght = 3;
            GSM[] telephones = new GSM[arrayLenght];
            for (int i = 0; i < telephones.Length; i++)
            {
                telephones[i] = new GSM("GSM" + (i + 1).ToString(), "Manuf" + (i + 1).ToString(), (i + 1), "OWN" + (i + 1).ToString(), new Battery("batery" + (i + 1).ToString(), 20 + i, 10 + i), new Display(i + 2, 16000000));
            }
            foreach (var gsm in telephones)
            {
                Console.WriteLine(gsm);
            }
            Console.WriteLine(new string('-',50));
            Console.WriteLine(GSM.IPhone4S);
        }
    }
}
