// See https://aka.ms/new-console-template for more information
internal static class ProgramHelpers
{
    public static void Main(int args)
    {

        Console.WriteLine("Welcome to the dice throwing simulator! ");
        int numberOfRolls = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("How many dice rolls would you like to simulate?");

        Console.WriteLine("DICE ROLLING SIMULATION RESULTS");
        Console.WriteLine("Each \"*\" represents 1% of the total number of rolls.");
        Console.WriteLine("Total number of rolls = " + numberOfRolls + ".");
    }
}