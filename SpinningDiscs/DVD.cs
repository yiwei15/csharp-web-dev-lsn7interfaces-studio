using System;
namespace SpinningDiscs
{
    public class DVD : BaseDisc, IOpticalDisc
    {
        // TODO: Implement your custom interface.

        // TODO: Determine which fields, methods, and constructors can be extended from the base class and which ones
        //  need to be declared separately.

        public int Resolution { get; set; }
        public DVD(string name, string discType, int storageSpace, int resolution): base(name, discType, storageSpace)
        {
            Resolution = resolution;
        }
        public void SpinDisc()
        {
            Console.WriteLine("A CD spins at rate of 570 - 1600 rpm");
        }

        public void ReadData()
        {
            Console.WriteLine("Data reading....");
        }

        public void GetQuality()
        {
            Console.WriteLine("Video quality is " + Resolution + "p.");
        }
    }
}
