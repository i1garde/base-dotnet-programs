using System;
using ElectronicPetitionProgramLab5;

namespace ElectronicPetitionsProgramLab5
{
    public class Moderator : Client , IModerator
    {
        public void CheckPetition(Petition petition)
        {
            petition.Description += " Approved by moderator.";
        }

        public override void Show()
        {
            Console.WriteLine("Це модератор.");
        }
    }
}