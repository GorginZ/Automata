namespace Automaton.Tests
{
  public class GenerationTests
  {
    public void ShouldAppplyRuleOneRules()
    {
      var rule = new RuleOne();
      var cells = new int[]{0,0,0,1,0,0,0};
      var generation = new Generations(cells, rule);
      generation.NextGen
    }
  }
}