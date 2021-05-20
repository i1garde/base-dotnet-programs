using System;
using System.Data;

namespace ElectronicPetitionsProgramLab2
{
    public class Petition
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreationData { get; set; }
        public int SubscribersAmount { get; set; }
        public Category Category { get; set; }
        
        public Petition()
        {
            Name = "Department";
            Description = "axaxa";
            CreationData = DateTime.Now;
            Category = new Category()
            {
                Name = "Politic"
            };
        }

        public Petition(Category category, string name, string description, DateTime creationData)
        {
            Category = category;
            Name = name;
            Description = description;
            CreationData = creationData;
        }

        public Petition(Petition petition)
        {
            Category = petition.Category;
            Name = petition.Name;
            Description = petition.Description;
            CreationData = petition.CreationData;
        }

        public static Petition operator ++(Petition petition)
        {
            return new Petition{SubscribersAmount = petition.SubscribersAmount + 1};
        }

        public static Petition operator --(Petition petition)
        {
            return new Petition{SubscribersAmount = petition.SubscribersAmount - 1};
        }

        public static Petition operator +(Petition petitionOne, Petition petitionTwo)
        {
            return new Petition{SubscribersAmount = petitionOne.SubscribersAmount + petitionTwo.SubscribersAmount};
        }

        public static Petition operator -(Petition petitionOne, Petition petitionTwo)
        {
            return new Petition{SubscribersAmount = petitionOne.SubscribersAmount - petitionTwo.SubscribersAmount};
        }

        public static bool operator >(Petition petitionOne, Petition petitionTwo)
        {
            return petitionOne.SubscribersAmount > petitionTwo.SubscribersAmount;
        }
        
        public static bool operator <(Petition petitionOne, Petition petitionTwo)
        {
            return petitionOne.SubscribersAmount < petitionTwo.SubscribersAmount;
        }

        public static bool operator true(Petition petition)
        {
            return petition.SubscribersAmount < 10;
        }
        
        public static bool operator false(Petition petition)
        {
            return petition.SubscribersAmount >= 10;
        }
    }
}