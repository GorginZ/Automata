
using System;
using System.Text;

namespace Automaton
{
  public class ConsoleRenderer
  {
    public void Render(int[] neighbourHood)
    {
      Console.WriteLine(NeighbourHoodToString(neighbourHood));
    }

    public static string NeighbourHoodToString(int[] neighbourHood)
    {
      var visualizeGeneration = new StringBuilder();

      for (int i = 0; i < neighbourHood.GetLength(0); i++)
      {
        var stringValue = i == 1 ? "X" : " ";
        visualizeGeneration.Append(stringValue);
      }
      return visualizeGeneration.ToString();
    }
  }
}