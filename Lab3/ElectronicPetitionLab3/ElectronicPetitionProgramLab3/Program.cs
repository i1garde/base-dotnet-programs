using System;
using ElectronicPetitionsProgramLab2;

namespace ElectronicPetitionProgramLab3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Початок програми!");
            string surname;
            string name;
            string patronymic;
            DateTime dateOfBirth;
            string phoneNumber;
            string email;
            Console.Write("Enter surname: ");
            surname = Console.ReadLine();
            Console.Write("Enter name: ");
            name = Console.ReadLine();
            Console.Write("Enter patronymic: ");
            patronymic = Console.ReadLine();
            Console.Write("Enter date of birth(dd.mm.yyyy): ");
            dateOfBirth = Convert.ToDateTime(Console.ReadLine());
            Console.Write("Enter phone number: ");
            phoneNumber = Console.ReadLine();
            Console.Write("Enter email: ");
            email = Console.ReadLine();

            Client client = new Client(surname, name, patronymic, dateOfBirth, phoneNumber, email);
            Console.WriteLine("Client data:");
            Console.WriteLine($"Surname: {client.Surname}\n" +
                              $"Name: {client.Name}\n" +
                              $"Patronymic: {client.Patronymic}\n" +
                              $"Date Of Birth: {client.DateOfBirth}\n" +
                              $"Phone Number: {client.PhoneNumber}\n" +
                              $"Email: {client.Email}\n");
            Console.ReadLine();
        }
    }
}