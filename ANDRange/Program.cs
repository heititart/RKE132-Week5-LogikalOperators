// temp <= freesing cold
// temp >0 AND temp <= 10  - cold
// temp > 10 AND temp <= 19 chilli
// temp > 15 AND temp < 20 warm
// temp >= 20 AND temp < 30 hot
// temp >= 30 - boiling hot

Console.WriteLine(" Enter the temperatture value in celsus:");
int temp = Int32.Parse(Console.ReadLine());

Console.WriteLine();


if (temp >= 30 && temp <= 50)
{
    Console.WriteLine("Boiling Hot");
}

else if (temp < 30 && temp >= 20)
{
    Console.WriteLine("Hot!");
}

else if (temp < 20 && temp > 15)
{
    Console.WriteLine("Warm");
}

else if (temp <= 15 && temp > 10)
{
    Console.WriteLine("chilli");
}

else if (temp <= 10 && temp > 0)
{
    Console.WriteLine("Cold");
}

else if (temp <= 0 && temp <= -50 )
{
    Console.WriteLine("Freezing cold");
}

else

    Console.WriteLine("It's the end of the world!");