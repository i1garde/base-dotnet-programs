using System;
using System.Threading.Channels;
using ElectronicPetitionsProgramLab5;

namespace ElectronicPetitionProgramLab6
{
    class Program
    {
        public delegate void MyDelegate1();

        public delegate int MyDelegate2();

        public delegate int MyDelegate3(int a);

        public delegate string ShowNameDelegate(Petition petition);

        public event Action<Petition> PetitionAdded;

        static void Main(string[] args)
        {
            Console.WriteLine("Початок програми!");
            //
            Console.WriteLine("Створення класу");
            Petition petition = new Petition();
            //
            Console.WriteLine("Делегат для виведення iменi");
            MyDelegate1 myDel = petition.Show;
            myDel?.Invoke();
            //
            //
            Console.WriteLine("Делегат для виведення кiлькостi пiдписникiв");
            MyDelegate2 myDel2 = petition.GetSubscribers;
            myDel2?.Invoke();
            //
            Console.WriteLine("Делегат для додавання та виведення кiлькостi пiдписникiв");
            MyDelegate3 myDel3 = petition.AddAndGetSubscribers;
            int? a = myDel3?.Invoke(13);
            //
            Console.WriteLine("Анонiмний метод");
            ShowNameDelegate anonim = delegate(Petition petition) { return petition.SubscribersAmount.ToString(); };
            string? amount = anonim(petition);
            Console.WriteLine($"Subscribers amount: {amount}");
            //
            Console.WriteLine("Лямбда-вираз");
            ShowNameDelegate myDelegate = petition1 => petition1.Name;
            Console.WriteLine(myDelegate(petition));
        }
    }
}