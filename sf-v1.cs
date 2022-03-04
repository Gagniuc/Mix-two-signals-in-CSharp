// Spectral forecast for signals in C#
// Author: Dr. Paul A. Gagniuc
// Date:   01/02/2022

using System;

public class SpectralForecast
{
    public static void Main(string[] args)
    {

        string A = "10.3,23.4,44.8,63.2,44.1,35.1,46.5,62.6,50.4,28.9,24.7";
        string B = "18.8,43.1,52.2,45.5,46.8,46.6,67.9,66.3,70.4,62,39.7";
        
        string[] tA = A.Split(',');
        string[] tB = B.Split(',');
        
        string M = "";
        double maxA = 0;
        double maxB = 0;
        double maxAB = 0;
        double d = 33;
        double v = 0;
        
        for (int i = 0; i < tA.Length; i++) 
        {
            if (double.Parse(tA[i]) > maxA){maxA = double.Parse(tA[i]);}
            if (double.Parse(tB[i]) > maxB){maxB = double.Parse(tB[i]);}
            if (maxA > maxAB){maxAB = maxA;}
            if (maxB > maxAB){maxAB = maxB;}
        }
        
        for(int i = 0; i < tA.Length; i++) {
            v = ((d/maxA)*double.Parse(tA[i]))+(((maxAB-d)/maxB)*double.Parse(tB[i]));
            M += Math.Round(v, 2);
            if(i < tA.Length-1){M += ',';}
        }

        Console.WriteLine (M);
    }
}