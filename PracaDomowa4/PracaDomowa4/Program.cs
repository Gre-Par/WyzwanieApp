string name = "Ewa";
int age = 33;
bool woman = true;

if (woman == true)
{
    if (age < 30)
    {
        Console.WriteLine("Kobieta poniżej 30 lat");
    }
    else if (name == "Ewa" && age == 33)
    {
        Console.WriteLine("Ewa, lat 33");
    }
}
else if (age < 18)
{
    Console.WriteLine("Niepełnoletni Mężczyna");
}