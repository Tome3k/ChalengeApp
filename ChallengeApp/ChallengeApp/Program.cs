
using System.Globalization;
using static System.Runtime.InteropServices.JavaScript.JSType;


var number =5345346;
string numberInString = number.ToString();
char[] letters = numberInString.ToArray();
int[] wynik = new int[10];
int z = 0;
foreach (int x in wynik)//zerowanie tablicy
{
    wynik[x] = 0;
}

foreach(char letter in letters)
{
    if (letter == '0') { wynik[0]++; }
    else if (letter == '1') { wynik[1]++;}
    else if (letter == '2') { wynik[2]++; }
    else if (letter == '3') { wynik[3]++; }
    else if (letter == '4') { wynik[4]++; }
    else if (letter == '5') { wynik[5]++; }
    else if (letter == '6') { wynik[6]++; }
    else if (letter == '7') { wynik[7]++; }
    else if (letter == '8') { wynik[8]++; }
    else    { wynik[9]++; }
}
Console.WriteLine("Liczba w zadaniu to: "+number+"\n");
foreach(int i in wynik)
{
    Console.WriteLine(z+" występuje: "+i + " razy");
    z++;
}