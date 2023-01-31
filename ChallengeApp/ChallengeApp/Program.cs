
// Zadanie domowe dzień 4

//Jeżeli jesteś kobietą a czujesz się meżczyzną albo odwrotnie ten program nie jest dla ciebie przepraszam :)

var name = "Ewa";
var gender = "kobieta";
var age = 23;

Console.WriteLine("\n");

if (gender == "kobieta")
{
    if (name == "Ewa" && age == 33)
    {
        Console.WriteLine(name + ", lat " + age);
    }
    else if (age < 30)
    {
        Console.WriteLine("Kobieta poniżej 30 lat");
    }
    else
    {
        Console.WriteLine("Masz na imię " + name + " jesteś " + gender + " oraz masz " + age + " lat.");
    }
}
else if (age >= 18)
{
    Console.WriteLine("Mężczyzna pełnoletni");
}
else
{
    Console.WriteLine("Mężczyzna niepełnoletni");
}
