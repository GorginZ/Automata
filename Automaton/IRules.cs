namespace Automaton
{
  public interface IRules
  {
    int CellValueForNextGen(int left, int self, int right);
  }
}