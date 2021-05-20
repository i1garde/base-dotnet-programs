using System;
using System.Data;

namespace ElectronicPetitionsProgram
{
    public class Petition
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreationData { get; set; }
        public int SubscribersAmount { get; set; }
    }
}