namespace IfStatementsRefactoring
{
    using Chef.Interfaces;
    using Chef.Vegetables;

    internal class CookStatement
    {
        private void CookPotato(Potato somePotato)
        {
            bool potatoExists = somePotato != null;
            bool potatoIsCookable = !somePotato.HasNotBeenPeeled && !somePotato.IsRotten;

            if (potatoExists && potatoIsCookable)
            {
                this.Cook(somePotato);
            }
        }

        private void Cook(IVegetable someVegetable)
        {
        }
    }
}
