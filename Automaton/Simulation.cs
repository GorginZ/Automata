namespace Automaton
{
  public class Simulation
  {
    public void Run(ConsoleRenderer renderer, Generations generation)
    {
      while (true)
      {
        renderer.Render(generation.NeighbourHood);
      }
    }
  }
}