using System;

namespace EquazioniLibrary
{
    public class Equazioni
    {
        public static bool IsDetermined(double a)
        {
            return a != 0;
        }
        public static bool IsInconstisted(double a, double b)
        {
            if (a != 0)
               return true;
            else
            {
                if (b == 0)
                    return false;
                else
                    return false;
            }
        }
        public static bool IsDegree2(double esponente)
        {
            return esponente == 2;
        }
        public static double Delta(double a, double b, double c)
        {
            double quadrato_b = b * b;
            double quattro_per_a_per_c = 4 * a * c;
            return quadrato_b - quattro_per_a_per_c;
        }
        public static double Soluzione1Eq2Grado(double a, double b, double c)
        {
            double delta = Delta(a, b, c);
            double b2 = b * b;
            double somma = b2 + Math.Sqrt(delta);
            double x1 = somma / 2;
            return x1;
        }
        public static double Soluzione2Eq2Grado(double a, double b, double c)
        {
            double delta = Delta(a, b, c);
            double b2 = b * b;
            double somma = b2 - Math.Sqrt(delta);
            double x2 = somma / 2;
            return x2;
        }
    }
}
