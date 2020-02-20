using System;

namespace CalcLibrary
{
    public static class Calc
    {
        public static double RadQ(double num)
        {
            double resp = 0;
            if (num >= 0)
                resp = Math.Sqrt(num);
            else
                resp = double.NaN;
            return resp;
        }
        public static double Vertice(double a, double b)
        {
            
            double ris = -b/(2*a);
            return ris;
        }
    }
}
