using System.Collections.Generic;

namespace ElectronicPetitionsProgram
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Petition> Petitions { get; set; }
    }
}