using System.ComponentModel;

namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello let us do some temp conversion");
            Console.WriteLine();
            Console.WriteLine("Please enter a C you want to convert to F temperature.");
            var userAnswer1 = Convert.ToDouble( Console.ReadLine());

            

            Console.WriteLine(TempConverter.CelToFar(userAnswer1));

            Console.WriteLine("Please enter a F you want to convert to C temperature.");
            var userAnswer2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(TempConverter.FarToCel(userAnswer2));
            


            //Now create a static class called TempConverter. The class should have at least 2 methods
            //one called FahrenheitToCelsius that will require a double as a parameter and return a double,
            //the other CelsiusToFahrenheit which will also require a double as a parameter and return a double.

            // Fill out these methods and call them in your Program.cs file. Make sure they’re accurate!
        }
    }
}
