using System;

namespace StaticExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"10 degrees C to F: {TempConverter.CelsiusToFahrenheit(10)}");
            Console.WriteLine($"10 degrees F to C: {TempConverter.FahrenheitToCelsius(10)}");
        }
    }
}