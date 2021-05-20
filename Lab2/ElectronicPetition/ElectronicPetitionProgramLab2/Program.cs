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
            Console.WriteLine($"Surname: {client1.Surname}\n" +
                              $"Name: {client1.Name}\n" +
                              $"Patronymic: {client1.Patronymic}\n" +
                              $"Date Of Birth: {client1.DateOfBirth}\n" +
                              $"Phone Number: {client1.PhoneNumber}\n" +
                              $"Email: {client1.Email}\n");
            Console.WriteLine("Списком аргументiв:");

            string surname = "ArgumentSurname";
            string name = "ArgumentName";
            string patronymic = "ArgumentPatronymic";
            DateTime dateTime = Convert.ToDateTime("12.04.1999");
            string phoneNumber = "+890123456";
            string email = "argument@mail.com";

            Client client2 = new Client(surname, name, patronymic, dateTime, phoneNumber, email);
            Console.WriteLine($"Surname: {client2.Surname}\n" +
                              $"Name: {client2.Name}\n" +
                              $"Patronymic: {client2.Patronymic}\n" +
                              $"Date Of Birth: {client2.DateOfBirth}\n" +
                              $"Phone Number: {client2.PhoneNumber}\n" +
                              $"Email: {client2.Email}\n");
            
            Console.WriteLine("Конструктором копiювання:");
            Console.WriteLine("client3 копiює поля client1:");
            Client client3 = new Client(client1);
            Console.WriteLine($"Surname: {client3.Surname}\n" +
                              $"Name: {client3.Name}\n" +
                              $"Patronymic: {client3.Patronymic}\n" +
                              $"Date Of Birth: {client3.DateOfBirth}\n" +
                              $"Phone Number: {client3.PhoneNumber}\n" +
                              $"Email: {client3.Email}\n");
        }
    }
}