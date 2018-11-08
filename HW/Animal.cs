namespace HW
{
    public class Animal
    {
        protected string sound = "Gav";

        private string _testCommit;

        public virtual void MakeSound()
        {
            System.Console.WriteLine(sound);
        }
    }
}
