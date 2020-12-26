using System.Threading;
namespace Automaton
{
  public class Simulation
  {
    public void Run(ConsoleRenderer renderer, Generations generation, IControl controller)
    {
      var controllerLock = new object();

      Thread setControlCommand = new Thread(() =>
        {
          while (controller.Command != ControlCommand.End)
          {
            controller.ReadCommand();
            lock (controllerLock)
            {
              controller.SetCurrentCommand();
            }
          }
        }); setControlCommand.Start();

      Thread renderSimulation = new Thread(() =>
      {
        while (controller.Command != ControlCommand.End)
        {
          Thread.Sleep(300);
          lock (controllerLock)
          {
            if (controller.Command == ControlCommand.Running)
            {
              renderer.Render(generation.NeighbourHood);
              generation.UpdateGeneration();
            }
          }
        }
      });
      renderSimulation.Start();
    }
  }
}

