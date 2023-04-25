string sex = "kobieta";
int age = 24;
string name = "Ewa";
int ageEwa = 33;
int ageKuba = 15;
if (sex == "kobieta" && age < 30)
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
if (ageKuba < 18 && sex != "mężczyzna")
{
    Console.WriteLine("Niepełnoletni Mężczyzna");
}
else
{
    Console.WriteLine("To nie jest niepełnoletni Mężczyna");
}