using System;

int numRolls = 0;

//ask user how many times they want to roll dice
System.Console.WriteLine("How many times do you want to roll?");
numRolls = int.Parse(System.Console.ReadLine());

System.Console.WriteLine(numRolls);

int[] rolltotals = new int[13]; // 13 bc 2 is lowest and then can allocate exactly so 2-12

//make a for loop for each roll
for (int i = 0; i < numRolls; i++)
{
    int die1 = 0;
    int die2 = 0;
    int total = 0;

    //roll the two dice

    Random random = new Random();
    die1 = random.Next(1, 7);
    die2 = random.Next(1, 7);
    total = die1 + die2;

    //add one to the tally for that corresponding number

    rolltotals[total]++;
}

for (int i = 2;i < 13;i++)
{
    System.Console.WriteLine(rolltotals[i] + "\n");
}



//print number with number of *'s or percentage

//maybe could just do the string thing and the asterisk and then number and it will print

//for every spot in array (2-12)
//calculate percentage of times rolled
//percentage  = how many times number rolled / total number of rolls * 100
//print number
//for number of percentage
//print one asterisk

//use modulus to print or make one of them a double