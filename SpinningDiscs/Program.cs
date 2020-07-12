using System;
using System.Collections.Generic;

namespace SpinningDiscs
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO: Declare and initialize a CD and a DVD object.
            List<string> newCDList = new List<string>();
            newCDList.Add("Soon You'll Get Better");
            newCDList.Add("Cornelia Street");
            newCDList.Add("Lover");
            newCDList.Add("Paper Rings");

            
            CD myCd= new CD("Lover", "CD", 700, newCDList);

            DVD myDvd = new DVD("Frozen", "DVD", 8500, 720);

            // TODO: Call each CD and DVD method to verify that they work as expected.
            myCd.SpinDisc();
            myCd.CheckCapacity(500);
            Console.WriteLine(myCd.PrintInfo());
            myCd.ShowContent();

            myDvd.SpinDisc();
            myDvd.CheckCapacity(500);
            Console.WriteLine(myDvd.PrintInfo());
            myDvd.GetQuality();



        }
    }
}
