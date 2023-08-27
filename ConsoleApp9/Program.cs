
Console.WriteLine("Hello, World!");
float celsius = 0.0f, fahrenheit = 0.0f;
Console.WriteLine("Ingrese la temperatura en grados Fahrenheit:");
fahrenheit = Convert.ToSingle(Console.ReadLine());

celsius = (fahrenheit - 32) * 5 / 9;

Console.WriteLine(fahrenheit + " grados Fahrenheit es equivalente a " + celsius + " grados celsius");

Console.ReadKey();
