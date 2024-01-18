using Mission2;

public class Program
{
    private static void Main(string[] args)
    {
        BuildArray ba = new BuildArray();

        int numRolls = 0;

        //ask user how many times they want to roll dice
        System.Console.WriteLine("Welcome to the dice throwing simulator!\nHow many dice rolls would you like to simulate?");
        numRolls = int.Parse(System.Console.ReadLine());

        int[] diceArray = ba.ConfigArray(numRolls);

        System.Console.WriteLine("\nDICE ROLLING SIMULATION RESULTS\n" +
            "Each \"*\" represents 1% of the total number of rolls\n" +
            "Total number of rolls = " + numRolls + "\n");

        for (int i = 2; i < 13; i++)
        {
            double percentage = (double)diceArray[i] / numRolls * 100;

            string asterisks = new string('*', (int)percentage);

            System.Console.WriteLine(i + ": " + asterisks + "\n");
        }

        System.Console.WriteLine("Thank you for using the dice throwing simulator! Goodbye!");

    }

}