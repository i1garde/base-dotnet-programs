using System.Threading;

namespace ElectronicPetitionProgramLab8
{
    public class FileReader
    {
        public string Text { get; set; }
        static object locker = new object();

        public FileReader(string text)
        {
            Text = text;
        }

        public string GetText()
        {
            return Text;
        }
        
        public void AddText()
        {
            Text += $"Added Text {Thread.CurrentThread.Name} ";
            
        }
        
        public void SynthronizedAddText()
        {
            lock (locker)
            {
                Text += $"Added Text {Thread.CurrentThread.Name} ";
                Thread.Sleep(100);
            }
        }
    }
}