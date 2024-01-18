internal class Program
{
    private static void Main(string[] args)
    {
        int numRolls = 0;

        //ask user how many times they want to roll dice
        System.Console.WriteLine("Welcome to the dice throwing simulator!\nHow many dice rolls would you like to simulate?");
        numRolls = int.Parse(System.Console.ReadLine());

        int[] diceArray = ConfigArray(numRolls);

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

    private static int[] ConfigArray(int numRolls)
    { 

        int[] rolltotals = new int[13]; // 13 bc 2 is lowest and then can allocate exactly so 2-12

        System.Random random = new System.Random();

        //make a for loop for each roll
        for (int i = 0; i < numRolls; i++)
        {
            int die1 = 0;
            int die2 = 0;
            int total = 0;

            //roll the two dice

            die1 = random.Next(1, 7);
            die2 = random.Next(1, 7);
            total = die1 + die2;

            //add one to the tally for that corresponding number

            rolltotals[total]++;
        }

        return rolltotals;


    }
}