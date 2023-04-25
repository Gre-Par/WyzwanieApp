int age = 24;
string name = "Ewa";
int ageEwa = 33;
int ageKuba = 15;
bool kobieta = true;
if (kobieta == true && age < 30)
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}
else
{
    Console.WriteLine("To nie jest kobieta poniżej 30 lat");
}
if (name == "Ewa" && ageEwa == 33)
{
    Console.WriteLine("Ewa, lat 33");
}
else
{
    Console.WriteLine("To ni ejest Ewa i nie ma 33 lat");
}
if (ageKuba < 18 && kobieta == true)
{
    Console.WriteLine("Niepełnoletnia Kobieta");
}
else
{
    Console.WriteLine("Niepełnoletni Mężczyna");
}