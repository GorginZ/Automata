using Xunit;
namespace Automaton.Tests
{
  public class RuleThirtyTests
  {
    // "XXX"
    // "   "
    [Fact]
    public void ShouldReproduceRuleThirtyConfig111()
    {
      var rule = new RuleThirty();
      var cells = new int[] { 1, 1, 1 };
      var generation = new Generations(cells, rule);
      Assert.Equal("XXX", ConsoleRenderer.NeighbourHoodToString(generation.NeighbourHood));

      generation.UpdateGeneration();

      Assert.Equal("   ", ConsoleRenderer.NeighbourHoodToString(generation.NeighbourHood));

    }
    [Fact]
    public void ShouldProduceRuleThirtyConfig110()
    {
      var rule = new RuleThirty();
      var cells = new int[] { 1, 1, 0 };
      var generation = new Generations(cells, rule);
      Assert.Equal("XX ", ConsoleRenderer.NeighbourHoodToString(generation.NeighbourHood));

      generation.UpdateGeneration();

      Assert.Equal("   ", ConsoleRenderer.NeighbourHoodToString(generation.NeighbourHood));
    }


    [Fact]
    public void ShouldProduceRuleThirtyConfig101()
    {
      var rule = new RuleThirty();
      var cells = new int[] { 1, 0, 1 };
      var generation = new Generations(cells, rule);
      Assert.Equal("X X", ConsoleRenderer.NeighbourHoodToString(generation.NeighbourHood));

      generation.UpdateGeneration();

      Assert.Equal("   ", ConsoleRenderer.NeighbourHoodToString(generation.NeighbourHood));
    }
    [Fact]
    public void ShouldProduceRuleThirtyConfigFor100()
    {
      var rule = new RuleThirty();
      var cells = new int[] { 1, 0, 0 };
      var generation = new Generations(cells, rule);
      Assert.Equal("X  ", ConsoleRenderer.NeighbourHoodToString(generation.NeighbourHood));

      generation.UpdateGeneration();

      Assert.Equal(" X ", ConsoleRenderer.NeighbourHoodToString(generation.NeighbourHood));
    }


    [Fact]
    public void ShouldProduceRuleThirtyConfigFor011()
    {
      var rule = new RuleThirty();
      var cells = new int[] { 0, 1, 1 };
      var generation = new Generations(cells, rule);
      Assert.Equal(" XX", ConsoleRenderer.NeighbourHoodToString(generation.NeighbourHood));

      generation.UpdateGeneration();

      Assert.Equal(" X ", ConsoleRenderer.NeighbourHoodToString(generation.NeighbourHood));
    }

    [Fact]
    public void ShouldProduceRuleThirtyConfigFor010()
    {
      var rule = new RuleThirty();
      var cells = new int[] { 0, 1, 0 };
      var generation = new Generations(cells, rule);
      Assert.Equal(" X ", ConsoleRenderer.NeighbourHoodToString(generation.NeighbourHood));

      generation.UpdateGeneration();

      Assert.Equal(" X ", ConsoleRenderer.NeighbourHoodToString(generation.NeighbourHood));
    }
    [Fact]
    public void ShouldReproduceRuleThirtyRules001()
    {
      var rule = new RuleThirty();
      var cells = new int[] { 0, 0, 1 };
      var generation = new Generations(cells, rule);
      Assert.Equal("  X", ConsoleRenderer.NeighbourHoodToString(generation.NeighbourHood));

      generation.UpdateGeneration();

      Assert.Equal(" X ", ConsoleRenderer.NeighbourHoodToString(generation.NeighbourHood));
    }
    [Fact]
    public void ShouldReproduceRuleThirtyRules000()
    {
      var rule = new RuleThirty();
      var cells = new int[] { 0, 0, 0 };
      var generation = new Generations(cells, rule);
      Assert.Equal("   ", ConsoleRenderer.NeighbourHoodToString(generation.NeighbourHood));

      generation.UpdateGeneration();

      Assert.Equal("   ", ConsoleRenderer.NeighbourHoodToString(generation.NeighbourHood));
    }
  }
}