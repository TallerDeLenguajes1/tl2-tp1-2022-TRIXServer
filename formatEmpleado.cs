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
}