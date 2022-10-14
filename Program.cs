using System.Net;
using System.Text.Json;

System.Console.Clear();
System.Console.WriteLine("--\tProvincias");
System.Console.WriteLine();

var functions = new functions();
rootProvincias provincias = new rootProvincias();
List<string> nombresProvincias = new List<string>();

provincias = functions.ApiProvincias(provincias);

Console.WriteLine("Provincias argentinas y sus id: ");
foreach (var item in provincias.provincias)
{   
    nombresProvincias.Add(item.nombre);
    Console.WriteLine(item.nombre + " - " + item.id);
}

