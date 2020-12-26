namespace Automaton
{
  public class Generations
  {
    public int[] NeighbourHood;
    private IRules _rules;
    public Generations(int[] cells, IRules rules)
    {
      NeighbourHood = cells;
      _rules = rules;
    }
    public int[] NextGen()
    {
      var nextGeneration = new int[NeighbourHood.GetLength(0)];
      for (int i = 1; i < NeighbourHood.GetLength(0) - 1; i++)
      {
        int left = NeighbourHood[i - 1];
        int self = NeighbourHood[i];
        int right = NeighbourHood[i + 1];
        nextGeneration[i] = _rules.CellValueForNextGen(left, self, right);
      }
      return nextGeneration;
    }
  }
}