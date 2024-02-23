class Program_1
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese el primer número:");
        double numero1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Ingrese el segundo número:");
        double numero2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Ingrese el tercer número:");
        double numero3 = Convert.ToDouble(Console.ReadLine());

        double mayor = numero1;

        if (numero2 > mayor)
        {
            mayor = numero2;
        }

        if (numero3 > mayor)
        {
            mayor = numero3;
        }

        Console.WriteLine("El mayor de los tres números es: {mayor}");
    }
}
class Program_2
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese su edad:");
        int edad = Convert.ToInt32(Console.ReadLine());

        if (edad >= 18)
        {
            Console.WriteLine("¡Bienvenido al club!");
        }
        else
        {
            Console.WriteLine("Lo siento, debes tener al menos 18 años para ingresar al club.");
        }
    }
}
class Program_3
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese el precio original del producto:");
        double precioOriginal = Convert.ToDouble(Console.ReadLine());

        double descuento = 0;

        if (precioOriginal > 100)
        {
            descuento = precioOriginal * 0.10;
        }

        double precioFinal = precioOriginal - descuento;

        Console.WriteLine("El precio final del producto es: Q{precioFinal}");
    }
}
class Program_4
{
    static void Main(string[] args)
    {
        string nombreUsuarioValido = "usuario";
        string contraseñaValida = "contraseña";

        Console.WriteLine("Ingrese su nombre de usuario:");
        string nombreUsuario = Console.ReadLine();

        Console.WriteLine("Ingrese su contraseña:");
        string contraseña = Console.ReadLine();

        if (nombreUsuario == nombreUsuarioValido && contraseña == contraseñaValida)
        {
            Console.WriteLine("Acceso concedido. Bienvenido.");
        }
        else
        {
            Console.WriteLine("Credenciales incorrectas. Acceso denegado.");
        }
    }
}
class Program_5
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese un número:");
        int numero = Convert.ToInt32(Console.ReadLine());

        if (numero % 2 == 0)
        {
            Console.WriteLine("El número {numero} es par.");
        }
        else
        {
            Console.WriteLine("El número {numero} es impar.");
        }
    }
}
class Program_6
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese el monto del préstamo:");
        double montoPrestamo = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Ingrese su edad:");
        int edad = Convert.ToInt32(Console.ReadLine());

        if (montoPrestamo < 5000 || edad > 60)
        {
            Console.WriteLine("¡Felicidades! Su préstamo ha sido aprobado.");
        }
        else
        {
            Console.WriteLine("Lo siento, su solicitud de préstamo ha sido rechazada.");
        }
    }
}
class Program_7
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese el tipo de figura geométrica (triangulo, cuadrado o circulo):");
        string tipoFigura = Console.ReadLine().ToLower();

        double area = 0;

        switch (tipoFigura)
        {
            case "triangulo":
                Console.WriteLine("Ingrese la base del triángulo:");
                double baseTriangulo = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Ingrese la altura del triángulo:");
                double alturaTriangulo = Convert.ToDouble(Console.ReadLine());

                area = 0.5 * baseTriangulo * alturaTriangulo;
                break;

            case "cuadrado":
                Console.WriteLine("Ingrese el lado del cuadrado:");
                double ladoCuadrado = Convert.ToDouble(Console.ReadLine());

                area = ladoCuadrado * ladoCuadrado;
                break;

            case "circulo":
                Console.WriteLine("Ingrese el radio del círculo:");
                double radioCirculo = Convert.ToDouble(Console.ReadLine());

                area = Math.PI * Math.Pow(radioCirculo, 2);
                break;

        }

        Console.WriteLine("El área de la figura {tipoFigura} es: {area}");
    }
}



class Program_switch1
{
    static void Main(string[] args)
    {
        Dictionary<string, int> numeros = new Dictionary<string, int>
        {
            {"uno", 1},
            {"dos", 2},
            {"tres", 3},
            {"cuatro", 4},
            {"cinco", 5}
        };

        Console.WriteLine("Ingrese un número del 1 al 5 en letra (uno, dos, tres, cuatro, cinco):");
        string numeroEnLetra = Console.ReadLine().ToLower(); 

        if (numeros.ContainsKey(numeroEnLetra))
        {
            int numeroEnNumero = numeros[numeroEnLetra];
            Console.WriteLine($"El número en dígito es: {numeroEnNumero}");
        }
        else
        {
            Console.WriteLine("Entrada inválida. Por favor ingrese una de las opciones válidas.");
        }
    }
}

class Program_switch2
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese un número del 1 al 7 para representar un día de la semana:");
        int numero = Convert.ToInt32(Console.ReadLine());

        string diaDeLaSemana = ObtenerDiaDeLaSemana(numero);

        if (diaDeLaSemana != null)
        {
            Console.WriteLine("El día correspondiente al número {numero} es {diaDeLaSemana}");
        }
        else
        {
            Console.WriteLine("Número de día de semana no válido.");
        }
    }

    static string ObtenerDiaDeLaSemana(int numero)
    {
        switch (numero)
        {
            case 1:
                return DayOfWeek.Monday.ToString();
            case 2:
                return DayOfWeek.Tuesday.ToString();
            case 3:
                return DayOfWeek.Wednesday.ToString();
            case 4:
                return DayOfWeek.Thursday.ToString();
            case 5:
                return DayOfWeek.Friday.ToString();
            case 6:
                return DayOfWeek.Saturday.ToString();
            case 7:
                return DayOfWeek.Sunday.ToString();
            default:
                return null;
        }
    }
}

class Program_switch3
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese el tipo de servicio (lavado de auto, cambio de aceite, revisión mecánica):");
        string tipoServicio = Console.ReadLine().ToLower(); 

        double importe = CalcularImporte(tipoServicio);

        if (importe != -1)
        {
            Console.WriteLine($"El importe a pagar por {tipoServicio} es: {importe:C}");
        }
        else
        {
            Console.WriteLine("Tipo de servicio no válido.");
        }
    }

    static double CalcularImporte(string tipoServicio)
    {
        switch (tipoServicio)
        {
            case "lavado de auto":
                return 50.00;
            case "cambio de aceite":
                return 100.00;
            case "revisión mecánica":
                return 150.00;
            default:
                return -1; // Indica que el tipo de servicio no es válido
        }
    }
}

class Program_switch4
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese el tipo de servicio (lavado de auto, cambio de aceite, revisión mecánica):");
        string tipoServicio = Console.ReadLine().ToLower();

        double importe = CalcularImporte(tipoServicio);

        if (importe != -1)
        {
            Console.WriteLine("El importe a pagar por {tipoServicio} es: {importe:C}");
        }
        else
        {
            Console.WriteLine("Tipo de servicio no válido.");
        }
    }

    static double CalcularImporte(string tipoServicio)
    {
        switch (tipoServicio)
        {
            case "lavado de auto":
                return 50.00;
            case "cambio de aceite":
                return 100.00;
            case "revisión mecánica":
                return 150.00;
            default:
                return -1; 
        }
    }
}

class Program_switch5
{
    static void Main(string[] args)
    {
        Console.WriteLine("Seleccione su idioma preferido (español, inglés, francés):");
        string idioma = Console.ReadLine().ToLower(); 

        string mensajeBienvenida = ObtenerMensajeBienvenida(idioma);

        if (mensajeBienvenida != null)
        {
            Console.WriteLine(mensajeBienvenida);
        }
        else
        {
            Console.WriteLine("Idioma no válido.");
        }
    }

    static string ObtenerMensajeBienvenida(string idioma)
    {
        switch (idioma)
        {
            case "español":
                return "¡Bienvenido!";
            case "inglés":
                return "Welcome!";
            case "francés":
                return "Bienvenue!";
            default:
                return null;
        }
    }
}

class Program_switch6
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese la calificación del examen:");
        int calificacion = Convert.ToInt32(Console.ReadLine());

        string desempeno = EvaluarDesempeno(calificacion);

        if (desempeno != null)
        {
            Console.WriteLine("Desempeño del estudiante: {desempeno}");
        }
        else
        {
            Console.WriteLine("Calificación no válida. Debe estar entre 0 y 100.");
        }
    }

    static string EvaluarDesempeno(int calificacion)
    {
        switch (calificacion)
        {
            case int n when (n >= 90 && n <= 100):
                return "Sobresaliente";
            case int n when (n >= 80 && n <= 89):
                return "Notable";
            case int n when (n >= 70 && n <= 79):
                return "Aprobatoria";
            case int n when (n >= 60 && n <= 69):
                return "No aprobatoria";
            default:
                return null;
        }
    }
}