// See https://aka.ms/new-console-template for more information
using System;

Console.WriteLine("Hello, World!");
//ask user how many times they want to roll dice

//for number of times user chose
//roll the two dice
//add one to the tally for that corresponding number

int die1 = 0;
int die2 = 0;
int total = 0;

int[] rolltotals = new int[13]; // 13 bc 2 is lowest and then can allocate exactly so 0-12


//make a for loop
Random random = new Random();

die1 = random.Next(1, 7);
die2 = random.Next(1, 7);
total = die1 + die2;

rolltotals[total]++;



//print number with number of *'s or percentage

//maybe could just do the string thing and the asterisk and then number and it will print

//for every spot in array (2-12)
    //calculate percentage of times rolled
    //percentage  = how many times number rolled / total number of rolls * 100
    //print number
    //for number of percentage
        //print one asterisk

//use modulus to print or make one of them a double