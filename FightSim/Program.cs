
int hp1 = 100;
int hp2 = 100;
int RoundCount = 1;

Console.WriteLine("-----WELCOME TO THE FIGHT OF FIGHTS-----");
Console.ReadLine();


while (hp1 > 0 && hp2 > 0)
{
    Console.WriteLine($"----ROUND {RoundCount}---------------------");

    int attack1 = Random.Shared.Next(11); //KAN INTE BLI 10
    int attack2 = Random.Shared.Next(11);
    
    Console.WriteLine($"Hero dealt {attack1} damage");
    Console.WriteLine($"Evil guy dealt {attack2} damage");

    Console.WriteLine("________________________________");

    hp1 = hp1-attack2;
    hp2 = hp2-attack1;

    Console.WriteLine($"Hero has {hp1} health remaining");
    Console.WriteLine($"evil guy has {hp2} health remaining");
    Console.WriteLine("________________________________");
    RoundCount = RoundCount+1;
    Console.ReadLine();
    
}

if(hp1<0 && hp2 > 0)
{
    Console.WriteLine("--------Evil guy won--------");
    Console.ReadLine();
}

if(hp2<0 && hp1 > 0)
{
    Console.WriteLine("--------Hero won--------");
    Console.ReadLine();
}

if(hp1<0 && hp2 < 0)
{
    Console.WriteLine("--------its a draw--------");
    Console.ReadLine();
}


//Break; gör så att en loop avslutas.  

