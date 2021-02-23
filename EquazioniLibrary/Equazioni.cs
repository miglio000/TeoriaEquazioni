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
            if (IsDetermined(a))
                return true;
            else
            {
                if (b == 0)
                    return false;
                else
                    return false;
            }
        }
        public static bool IsDegree2(double a)
        {
            return a != 0;
        }
        public static double Delta(double a, double b, double c)
        {
            return (b * b) - (4 * a * c);
        }
        public static string SoluzioniEq2Grado(double a, double b, double c)
        {
            double delta = Delta(a, b, c);
            double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
            double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
            if (delta < 0 || !IsDegree2(a)) 
                return "impossibile";
            return $"x1= {x1}; x2= {x2}";
        }
        public static string SoluzioneEq1Grado(double a, double b)
        {

            if (a == 0 && b == 0)
                return "indeterminato";
            else if (a != 0 && b == 0)
                return "impossibile";
            else
            {
                double x = b / a;
                return $"x= {x}";
            }
        }
    }
}
