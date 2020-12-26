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

      generation.UpdateGeneration();
      var actualNextGen = generation.NeighbourHood;

      Assert.Equal("XX   XX", ConsoleRenderer.NeighbourHoodToString(actualNextGen));
    }
    [Fact]
    public void CanReproduceRuleTwoPattern()
    {

    }
  }
}