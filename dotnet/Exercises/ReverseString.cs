using System.Text;


// Create a method the reverses a string.
// Do not use the built-in string reverse method.

namespace StringExercises
{
  public static class ReverseString
  {
    public static string Reverse(string input)
    {
      var sb = new StringBuilder();

      for(int i = input.Length - 1; i >= 0; i--)
      {
        sb.Append(input[i]);
      }

      return sb.ToString();
    }
  } 
}