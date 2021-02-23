using System;
using EquazioniLibrary;
namespace ConsoleLibreriaEquazioni
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("EQUAZIONE 1° grado: ");
            Console.Write("Inserisci a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Inserisci b: ");
            int b = int.Parse(Console.ReadLine());
            bool determined = Equazioni.IsDetermined(a);
            Console.WriteLine($"E' determinata: {determined}.");
            bool inconsisted = Equazioni.IsInconstisted(a, b);
            Console.WriteLine($"E' inconsistente: {inconsisted}.");
            string soluzione1grado = Equazioni.SoluzioneEq1Grado(a, b);
            Console.WriteLine($"Soluzione: {soluzione1grado}.");
            Console.WriteLine();
            Console.WriteLine("EQUAZIONE 2° grado: ");
            Console.Write("Inserisci a: ");
            double a1 = double.Parse(Console.ReadLine());
            Console.Write("Inserisci b: ");
            double b1 = double.Parse(Console.ReadLine());
            Console.Write("Inserisci c: ");
            double c1 = double.Parse(Console.ReadLine());
            bool isdegree2 = Equazioni.IsDegree2(a1);
            Console.WriteLine($"E' di secondo grado: {isdegree2}.");
            double delta = Equazioni.Delta(a1, b1, c1);
            Console.WriteLine($"Il delta è: {delta}.");
            string soluzione2grado = Equazioni.SoluzioniEq2Grado(a1, b1, c1);
            Console.WriteLine($"La/e soluzione/i sono: {soluzione2grado}.");
        }
    }
}
