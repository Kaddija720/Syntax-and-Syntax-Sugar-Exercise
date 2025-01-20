namespace SyntaxAndSyntaxSugarExercise;

public class Program
{
    private static void Main(string[] args)
    {
        var answer = 10;
        var response = answer < 9 ? $"{answer} is less than nine:" : $"{answer} is greater than or equal to nice";
        Console.WriteLine(response);
       
    }
}