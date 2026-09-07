
int szam1 = 15;
int szam2 = 15;

if (szam1 < szam2)
{
    szam2 = szam2 * 2;
    Console.WriteLine($"A nagyobb szám: {szam2}");
}
else if (szam1 < szam2) 
{
    szam1 = szam1 * 2;    
    Console.WriteLine($"A nagyobb szám: {szam1}"); 
}
else Console.WriteLine("A két szám egyenlő");
