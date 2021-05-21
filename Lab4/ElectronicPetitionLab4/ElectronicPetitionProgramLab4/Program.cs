using System;
using ElectronicPetitionsProgramLab2;

namespace ElectronicPetitionProgramLab4
{
    class Program
    {
        static void Main(string[] args)
        {
            Petition firstPetition = new Petition()
            {
                Category = new Category(){Name = "Animals"},
                CreationData = DateTime.Now,
                Description = "just testing this stuff",
                Name = "Animal killing",
                SubscribersAmount = 5
            };

            Petition secondPetition = new Petition()
            {
                Category = new Category() {Name = "Human"},
                CreationData = DateTime.Now,
                Description = "just testing what?",
                Name = "Human overlevelling",
                SubscribersAmount = 11
            };

            firstPetition++;
            Console.WriteLine("Первая петиция после инкрементации стала : " + firstPetition.SubscribersAmount);
            Console.WriteLine();
            secondPetition--;
            Console.WriteLine("Вторая петиция после декрементации стала : " + secondPetition.SubscribersAmount);
            Console.WriteLine();
            Petition addingPetitions = secondPetition + firstPetition;
            Console.WriteLine("Сумма второй и первой петиции : " + addingPetitions.SubscribersAmount);
            Console.WriteLine();
            Petition subtractPetitions = secondPetition - firstPetition;
            Console.WriteLine("Разница второй и первой петиции : " + subtractPetitions.SubscribersAmount);
            Console.WriteLine();
            if (firstPetition)
            {
                Console.WriteLine("Это правильно.");
            }
            else
            {
                Console.WriteLine("Это неправильно.");
            }
            Console.WriteLine();
            if (secondPetition)
            {
                Console.WriteLine("Это правильно.");
            }
            
            else
            {
                Console.WriteLine("Это неправильно.");
            }
            Console.WriteLine();
            if (firstPetition > secondPetition)
            {
                Console.WriteLine("Первая петиция > вторая петиция");
            }
            else
            {
                Console.WriteLine("Вторая петиция > первая петиция");
            }
            Console.WriteLine();
            if (firstPetition < secondPetition)
            {
                Console.WriteLine("Вторая петиция > первая петиция");
            }
            else
            {
                Console.WriteLine("Первая петиция > вторая петиция");
            }
            Console.ReadLine();
        }
    }
}