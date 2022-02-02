using System;
using System.Linq;
namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Train[] trainArr = new Train[3];
            for (int i = 0; i < trainArr.Length; i++)
            {
                trainArr[i].DestinationName = Console.ReadLine();
                trainArr[i].TrainNumber = Convert.ToInt32(Console.ReadLine());
                trainArr[i].Time = Convert.ToDateTime(Console.ReadLine());
            }
            trainArr = trainArr.OrderBy(i => i.TrainNumber).ToArray();
            Console.WriteLine("Input train number");
            int num = Convert.ToInt32(Console.ReadLine());
            Train train = trainArr.Where(i => i.TrainNumber == num).FirstOrDefault();
            if (trainArr.Contains(train))
            {
                train.ShowTrainInfo();
            }
            else
            {
                Console.WriteLine("This with number {0} doen`t exist", num);
            }
            Console.ReadKey();
        }
    }
}