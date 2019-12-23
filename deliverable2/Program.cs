using System;

namespace deliverable2
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string upper = input.ToUpper();
            string letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string message = "";
            int checksum = 0;

            foreach (char myChar in upper)
            {
                message += letters.IndexOf(myChar) + 1 + "-";
                checksum += System.Convert.ToInt32(myChar);
            }

            Console.WriteLine(message);
            Console.WriteLine("Message checksum is " + checksum);
        }
    }
}
