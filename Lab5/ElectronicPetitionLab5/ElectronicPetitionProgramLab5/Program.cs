using System;
using ElectronicPetitionsProgramLab5;

namespace ElectronicPetitionProgramLab5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Початок програми!");
            Client client = new Client();
            Moderator moderator = new Moderator();
            Console.WriteLine("");
            client.Show();
            moderator.Show();
            
            Console.WriteLine("Upcast Moderator to Client");
            Client client1 = (Client) moderator;
            client1.Show();
            
            Console.WriteLine("Downcast Client to Moderator");
            Moderator downcastModerator = (Moderator) client1;
            downcastModerator.Show();
        }
    }
}