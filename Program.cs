using System;

// Skapa en klass 
public class Kalkylator
{
    // Metod som tar in en integer som parameter och skriver ut kvadraten av talet
    public void PrintSquare(int number)
    {
        int square = number * number; // Beräkna kvadraten av det angivna talet
        Console.WriteLine("Kvadraten av " + number + " är " + square); // Skriv ut kvadraten
    }

    // startpunkt
    public static void Main(string[] args)
    {
        Kalkylator kalkylator = new Kalkylator();
        kalkylator.PrintSquare(5); // print square metoden använder nummret 5
    }
}