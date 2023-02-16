// math >= 90 OR Chemistry >= 90 OR biology >= 90

// math && chemistry || math && biology || chemistry && biology

int math, chemistry, biology;

Console.WriteLine("Enter your Math exam result:");
math = Int32.Parse(Console.ReadLine());

Console.WriteLine("Enter your Math exam result:");
biology = Int32.Parse(Console.ReadLine());

Console.WriteLine("Enter your Chemistry exam result:");
chemistry = Convert.ToInt32(Console.ReadLine());


if ((math >= 90 && chemistry >= 90) || (math >= 90 && biology >= 90) || (chemistry >= 90 && biology >= 90))
{
    Console.WriteLine("Welcome to university!");
}

else
{
    Console.WriteLine("Go to the community college");
}