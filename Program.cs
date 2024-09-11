// See https://aka.ms/new-console-template for more information

{int tal=5; 
while (tal !=0)
{
    Console.Write("skriv ett tal: ");
    tal= Convert.ToInt32(Console.ReadLine());
    if(tal % 2 == 0)
       Console.WriteLine("talet är jämnt");
    else
       Console.WriteLine("talet är udda");
}
}