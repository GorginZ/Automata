namespace Automaton
{
  public class Generations
  {
    public int[] NeighbourHood { get; private set; }
    private readonly IRules _rules;
    public Generations(int[] cells, IRules rules)
    {
      NeighbourHood = cells;
      _rules = rules;
    }
    private int[] NextGen()
    {
      var nextGeneration = new int[NeighbourHood.GetLength(0)];
      for (int i = 0; i < NeighbourHood.GetLength(0); i++)
      {
        var left = i == 0 ? (NeighbourHood[NeighbourHood.GetLength(0) - 1]) : NeighbourHood[i - 1];
        var self = NeighbourHood[i];
        var right = i == (NeighbourHood.GetLength(0) - 1) ? NeighbourHood[0] : NeighbourHood[i + 1];

        nextGeneration[i] = _rules.CellValueForNextGen(left, self, right);
      }
      return nextGeneration;
    }
    public void UpdateGeneration()
    {
      NeighbourHood = NextGen();
    }
  }
}