using System;

namespace Automaton
{
    class Program
    {
        static void Main(string[] args)
        {
          var rules = new RuleOne();
          var cells = new int[]{0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0};
          var generation = new Generations(cells, rules);
          var simulation = new Simulation();
          simulation.Run(new ConsoleRenderer(), generation);
        }
    }
}
