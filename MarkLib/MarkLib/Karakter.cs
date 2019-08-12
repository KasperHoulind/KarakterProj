using System;

namespace MarkLib
{
    public class Karakter
    {
        public string GetMark(int karakter)
        {
            if (karakter == -3)
            {
                return "F";
            }

            if (karakter == 0)
            {
                return "Fx";
            }

            if (karakter == 2)
            {
                return "E";
            }
            if (karakter == 4)
            {
                return "D";
            }
            if (karakter == 7)
            {
                return "C";
            }

            if (karakter == 10)
            {
                return "B";
            }

            if (karakter == 12)
            {
                return "A";
            }

            else
            {
                return null;
            }

            
        }

        /*public double GetAverage(string karakter2)
        {
            karakter2.Split(" ");

        }*/
    }
    
}
