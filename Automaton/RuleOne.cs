namespace Automaton
{
  public class RuleOne : IRules
  {
    public int CellShouldBeMadeOnNextIteration(int left, int self, int right)
    {
      if (!(left == 1 || self == 1 || right == 1))
      {
        return 1;
      }
      else
      {
        return 0;
      }
    }
  }
}