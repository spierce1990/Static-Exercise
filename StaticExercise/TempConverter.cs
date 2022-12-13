using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticExercise
{
    internal class TempConverter
    {

       

        public static  double FarToCel(double a)

        {
            double newAnswer;
            newAnswer = (a- 32) * 5 / 9;
            return newAnswer;

            //F = (C * 9) / 5 + 32;
           // To convert from Fahrenheit to Celsius: C = (F – 32) *5 / 9;
        }

    public static double  CelToFar(double b)

        {
            double newAnswer;
            newAnswer = (b * 9) / 5 + 32;
            return newAnswer;

        
        }

  }

}
