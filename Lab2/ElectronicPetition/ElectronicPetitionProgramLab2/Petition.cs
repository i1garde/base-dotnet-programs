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
            Petition firstPetition = new Petition()
            {
                Category = new Category() {Name = "political"}, Name = "Department", Description = "axaxa",
                CreationData = DateTime.Now
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
    }
}