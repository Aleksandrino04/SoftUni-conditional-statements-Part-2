using System;

namespace _07._Shopping
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int videocardQuantity = int.Parse(Console.ReadLine());
            int processorQuantity = int.Parse(Console.ReadLine());
            int ramQuantity = int.Parse(Console.ReadLine());
            
            double videocardPrice = videocardQuantity * 250;
            double processorPrice = processorQuantity *(videocardPrice * 0.35);
            double ramPrice =  ramQuantity *(videocardPrice * 0.10);
            double totalPrice = videocardPrice + processorPrice + ramPrice;
            
            if (videocardQuantity> processorQuantity)
            {
                totalPrice = totalPrice - (totalPrice * 0.15);
            }
            double difference = budget - totalPrice;
            
            if(difference>=0)
            {
                Console.WriteLine($"You have {difference:F2} leva left!");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {Math.Abs(difference):F2} leva more!");
                


            }

        }
    }
}
