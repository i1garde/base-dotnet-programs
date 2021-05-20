using System;
using System.Threading.Channels;
using ElectronicPetitionsProgramLab2;

namespace ElectronicPetitionProgramLab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Початок програми!");
            Console.WriteLine("Створення об'єктiв класу Клiєнт за допомогою конструкторiв:");
            Console.WriteLine("За замовчуванням:");
            Client client1 = new Client();
            Console.WriteLine($"Surame: {client1.Surname}\n" +
                              $"Name: {client1.Name}\n" +
                              $"Patronymic: {client1.Patronymic}\n" +
                              $"Date Of Birth: {client1.DateOfBirth}\n" +
                              $"Phone Number: {client1.PhoneNumber}\n" +
                              $"Email: {client1.Email}\n");
        }
    }
}