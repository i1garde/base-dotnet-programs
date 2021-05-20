using System;

namespace ElectronicPetitionsProgram
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

        public string GetInfo(Petition petition)
        {
            return null;
        }
        public void CreatePetition()
        {
            
        }

        public void DeletePetition(Petition petition)
        {
            
        }

        public void EditPetition(Petition petition)
        {
            
        }

        public void SubscribePetition(Petition petition)
        {
            
        }
    }
}