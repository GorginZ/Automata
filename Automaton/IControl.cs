namespace Automaton
{
  public interface IControl
  {
    ControlCommand Command { get; set; }

    void SetCurrentCommand();
    void ReadCommand();
  }
}