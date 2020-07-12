using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace SpinningDiscs
{
    public abstract class BaseDisc
    {
        public int StorageSpace { get; set; }
        public string Name { get; set; }
        public int RemainingCapacity {get;set;}
        public int CapacityUsed { get; set; }
        public string DiscType { get; set; }
        

        public BaseDisc(string name, string discType, int storageSpace)
        {
            Name = name;
            DiscType = discType;
            StorageSpace = storageSpace;
        }

        public void CheckCapacity(int capacityUsed)
        {
            if (capacityUsed <= StorageSpace)
            {
                RemainingCapacity = StorageSpace - capacityUsed;
                Console.WriteLine("Remaining capacity is " + RemainingCapacity);
            }
            else
            {
                Console.WriteLine("Capacity used can not be bigger than storage space.");
            }
        }

        public string PrintInfo()
        {
            string info = "Disk name: " + Name + "\nMax Capacity: " + StorageSpace + "\nAvailable Space: " + RemainingCapacity;
            return info;
        }

    }
}
