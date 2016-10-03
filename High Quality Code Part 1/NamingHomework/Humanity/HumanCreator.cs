namespace Humanity
{
    internal class HumanCreator
    {
        private const string MaleName = "Батката";
        private const string FemaleName = "Мацето";

        public void CreateHuman(int age)
        {
            Human someHuman = new Human();

            someHuman.Age = age;

            if (age % 2 == 0)
            {
                someHuman.Name = MaleName;
                someHuman.Gender = GenderType.Male;
            }
            else
            {
                someHuman.Name = FemaleName;
                someHuman.Gender = GenderType.Female;
            }
        }
    }
}
