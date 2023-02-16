// Math >= 90%
// Chemistry >= 90%
// Üliõpilane sisestab ise tulemused.



int math, chemistry, biology;

Console.WriteLine("Enter your Math exam result:");
math = Int32.Parse(Console.ReadLine());

Console.WriteLine("Enter your Chemistry exam result:");
chemistry = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter your Biology exam result:");
biology = Int32.Parse(Console.ReadLine());

if ( math >= 90 && chemistry >= 90 && biology >= 90)
{
    Console.WriteLine("Welcome to university!");
}

else
{
    Console.WriteLine("Go to the community college");
}

