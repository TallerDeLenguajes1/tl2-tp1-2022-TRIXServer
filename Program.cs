
System.Console.Clear();
System.Console.WriteLine("--\tCalcular km/l");
System.Console.WriteLine();

try
{
    System.Console.Write("Ingrese los kilometros recorridos: ");
    uint kilometros = uint.Parse(Console.ReadLine());
    System.Console.WriteLine();
    System.Console.Write("Ingrese los litros consumidos: ");
    uint litros = uint.Parse(Console.ReadLine());
    System.Console.WriteLine();
    double resultado = kilometros / litros;
    System.Console.WriteLine($"Consumo de km/l: " + resultado);

}
catch (Exception ex)
{
    var msg = "Error message: " + ex.Message;
    System.Console.WriteLine(msg);
}

