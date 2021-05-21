using System;
using System.Threading;
using System.Threading.Tasks;

namespace ElectronicPetitionProgramLab8
{
    class Program
    {
        public static string textFile = "";
        
        static object locker = new object();
        
        static Mutex mutexObj = new Mutex();
        static void Main(string[] args)
        {
            int switcher = 0;
            Console.WriteLine("Enter 1-4 to choose Task(4.1-4.4)");
            switcher = Convert.ToInt32(Console.ReadLine());
            switch (switcher)
            {
                case 1:
                {
                    Console.WriteLine("Task 4.1:");
                    Thread secondThread = new Thread(new ThreadStart(SecondCount));
                    secondThread.Start(); 
            
                    Thread thirdThread = new Thread(new ThreadStart(ThirdCount));
                    thirdThread.Start();
 
                    long sum = 0;
                    DateTime startTime = DateTime.Now;
                    for (int i = 1; i < 100000001; i++)
                    {
                        Console.WriteLine("Main thread:");
                        sum += i;
                        Console.WriteLine($"Main thread sum: {sum}");
                        Thread.Sleep(400);
                    }
                    DateTime endTime = DateTime.Now;
                    TimeSpan result = endTime.Subtract(startTime);
                    Console.WriteLine($"Main thread result: {sum}");
                    Console.WriteLine("There are {0:N5} milliseconds, as follows:", result.TotalMilliseconds);
            
                    Console.ReadLine();
                    break;
                }
                case 2:
                {
                    Console.WriteLine("Помилка в синхронiзацiї потокiв:");//(50/50)
                    
                    for (int i = 0; i < 5; i++)
                    {
                        Thread secondThread = new Thread(new ThreadStart(SynthronizedAddFileText));
                        secondThread.Name = "secondThread";
                        secondThread.Start();
                    
                        Thread thirdThread = new Thread(new ThreadStart(SynthronizedAddFileText));
                        thirdThread.Name = "thirdThread";
                        thirdThread.Start();
                        
                    }
                    Console.WriteLine(textFile);
                    textFile = "";
                    Console.WriteLine("Синхронiзованi потоки:");
                    for (int i = 0; i < 5; i++)
                    {
                        Thread secondThread = new Thread(new ThreadStart(AddFileText));
                        secondThread.Name = "secondThread";
                        secondThread.Start();
                    
                        Thread thirdThread = new Thread(new ThreadStart(AddFileText));
                        thirdThread.Name = "thirdThread";
                        thirdThread.Start();
                        
                    }
                    Console.WriteLine(textFile);
                    textFile = "";
                    break;
                }
                case 3:
                {
                    Console.WriteLine("Мютекси:");
                    for (int i = 0; i < 2; i++)
                    {
                        Thread myThread = new Thread(MutexAddFileText);
                        myThread.Name = $"Поток {i}";
                        myThread.Start();
                    }
                    Console.WriteLine(textFile);
                    textFile = "";
                    break;
                }
                case 4:
                {
                    
                    break;
                }
            }
            
            
        }
        
        public static void SecondCount()
        {
            long sum = 0;
            DateTime startTime = DateTime.Now;
            for (int i = 1; i < 100000001; i++)
            {
                Console.WriteLine("Second thread:");
                sum += i;
                Console.WriteLine($"Second thread sum: {sum}");
                Thread.Sleep(200);
            }
            DateTime endTime = DateTime.Now;
            TimeSpan result = endTime.Subtract(startTime);
            Console.WriteLine($"Second thread result: {sum}");
            Console.WriteLine("There are {0:N5} milliseconds, as follows:", result.TotalMilliseconds);
        }
        
        public static void ThirdCount()
        {
            long sum = 0;
            DateTime startTime = DateTime.Now;
            for (int i = 1; i < 100000001; i++)
            {
                Console.WriteLine("Third thread:");
                sum += i;
                Console.WriteLine($"Third thread sum: {sum}");
                Thread.Sleep(200);
            }
            DateTime endTime = DateTime.Now;
            TimeSpan result = endTime.Subtract(startTime);
            Console.WriteLine($"Third thread result: {sum}");
            Console.WriteLine("There are {0:N5} milliseconds, as follows:", result.TotalMilliseconds);
            
            Console.WriteLine("Task 4.2:");
        }

        public static void AddFileText()
        {
            textFile += $"Added Text {Thread.CurrentThread.Name} ";
        }
        
        public static void SynthronizedAddFileText()
        {
            lock (locker)
            {
                textFile += $"Added Text {Thread.CurrentThread.Name} ";
            }
        }
        
        public static void MutexAddFileText()
        {
            mutexObj.WaitOne();
            textFile += $"Added Text {Thread.CurrentThread.Name} ";
            Thread.Sleep(100);
            mutexObj.ReleaseMutex();
        }
    }
}