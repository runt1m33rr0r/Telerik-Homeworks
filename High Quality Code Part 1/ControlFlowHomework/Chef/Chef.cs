namespace Chef
{
    using Dishes;
    using Interfaces;
    using Vegetables;

    public class Cooker
    {
        public void Cook()
        {
            IVegetable somePotato = this.GetPotato();
            IVegetable someCarrot = this.GetCarrot();
            IDish someBowl = this.GetBowl();

            this.Peel(somePotato);
            this.Peel(someCarrot);

            this.Cut(somePotato);
            this.Cut(someCarrot);

            someBowl.Add(somePotato);
            someBowl.Add(someCarrot);
        }

        private IVegetable GetPotato()
        {
            return new Potato();
        }

        private IDish GetBowl()
        {
            return new Bowl();
        }

        private IVegetable GetCarrot()
        {
            return new Carrot();
        }

        private void Peel(IVegetable vegetable)
        {
        }

        private void Cut(IVegetable vegetable)
        {
        }
    }
}
