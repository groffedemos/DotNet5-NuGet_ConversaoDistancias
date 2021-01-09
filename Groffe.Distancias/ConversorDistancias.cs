using System;

namespace Groffe.Distancias
{
    public static class ConversorDistancias
    {
        public static double MilhasParaKm(double milhas, int casasArredondamento = 3) =>
            Math.Round(Convert.ToDouble(milhas) * 1.609, casasArredondamento);
    }
}