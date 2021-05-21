using System;
using System.Data;
using System.Threading.Channels;
using ElectronicPetitionProgramLab7;

namespace ElectronicPetitionsProgramLab5
{
    public class Petition
    {
        private int subscribersAmount;
        
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreationData { get; set; }

        public int SubscribersAmount
        {
            get
            {
                return this.subscribersAmount;
            }
            set
            {
                if (value < 0)
                    throw new Program.NegativeException();
                if (value > 1000000)
                    throw new ArgumentOutOfRangeException("subscribersAmount","All subscribers must not be more than 1000000.");
                else
                    this.subscribersAmount = value;
            }
        }
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

        public void Show()
        {
            Console.WriteLine(this.Name);
        }

        public int GetSubscribers()
        {
            return this.SubscribersAmount;
        }
        
        public int AddAndGetSubscribers(int a)
        {
            return this.SubscribersAmount + a;
        }
    }
}