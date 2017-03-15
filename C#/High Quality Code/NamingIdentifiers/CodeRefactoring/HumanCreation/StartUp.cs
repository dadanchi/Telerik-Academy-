namespace HumanCreation
{
    using HumanCreation.Factories;

    public class StartUp
    {
        public static void Main()
        {
            var goshka = Factory.CreateAHuman(9);
        }
    }
}
