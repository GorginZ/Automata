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
    public void ShouldOsillateRuleOnePattern()
    {
      var rule = new RuleOne();
      var cells = new int[] { 0, 0, 0, 1, 0, 0, 0 };
      var generation = new Generations(cells, rule);
      Assert.Equal("   X   ", ConsoleRenderer.NeighbourHoodToString(generation.NeighbourHood));

      generation.UpdateGeneration();
      var actualNextGen = generation.NeighbourHood;

      Assert.Equal("XX   XX", ConsoleRenderer.NeighbourHoodToString(actualNextGen));

      generation.UpdateGeneration();

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

    // "   X   "
    // "XXX  XX"
    // "    X  "
    // "XXXX  X"
    // "     X "
    // "XXXXX  " 
    [Fact]
    public void ShouldProduceRuleThreePatterns()
    {
      var rule = new RuleThree();
      var cells = new int[] { 0, 0, 0, 1, 0, 0, 0 };
      var generation = new Generations(cells, rule);
      Assert.Equal("   X   ", ConsoleRenderer.NeighbourHoodToString(generation.NeighbourHood));

      generation.UpdateGeneration();
      var actualNextGen = generation.NeighbourHood;

      Assert.Equal("XXX  XX", ConsoleRenderer.NeighbourHoodToString(actualNextGen));

      generation.UpdateGeneration();
      var actualNextGenThree = generation.NeighbourHood;

      Assert.Equal("    X  ", ConsoleRenderer.NeighbourHoodToString(actualNextGenThree));

      generation.UpdateGeneration();
      var actualNextGenFour = generation.NeighbourHood;

      Assert.Equal("XXXX  X", ConsoleRenderer.NeighbourHoodToString(actualNextGenFour));

      generation.UpdateGeneration();
      var actualNextGenFive = generation.NeighbourHood;

      Assert.Equal("     X ", ConsoleRenderer.NeighbourHoodToString(actualNextGenFive));

      generation.UpdateGeneration();
      var actualNextGenSix = generation.NeighbourHood;

      Assert.Equal("XXXXX  ", ConsoleRenderer.NeighbourHoodToString(actualNextGenSix));
    }

    //"   X   "
    //"   X   "
    //"   X   "
    [Fact]
    public void ShouldProduceRuleFourPattern()
    {
      var rule = new RuleFour();
      var cells = new int[] { 0, 0, 0, 1, 0, 0, 0 };
      var generation = new Generations(cells, rule);
      Assert.Equal("   X   ", ConsoleRenderer.NeighbourHoodToString(generation.NeighbourHood));

      generation.UpdateGeneration();
      var actualNextGen = generation.NeighbourHood;

      Assert.Equal("   X   ", ConsoleRenderer.NeighbourHoodToString(actualNextGen));

      generation.UpdateGeneration();

      Assert.Equal("   X   ", ConsoleRenderer.NeighbourHoodToString(generation.NeighbourHood));
    }
    //rule 5
    // "   X   "
    // "XX X XX"
    // "   X   "
    // "XX X XX"
    [Fact]
    public void ShouldOsillateRuleFivePattern()
    {
      var rule = new RuleFive();
      var cells = new int[] { 0, 0, 0, 1, 0, 0, 0 };
      var generation = new Generations(cells, rule);
      Assert.Equal("   X   ", ConsoleRenderer.NeighbourHoodToString(generation.NeighbourHood));

      generation.UpdateGeneration();

      Assert.Equal("XX X XX", ConsoleRenderer.NeighbourHoodToString(generation.NeighbourHood));

      generation.UpdateGeneration();

      Assert.Equal("   X   ", ConsoleRenderer.NeighbourHoodToString(generation.NeighbourHood));
      generation.UpdateGeneration();

      Assert.Equal("XX X XX", ConsoleRenderer.NeighbourHoodToString(generation.NeighbourHood));
    }
  }
}