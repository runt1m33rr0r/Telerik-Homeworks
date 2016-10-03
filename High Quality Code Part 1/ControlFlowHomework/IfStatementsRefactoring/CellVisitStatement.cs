namespace IfStatementsRefactoring
{
    internal class CellVisitStatement
    {
        private const int MinXCoordinate = int.MinValue;
        private const int MaxXCoordinate = int.MaxValue;
        private const int MinYCoordinate = int.MinValue;
        private const int MaxYCoordinate = int.MaxValue;

        private void GoToCell(int x, int y)
        {
            if (this.IsCellVisitable(x, y))
            {
                this.VisitCell();
            }
        }

        private bool IsCellVisitable(int x, int y)
        {
            bool isValidXCoordinate = x >= MinXCoordinate && x <= MaxXCoordinate;
            bool isValidYCoordinate = y >= MinYCoordinate && y <= MaxYCoordinate;

            return isValidXCoordinate && isValidYCoordinate;
        }

        private void VisitCell()
        {
        }
    }
}
