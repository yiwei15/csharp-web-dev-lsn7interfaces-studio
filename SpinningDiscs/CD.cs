using System;
using System.Collections.Generic;

namespace SpinningDiscs
{
    public class CD : BaseDisc,IOpticalDisc
    {
        // TODO: Implement your custom interface.

        // TODO: Determine which fields, methods, and constructors can be extended from the base class and which ones
        //  need to be declared separately. 
        public List<string> Content { get; set; }

        public CD(string name, string discType, int storageSpace, List<string> content):base(name, discType, storageSpace)
        {
            Content = content;
        }
        public void SpinDisc()
        {
            Console.WriteLine("A CD spins at rate of 200 - 500 rpm");
        }

        public void ReadData()
        {
            Console.WriteLine("Data reading....");
        }

        public void ShowContent()
        {
            foreach (string str in Content)
            {
                Console.WriteLine(str);
            }
        }
    }
}
