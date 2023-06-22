using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Konsolenanwendung_Tutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            ///FG & BG Color sind nur für die Schrift, nicht den eigentlichen Hintergrund der Anzeige.
            Console.ForegroundColor = ConsoleColor.Yellow; 
            Console.BackgroundColor= ConsoleColor.Magenta;
          ///Hier steht, was ausgegeben wird wenn die Anwendung läuft.
            Console.WriteLine("Hello World!");

            ///Zeile eingefügt damit das Fenster offen bleibt und tab benötig wird zum beenden.
            Console.ReadKey();
        }
    }
}