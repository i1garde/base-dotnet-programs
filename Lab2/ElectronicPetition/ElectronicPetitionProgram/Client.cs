using System;
using System.Collections.Generic;

namespace ElectronicPetitionsProgramLab2
{
    public class Client
    {
        public int Id { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Patronymic { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public List<Petition> ClientPetitions { get; set; }

        public Client()
        {
            Surname = "Default surname";
            Name = "Default name";
            Patronymic = "Default patronymic";
            DateOfBirth = Convert.ToDateTime("01.01.2000");
            PhoneNumber = "+123456789";
            Email = "default@email.com";
        }

        public Client(string surname, string name, string patronymic,
            DateTime dateOfBirth, string phoneNumber, string email)
        {
            Surname = surname;
            Name = name;
            Patronymic = patronymic;
            DateOfBirth = dateOfBirth;
            PhoneNumber = phoneNumber;
            Email = email;
        }

        public string GetInfo(Petition petition)
        {
            return $"Name: {petition.Name}\nDescription: {petition.Description}";
        }
        public void CreatePetition(string name, string description)
        {
            ClientPetitions.Add(new Petition(){Name = name, Description = description});
        }

        public void DeletePetition(Petition petition)
        {
            ClientPetitions.Remove(petition);
        }

        public void EditPetition(Petition petition, string name, string description)
        {
            petition.Name = name;
            petition.Description = description;
        }

        public void SubscribePetition(Petition petition)
        {
            petition.SubscribersAmount += 1;
        }
    }
}