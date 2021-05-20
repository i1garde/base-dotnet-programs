namespace ElectronicPetitionsProgram
{
    public class Moderator
    {
        public int Id { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Patronymic { get; set; }

        public void CheckPetition(Petition petition)
        {
            petition.Description += " Approved by moderator.";
        }
    }
}