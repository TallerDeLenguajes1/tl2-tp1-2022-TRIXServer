
System.Console.Clear();
System.Console.WriteLine("--\tCalcular cuadrado");
System.Console.WriteLine();
System.Console.Write("Ingrese un numero: ");

try
{
    int numeroIngresado = int.Parse(Console.ReadLine());
    System.Console.WriteLine();
    System.Console.WriteLine($"El cuadrado de {numeroIngresado} es: " + numeroIngresado * numeroIngresado);

}
catch (System.Exception)
{
    System.Console.WriteLine("Numero no valido");
}

