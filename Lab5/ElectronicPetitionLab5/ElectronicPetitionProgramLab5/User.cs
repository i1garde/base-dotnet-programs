namespace ElectronicPetitionProgramLab5
{
    public abstract class User
    {
        public int Id { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Patronymic { get; set; }

        abstract public void Show();
    }
}