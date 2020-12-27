using Automaton;
using Xunit;
namespace Automaton.Tests
{
  public class GenerationTests
  {
    //"   X   "
    //"XX   XX"
    //"   X   "
    [Fact]
    public void ShouldAppplyRuleOneRules()
    {
      var rule = new RuleOne();
      var cells = new int[] { 0, 0, 0, 1, 0, 0, 0 };
      var generation = new Generations(cells, rule);
      Assert.Equal("   X   ", ConsoleRenderer.NeighbourHoodToString(generation.NeighbourHood));

      generation.UpdateGeneration();
      var actualNextGen = generation.NeighbourHood;

      Assert.Equal("XX   XX", ConsoleRenderer.NeighbourHoodToString(actualNextGen));

      generation.UpdateGeneration();
      var actualNextGenThree = generation.NeighbourHood;

      Assert.Equal("   X   ", ConsoleRenderer.NeighbourHoodToString(generation.NeighbourHood));
    }

   //"   X   "
   //"  X    "
   //" X     " 
    [Fact]
    public void ShouldAppplyRuleTwoRules()
    {
      var rule = new RuleTwo();
      var cells = new int[] { 0, 0, 0, 1, 0, 0, 0 };
      var generation = new Generations(cells, rule);
      Assert.Equal("   X   ", ConsoleRenderer.NeighbourHoodToString(generation.NeighbourHood));

      generation.UpdateGeneration();
      var actualNextGen = generation.NeighbourHood;

      Assert.Equal("  X    ", ConsoleRenderer.NeighbourHoodToString(actualNextGen));

      generation.UpdateGeneration();
      var actualNextGenThree = generation.NeighbourHood;

      Assert.Equal(" X     ", ConsoleRenderer.NeighbourHoodToString(actualNextGenThree));
    }

  }
}