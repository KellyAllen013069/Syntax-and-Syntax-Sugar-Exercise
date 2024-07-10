namespace SyntaxAndSyntaxSugarExercise
{
    public class Program
    {
        static void Main()
        {
            Console.WriteLine("Please enter an integer: ");
            var answer = int.Parse(Console.ReadLine());
            var response = (answer < 9) ? $"{answer} is less than nine" : $"{answer} is greater than or equal to nine";
            Console.WriteLine(response);
        }
    }
}
