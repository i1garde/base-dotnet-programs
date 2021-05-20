using System;

namespace ElectronicPetitionsProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program starts!");

            Petition petition1 = new Petition()
            {
                Id = 1,
                Name = "First Petition",
                Description = "Description 1",
                CreationData = DateTime.Now,
                SubscribersAmount = 0
            };
            Petition petition2 = new Petition()
            {
                Id = 2,
                Name = "Second Petition",
                Description = "Description 2",
                CreationData = DateTime.Now,
                SubscribersAmount = 0
            };
            Petition petition3 = new Petition()
            {
                Id = 3,
                Name = "Third Petition",
                Description = "Description 3",
                CreationData = DateTime.Now,
                SubscribersAmount = 0
            };
        }
    }
}