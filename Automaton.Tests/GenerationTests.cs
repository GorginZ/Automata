using Xunit;
namespace Automaton.Tests
{
  public class GenerationTests
  {
    [Fact]
    public void ShouldAppplyRuleOneRules()
    {
      var rule = new RuleOne();
      var cells = new int[] { 0, 0, 0, 1, 0, 0, 0 };
      var generation = new Generations(cells, rule);
      Assert.Equal("   X   ", ConsoleRenderer.NeighbourHoodToString(generation.NeighbourHood));

      // Assert.Equal(7, ConsoleRenderer.NeighbourHoodToString(generation.NeighbourHood).Length);
      var actualNextGen = generation.NextGen();

      //initial "   X   "
      // Assert.Equal("XX   XX", ConsoleRenderer.NeighbourHoodToString(actualNextGen));
    }

  }
}