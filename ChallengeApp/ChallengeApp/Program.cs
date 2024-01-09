string name = "Joanna";
var myAge = 27;
char sex = 'K';



if (name == "Ewa" && myAge == 30 && sex == 'K')
{
    Console.WriteLine("Ewa lat 30");
}
else if (sex == 'K' && myAge < 30)
{
    Console.WriteLine("Kobieta poniżej 30 lat.");
}
else if (sex == 'M' && myAge < 18)
{
    Console.WriteLine("Niepełnoletni Mężczyzną.");
}