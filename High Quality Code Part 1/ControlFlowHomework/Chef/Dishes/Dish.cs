namespace Chef.Dishes
{
    using Interfaces;

    public abstract class Dish : IDish
    {
        public virtual void Add(IVegetable vegetable)
        {
        }
    }
}
