using System;
using System.IO;
using System.Threading;

namespace ElectronicPetitionProgramLab8
{
    public class FileReader
    {
        private readonly string _path;
        static readonly object obj = new object();
        static Mutex mutexObj = new Mutex();
        static Semaphore sem = new Semaphore(1, 1);
        public FileReader(string path)
        {
            _path = path;
        }
        
        public void WriteFile()
        {
            int n = 10;
            Console.WriteLine(Thread.CurrentThread.Name);
            try
            {
                StreamWriter sw = new StreamWriter(_path, append: true);
                for (int i = 0; i < n; i++)
                {
                    sw.WriteLine($"Thread Name: {Thread.CurrentThread.Name}, Line {i}");
                } 
            }
            catch (System.IO.IOException e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
        }
        public void WriteFileSync()
        {
            lock (obj)
            {
                int n = 10;
                Console.WriteLine(Thread.CurrentThread.Name);
                using (StreamWriter sw = new StreamWriter(_path, append: true))
                {
                    for (int i = 0; i < n; i++)
                        sw.WriteLine($"Thread Name: {Thread.CurrentThread.Name}, Line {i}");
                    
                    Console.WriteLine($"Wrote, Thread: {Thread.CurrentThread.Name}.");
                }

                using (StreamReader sr = new StreamReader(_path))
                {
                    Console.WriteLine(sr.ReadToEnd());

                    Console.WriteLine($"Read, Thread: {Thread.CurrentThread.Name}.");
                }
                Console.WriteLine(Thread.CurrentThread.Name);
            }
        }
        public void WriteFileMutex()
        {
            mutexObj.WaitOne();
            {
                int n = 10;
                using (StreamWriter sw = new StreamWriter(_path, append: true))
                {
                    for (int i = 0; i < n; i++)
                        sw.WriteLine($"Thread Name: {Thread.CurrentThread.Name}, Line {i}");

                    Console.WriteLine($"Wrote, Thread: {Thread.CurrentThread.Name}.");
                }
                using (StreamReader sr = new StreamReader(_path))
                {
                    Console.WriteLine(sr.ReadToEnd());
                    Console.WriteLine($"Read, Thread: {Thread.CurrentThread.Name}.");
                }
            }
            mutexObj.ReleaseMutex();
        }
        
        public void WriteFileSemaphore()
        {
            sem.WaitOne();
            {
                int n = 10;
                using (StreamWriter sw = new StreamWriter(_path))
                {
                    for (int i = 0; i < n; i++)
                        sw.WriteLine($"Thread Name: {Thread.CurrentThread.Name}, Line {i}");

                    Console.WriteLine($"");
                }

                using (StreamReader sr = new StreamReader(_path))
                {
                    Console.WriteLine(sr.ReadToEnd());
                    Console.WriteLine($"Read, Thread: {Thread.CurrentThread.Name}.");
                }
            }
            sem.Release();
        }
        public void ReadFile(object o)
        {
            using (StreamReader sr = new StreamReader(_path))
            {
                Console.WriteLine(sr.ReadToEnd());
            }
        }
    }
}