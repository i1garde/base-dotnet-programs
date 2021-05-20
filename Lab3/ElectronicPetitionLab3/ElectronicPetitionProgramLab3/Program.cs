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
            
        }
    }
}