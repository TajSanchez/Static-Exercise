namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            // var temp = new TempConverter();

            var celcius = TempConverter.FahrenheitToCelsius(79);
           
            var fahrenheit = TempConverter.CelsiusToFahrenheit(79);
            

            Console.WriteLine("These temperatures are now conversed.");
            Console.WriteLine($"celcius {celcius}");
            Console.WriteLine($"farnheit {fahrenheit}");
        }
    }
}
