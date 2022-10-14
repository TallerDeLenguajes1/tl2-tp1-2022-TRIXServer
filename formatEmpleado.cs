public class Empleado
{
    private string nombre;
    private long dni;
    private DateTime fechaNacimiento;
    private DateTime fechaIngreso;
    private string domicilio;
    private double sueldoBasico;
    private double salario;

    private bool casado;
    private int hijos;
    private bool divorciado;
    private DateTime fechaDivorcio;
    private bool tituloUniversitario;
    private string titulo;
    private string universidad;

    public string Nombre { get => nombre; set => nombre = value; }
    public long Dni { get => dni; set => dni = value; }
    public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
    public DateTime FechaIngreso { get => fechaIngreso; set => fechaIngreso = value; }
    public string Domicilio { get => domicilio; set => domicilio = value; }
    public double SueldoBasico { get => sueldoBasico; set => sueldoBasico = value; }
    public double Salario { get => salario; set => salario = value; }
    public bool Casado { get => casado; set => casado = value; }
    public int Hijos { get => hijos; set => hijos = value; }
    public bool Divorciado { get => divorciado; set => divorciado = value; }
    public DateTime FechaDivorcio { get => fechaDivorcio; set => fechaDivorcio = value; }
    public bool TituloUniversitario { get => tituloUniversitario; set => tituloUniversitario = value; }
    public string Titulo { get => titulo; set => titulo = value; }
    public string Universidad { get => universidad; set => universidad = value; }

    public Empleado()
    {
        Random random = new Random();
        Nombre = nombreAleatorio();
        Dni = random.Next(1000000, 60000000);
        FechaNacimiento = fechaAleatoria(); 
        FechaIngreso = fechaAleatoria(FechaNacimiento.Year + 18, fechaActual.Year);
        Domicilio = "Domicilio Actual";
        SueldoBasico = random.Next(20000, 100000);
        Salario = calcularSalario(); 
        Casado = Convert.ToBoolean(random.Next(0, 2));
        Hijos = random.Next(0, 5);

        if (Casado == false)
        {
            Divorciado = false;
            FechaDivorcio = new DateTime(9999, 9, 9);

        }
        else
        {
            Divorciado = Convert.ToBoolean(random.Next(0, 2));
            FechaDivorcio = fechaAleatoria(FechaNacimiento.Year + 20, fechaActual.Year);
        
        }
        
        TituloUniversitario = Convert.ToBoolean(random.Next(0, 2));

        if (TituloUniversitario == true)
        {
            Titulo = "Titulo";
            Universidad = "UNT";

        }
        else
        {
            Titulo = "Sin titulo";
            Universidad = "-";

        }
        
    }

    private DateTime fechaActual = DateTime.Today;

    public int calcularEdad()
    {
        int edad = 0;
        edad = fechaActual.Year - FechaNacimiento.Year;
        if (FechaNacimiento.Month > fechaActual.Month)
        {
            edad = edad - 1;
        
        }
        return edad;
    
    }
    
    public string nombreAleatorio()
    { 
        Random random = new Random();
        string[] nombres = { "Noelia ", "Patricio ", "Lisandro ", "Idelfonso ", "Rufina ", "Ines ", "Neftali "};
        string[] apellidos = { "Rojas", "Salazar", "Tannure", "Godward", "Brest"};
        
        string nombreCompleto = "";
        
        nombreCompleto = nombres[random.Next(0, nombres.Length - 1)];
        nombreCompleto += apellidos[random.Next(0, apellidos.Length - 1)];

        return nombreCompleto;

    }

    public int calcularAntiguedad()
    {
        int antiguedad = 0;
        antiguedad = fechaActual.Year - FechaIngreso.Year;
        if (FechaIngreso.Month > fechaActual.Month)
        {
            antiguedad = antiguedad - 1;

        }
        return antiguedad;

    }
    public double calcularSalario()
    {
        return SueldoBasico + calcularAdicional() - calcularDescuento();

    }
    private double calcularDescuento()
    {
        return 0.15 * SueldoBasico;

    }
    private double calcularAdicional()
    {
        if (calcularAntiguedad() < 20)
        {
            return 0.01 * SueldoBasico * calcularAntiguedad();

        }
        else
        {
            return 0.25 * SueldoBasico;
        
        }
    }

    public void mostrarUnEmpleado(Empleado dataEmpleado)
    {
        Console.WriteLine("\n--------DATOS DEL EMPLEADO--------");
        Console.WriteLine($"Nombre: {dataEmpleado.Nombre}");
        Console.WriteLine($"Edad: {dataEmpleado.calcularEdad()}");
        Console.WriteLine($"Antiguedad: {dataEmpleado.calcularAntiguedad()}");
        Console.WriteLine($"Salario: {dataEmpleado.Salario}");

    }

    public void mostrarInfoAdicional(Empleado dataEmpleado)
    {
        Console.WriteLine("\n--------MAS INFORMACION--------");
        Console.WriteLine($"Es casado: {dataEmpleado.Casado}");
        Console.WriteLine($"Cantidad de hijos: {dataEmpleado.Hijos}");
        Console.WriteLine($"Es divorciado: {dataEmpleado.Divorciado}");
        
        if(Divorciado == true)
        {
            Console.WriteLine($"Fecha divorcio: {dataEmpleado.fechaDivorcio}");
        
        }
        
        Console.WriteLine($"Tiene titulo universitario: {dataEmpleado.TituloUniversitario}");
        
        if (TituloUniversitario == true)
        {
            Console.WriteLine($"Titulo: {dataEmpleado.titulo}");
            Console.WriteLine($"Universidad: {dataEmpleado.universidad}");
        
        }
    }


    public DateTime fechaAleatoria(int anioInicio = 1930, int anioFin = 2005)
    {
        DateTime start = new DateTime(anioInicio, 1, 1); 
        DateTime end = new DateTime(anioFin, 1, 1); 
        Random gen = new Random(); 

        try
        {
            int range = (end - start).Days; 
            return start.AddDays(gen.Next(range)); 
        
        }
        catch(Exception ex)
        {
            Console.WriteLine("Error message: " + ex.Message);
            Console.WriteLine("Fecha actual por defecto");
            return DateTime.Today;
        
        }
    }
    
}