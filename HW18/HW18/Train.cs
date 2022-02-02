using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    struct Train
    {
        public string DestinationName { get; set; }
        public int TrainNumber { get; set; }
        public DateTime Time { get; set; }
        public Train(string desName, int number, DateTime dateTime)
        {
            DestinationName = desName;
            TrainNumber = number;
            Time = dateTime;
        }
        public void ShowTrainInfo()
        {
            Console.WriteLine("Destination name: {0}\nTrain number: {1}\nTime: {2}", 
                DestinationName, TrainNumber, Time);
        }
    }
}