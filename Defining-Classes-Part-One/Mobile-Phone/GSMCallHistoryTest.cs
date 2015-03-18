namespace MobilePhone
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    //Problem 12. Call history test
    //Write a class GSMCallHistoryTest to test the call history functionality of the GSM class.
    //    Create an instance of the GSM class.
    //    Add few calls.
    //    Display the information about the calls.
    //    Assuming that the price per minute is 0.37 calculate and print the total price of the calls in the history.
    //    Remove the longest call from the history and calculate the total price again.
    //    Finally clear the call history and print it.

    class GSMCallHistoryTest
    {
        //static void Main()
        //{
        //    GSM myGsm = new GSM("CAT", "Caterpillar", 450, "I", new Battery("Hitachi", 24, 9), new Display(4, 16000000));
            
        //    for (int i = 0; i < 5; i++)
        //    {

        //        myGsm.AddCalls(new Call(DateTime.Now.AddHours(i), "0888 888 88" + (i + 2).ToString(), (uint)(i * 32)));

        //    }
        //    foreach (var call in myGsm.callHistory)
        //    {
        //        Console.WriteLine(call);
        //    }
        //    Console.WriteLine("Total price of calls is {0:0.00}",myGsm.CalcTotalPrice(0.37m));
            

        //    decimal bestDuration = decimal.MinValue;
        //    decimal currentDuration = 0;
        //    int index = 0;
        //    int searchedIndex = 0;
        //    for (int i = 0; i < myGsm.callHistory.Count; i++)
        //    {
        //        currentDuration = 0;
        //        for (int j = 0; j < myGsm.callHistory.Count; j++)
        //        {
        //            if (myGsm.callHistory[i].Duration > myGsm.callHistory[j].Duration)
        //            {
        //                currentDuration = myGsm.callHistory[i].Duration;
        //                index = i;
        //            }
        //        }
        //        if (currentDuration > bestDuration)
        //        {
        //            bestDuration = currentDuration;
        //            searchedIndex = index;
        //        }
        //    }
        //    myGsm.DeleteCalls(searchedIndex);
        //    Console.WriteLine("Total price of calls without the longest is {0:0.00}", myGsm.CalcTotalPrice(0.37m));
        //    Console.WriteLine(new string('-',50));
        //    myGsm.ClearCalls();
        //    foreach (var call in myGsm.callHistory)
        //    {
        //        Console.WriteLine(call);
        //    }
        //}


    }
}
