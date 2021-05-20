using System;
using System.Collections.Generic;

namespace ElectronicPetitionsProgramLab2
{
    public class Client
    {
        private int id;
        private string surname;
        private string name;
        private string patronymic;
        private DateTime dateOfBirth;
        private string phoneNumber;
        private string email;
        public int Id
        {
            get
            {
                return this.id;
            }
            set
            {
                this.id = value;
            }
        }

        public string Surname
        {
            get
            {
                return this.surname;
            }
            set
            {
                this.surname = value;
            }
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }

        public string Patronymic
        {
            get
            {
                return this.patronymic;
            }
            set
            {
                this.patronymic = value;
            }
        }

        public DateTime DateOfBirth
        {
            get
            {
                return this.dateOfBirth;
            }
            set
            {
                this.dateOfBirth = value;
            }
        }

        public string PhoneNumber
        {
            get
            {
                return this.phoneNumber;
            }
            set
            {
                this.phoneNumber = value;
            }
        }

        public string Email
        {
            get
            {
                return this.email;
            }
            set
            {
                this.email = value;
            }
        }

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

        public Client(Client client)
        {
            Surname = client.Surname;
            Name = client.Name;
            Patronymic = client.Patronymic;
            DateOfBirth = client.DateOfBirth;
            PhoneNumber = client.PhoneNumber;
            Email = client.Email;
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