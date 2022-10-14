
System.Console.Clear();
System.Console.WriteLine("--\tDividir dos numeros");
System.Console.WriteLine();
System.Console.Write("Ingrese el primer numero: ");
int numeroUno = int.Parse(Console.ReadLine());
System.Console.WriteLine();
System.Console.Write("Ingrese el segundo numero: ");
int numeroDos = int.Parse(Console.ReadLine());

try
{
    System.Console.WriteLine();
    System.Console.WriteLine($"{numeroUno} / {numeroDos} = " + numeroUno / numeroDos);

}
catch (Exception ex)
{
    var msg = "Error message: " + ex.Message;
    System.Console.WriteLine(msg);
}

