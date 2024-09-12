using System.ComponentModel;

Console.WriteLine("Användarnamn:");
string name = Console.ReadLine();

if (name == "Signe")
{
    Console.WriteLine("välkomen!");
}
else 
{
    Console.WriteLine(" Vem är du fanta");
}

Console.WriteLine(" Du är vid ett vägskäl tar du höger eller vänster:");
string direction = Console.ReadLine(); 

if (direction == "vänster")
{
    Console.WriteLine("Du ser din farfar går eller springer du fram till honom och ger en  kram ");
}
else{
    Console.WriteLine("Du kommer hem och ser att din syster står i trappan och  har gråttit frågar du vad har hänt eller går du upp för trappan");
}

string left = Console.ReadLine();

if(left == "springer" )
{
    Console.WriteLine("du får ge din farfar en kram utan att veta att det är den sista");
}
else{
    Console.WriteLine("Du hinner inte och du se din farfar försvinna från ditt liv helt plötsligt");
}

string right = Console.ReadLine();

if(right == "vad har hänt")
{
    Console.WriteLine("hon svarar du kommer få veta när du kommer upp i köket");
}
else{
    Console.WriteLine("du får veta att din farmor har dött i cancer");
}

string kitchen = Console.ReadLine(); 

if(kitchen == " går upp till köket")
{
    Console.WriteLine("din pappa står vid matbordet och tittar på dig och säger att farmor har dött i cancer");
}
else{
    Console.WriteLine(" du tvingar din syster att säga vad som hänt hon säger att farmor har dött när du hör det springer du upp till dit rum  eller står helt stilla"); 
}

string run = Console.ReadLine(); 

if(run == "springer")
{
    Console.WriteLine("Du springer upp till ditt rum gråtandes och slänger igen dörren och stannar där resten av kvällen");
}
else{
    Console.WriteLine("Din syster kommer och kramar dig tills du drar ifrån"); 
}

Console.ReadLine(); 