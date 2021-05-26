using System;
using System.Threading;
using System.Threading.Tasks;

namespace ElectronicPetitionProgramLab8
{
    class Program
    {
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
                    Console.WriteLine("1 - error, 2 - synced");
                    string num = Console.ReadLine();
                    int a = Convert.ToInt32(num);
                    switch (a)
                    {
                        case 1:
                        {
                            //
                            Console.WriteLine("З помилкою");
                            string path = @"D:\Prog Proj\C#\base-dotnet-programs\Lab8\ElectronicPetitionLab8\ElectronicPetitionProgramLab8\Resources\text.txt";
                            FileReader instance = new FileReader(path);

                            ThreadStart Thread1 = new ThreadStart(instance.WriteFile);
                            Thread thread1 = new Thread(Thread1) {Name = "1"};
                            thread1.Start();

                            ThreadStart Thread2 = new ThreadStart(instance.WriteFile);
                            Thread thread2 = new Thread(Thread2) {Name = "2"};
                            thread2.Start();

                            break;
                        }
                        case 2:
                        {
                            //Синхр
                            Console.WriteLine("Синхронізуйте  потоки, щоб цієї помилки більше не було.");
                            string path2 = @"D:\Prog Proj\C#\base-dotnet-programs\Lab8\ElectronicPetitionLab8\ElectronicPetitionProgramLab8\Resources\synctext.txt";
                            FileReader instance2 = new FileReader(path2);

                            ThreadStart Thread3 = new ThreadStart(instance2.WriteFileSync);
                            Thread thread3 = new Thread(Thread3) {Name = "1"};
                            thread3.Start();

                            ThreadStart Thread4 = new ThreadStart(instance2.WriteFileSync);
                            Thread thread4 = new Thread(Thread4) {Name = "2"};
                            thread4.Start();

                            Console.WriteLine("Press enter");
                            Console.ReadLine();
                            break;
                        }
                    }
                    
                    
                    break;
                }
                case 3:
                {
                    string path = @"D:\Prog Proj\C#\base-dotnet-programs\Lab8\ElectronicPetitionLab8\ElectronicPetitionProgramLab8\Resources\mutextext.txt";
                    FileReader instance = new FileReader(path);

                    ThreadStart Thread1 = new ThreadStart(instance.WriteFileMutex);
                    Thread thread1 = new Thread(Thread1) {Name = "1"};
                    thread1.Start();

                    ThreadStart Thread2 = new ThreadStart(instance.WriteFileMutex);
                    Thread thread2 = new Thread(Thread2) {Name = "2"};
                    thread2.Start();

                    Console.WriteLine("Press enter");
                    Console.ReadLine();
                    break;
                }
                case 4:
                {
                    int n = 5;
                    string path = @"D:\Prog Proj\C#\base-dotnet-programs\Lab8\ElectronicPetitionLab8\ElectronicPetitionProgramLab8\Resources\semaphoretext.txt";
                    FileReader instance = new FileReader(path);
                    
                    for (int i = 0; i < n; i++)
                    {
                        Thread thread1 = new Thread(instance.WriteFileSemaphore) {Name = (i + 1) + ""};
                        thread1.Start();
                    }
                    
                    Console.WriteLine("Press enter");
                    Console.ReadLine();
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
        
        
    }
}