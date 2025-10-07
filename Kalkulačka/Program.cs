Console.WriteLine("Daj prvé čislo");
string? prveCislo = Console.ReadLine();
Console.WriteLine("Operator (+, -, , /, %)");
string oper = Console.ReadLine();
Console.WriteLine("Daj druhé čislo");
string? druheCislo = Console.ReadLine();
double n1 = double.Parse(prveCislo);
double n2 = double.Parse(druheCislo);
double sucet = 0;
if (oper == "+")
{
    sucet = n1 + n2;
}
else if (oper == "-")
{
    sucet = n1 - n2;
}
else if (oper == "")
{
    sucet = n1 * n2;
}
else if (oper == "/")
{
    sucet = n1 / n2;
}
else if (oper == "%")
{
    sucet = n1 % n2;
}
else
{
    Console.WriteLine("Neplatna operacia!");
    return;
}

Console.WriteLine($"Sucet: {sucet}");
