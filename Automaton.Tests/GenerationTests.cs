using Xunit;
namespace Automaton.Tests
{
  public class GenerationTests
  {
    [Fact]
    public void ShouldAppplyRuleOneRules()
    {
      var rule = new RuleOne();
      var cells = new int[]{0,0,0,1,0,0,0};
      var generation = new Generations(cells, rule);
      
      var expectedNextGen = new int[]{1,1,0,0,0,1,1};
      var actualNextGen = generation.NextGen();

      Assert.Equal(expectedNextGen, actualNextGen);
    }
  }
}