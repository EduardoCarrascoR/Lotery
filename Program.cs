Random Number = new Random();

int rollNumber1 = Number.Next(1, 7);
int rollNumber2 = Number.Next(1, 7);
int rollNumber3 = Number.Next(1, 7);

int total = rollNumber1 + rollNumber2 + rollNumber3;

Console.WriteLine($"Numbers roll: {rollNumber1} + {rollNumber2} + {rollNumber3} = {total}");


if ((rollNumber1 == rollNumber2) || (rollNumber2 == rollNumber3) || (rollNumber1 == rollNumber3))
{

    if ((rollNumber1 == rollNumber2) && (rollNumber2 == rollNumber3)) 
    {
        Console.WriteLine("You rolled triples! +6 bonus to total!");
        total += 6;
    }
    else
    {
        Console.WriteLine("You rolled doubles! +2 bonus to total!");
        total += 2;
        
    }
    Console.WriteLine($"Your total including the bonus: {total}");
}



if (total >= 16)
{
    Console.WriteLine("You win a new car!");
}
else if (total >= 10)
{
    Console.WriteLine("You win a new laptop!");
}
else if (total == 7)
{
    Console.WriteLine("You win a trip for two!");
}
else
{
    Console.WriteLine("You win a kitten!");
}