namespace Automaton
{
  public interface IRules
  {
    int CellShouldBeMadeOnNextIteration(int left, int self, int right);
  }
}