using System;
using ElectronicPetitionsProgramLab5;

namespace ElectronicPetitionProgramLab7
{
    class Program
    {
        public class OwnException : Exception
        {
            public void Message()
            {
                Console.WriteLine("OwnException");
            }
        }
        
        public class NegativeException : Exception
        {
            public void Check()
            {
                Console.WriteLine("Negative amount of subscribers!!!");
            }
        }
        
        static int DivideByTwo(int num)
        {
            // If num is an odd number, throw an ArgumentException.
            if ((num & 1) == 1)
                throw new ArgumentException(String.Format("{0} is not an even number", num),
                    "num");

            // num is even, return half of its value.
            return num / 2;
        }
        
        static void Main(string[] args)
        {
            Console.WriteLine("Program starts!");
            Console.WriteLine("OwnException check:");
            try
            {
                throw new OwnException();
            }
            catch (OwnException e)
            {
                e.Message();
            }
            Console.WriteLine("Authorization NegativeException check:");
            try
            {
                Petition petition = new Petition()
                {
                    SubscribersAmount = -10
                };
            }
            catch (NegativeException e)
            {
                e.Check();
            }
            Console.WriteLine("InvalidCastException check:");
            Client client = new Client();
            try
            {
                Moderator moderator = (Moderator) client;
            }
            catch (InvalidCastException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine("ArgumentException check:");
            
            int[] numbers = { 12, 21 };
            foreach (var number in numbers) {
                try {
                    Console.WriteLine("{0} divided by 2 is {1}", number, DivideByTwo(number));
                }
                catch (ArgumentException e) {
                    Console.WriteLine("{0}: {1}", e.GetType().Name, e.Message);
                }
                Console.WriteLine();
            }
            
            Console.WriteLine("NullReferenceException check:");

            Petition nullPetition = null;
            try
            {
                if (nullPetition == null)
                {
                    throw new NullReferenceException();
                }
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine(e.Message);
            }
            
            Console.WriteLine("ArgumentOutOfRangeException check:");
            try
            {
                Petition argPetition = new Petition()
                {
                    SubscribersAmount = 1000020
                };
            }
            catch (ArgumentOutOfRangeException outOfRange)
            {
                Console.WriteLine("Error: {0}", outOfRange.Message);
            }
            
            Console.WriteLine("IndexOutOfRangeException check:");
            int[] array = new int[10];
            try
            {
                Console.WriteLine($"{array[20]}");
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
            
            Console.WriteLine("DivideByZeroException check:");
            int first = 21;
            int second = 0;
            try
            {
                int result = first / second;
            }
            catch (DivideByZeroException e) when (first==0 || second == 0)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}