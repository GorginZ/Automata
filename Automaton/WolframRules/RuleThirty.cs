namespace Automaton
{
  public class RuleThirty : IRules
  {
    //left, self, right
    //l ⊻ (s V r)
    public int CellValueForNextGen(int left, int self, int right)
    {
      if (left == 1 ^ (self == 1 || right == 1))
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