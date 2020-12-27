namespace Automaton
{
  public class RuleFour : IRules
  {
    public int CellValueForNextGen(int left, int self, int right)
    {
      if (!(left == 1 || right == 1) && self == 1)
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