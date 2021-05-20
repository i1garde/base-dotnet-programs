using ElectronicPetitionsProgramLab5;

namespace ElectronicPetitionProgramLab5
{
    public interface IClient
    {
        public string GetInfo(Petition petition);
        public void CreatePetition(string name, string description);
        public void DeletePetition(Petition petition);
        public void EditPetition(Petition petition, string name, string description);
        public void SubscribePetition(Petition petition);
    }
}