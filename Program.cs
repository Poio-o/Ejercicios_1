using System;

class Program
{
    static void Main(string[] args)
    {
        bool continuar = true;
        while (continuar)
        {
            Console.Clear();
            Console.WriteLine("=== MENÚ DE EJERCICIOS DE INTERFACES ===");
            Console.WriteLine("Introduce el número de ejercicio (1-10) o '0' para salir:");
            Console.Write("Opción: ");

            string entrada = Console.ReadLine();

            if (entrada == "0")
            {
                continuar = false;
                continue;
            }

            switch (entrada)
            {
                case "1": Ejercicio1(); break;
                case "2": Ejercicio2(); break;
                case "3": Ejercicio3(); break;
                case "4": Ejercicio4(); break;
                case "5": Ejercicio5(); break;
                case "6": Ejercicio6(); break;
                case "7": Ejercicio7(); break;
                case "8": Ejercicio8(); break;
                case "9": Ejercicio9(); break;
                case "10": Ejercicio10(); break;
                default:
                    Console.WriteLine("\nOpción no válida. Inténtalo de nuevo.");
                    break;
            }

            if (continuar)
            {
                Console.WriteLine("\nPresiona cualquier tecla para volver al menú...");
                Console.ReadKey();
            }
        }
    }

    // 1. Suma, resta, multiplicación y módulo de dos números
    static void Ejercicio1()
    {
        Console.Clear();
        Console.WriteLine("--- Ejercicio 1 ---");
        Console.Write("Introduce el primer número: ");
        double n1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Introduce el segundo número: ");
        double n2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine($"La suma es: {n1 + n2}");
        Console.WriteLine($"La resta es: {n1 - n2}");
        Console.WriteLine($"La multiplicación es: {n1 * n2}");
        Console.WriteLine($"La división es: {(n2 != 0 ? (n1 / n2).ToString() : "No válida (división por cero)")}");
        Console.WriteLine($"El módulo es: {(n2 != 0 ? (n1 % n2).ToString() : "No definido")}");
    }

    // 2. Calcular total en un bar con constantes
    static void Ejercicio2()
    {
        Console.Clear();
        Console.WriteLine("--- Ejercicio 2 ---");
        const double PRECIO_HAMBURGUESA = 4.50;
        const double PRECIO_PAPAS = 2.00;
        const double PRECIO_BEBIDA = 1.50;

        Console.Write("Cantidad de hamburguesas: ");
        int h = Convert.ToInt32(Console.ReadLine());
        Console.Write("Cantidad de papas: ");
        int p = Convert.ToInt32(Console.ReadLine());
        Console.Write("Cantidad de bebidas: ");
        int b = Convert.ToInt32(Console.ReadLine());

        double total = (h * PRECIO_HAMBURGUESA) + (p * PRECIO_PAPAS) + (b * PRECIO_BEBIDA);
        Console.WriteLine($"Cantidad a pagar: {total:F2}€"); 
    }

    // 3. Operaciones matemáticas avanzadas
    static void Ejercicio3()
    {
        Console.Clear();
        Console.WriteLine("--- Ejercicio 3 ---");
        Console.Write("Introduce un número: ");
        double num = Convert.ToDouble(Console.ReadLine());

        double numFijo = 10.0;

        Console.WriteLine($"Valor absoluto: {Math.Abs(num)}");
        Console.WriteLine($"Potencia al cubo: {Math.Pow(num, 3)}");
        Console.WriteLine($"Raíz cuadrada: {(num >= 0 ? Math.Sqrt(num).ToString() : "No real (número negativo)")}");
        Console.WriteLine($"Seno: {Math.Sin(num)}");
        Console.WriteLine($"Coseno: {Math.Cos(num)}");
        Console.WriteLine($"Número máximo (comparado con {numFijo}): {Math.Max(num, numFijo)}");
        Console.WriteLine($"Número mínimo (comparado con {numFijo}): {Math.Min(num, numFijo)}");
    }

    // 4. Perímetro de un cuadrado
    static void Ejercicio4()
    {
        Console.Clear();
        Console.WriteLine("--- Ejercicio 4 ---");
        Console.Write("Introduce el valor de un lado del cuadrado: ");
        double lado = Convert.ToDouble(Console.ReadLine());

        double perimetro = lado * 4;
        Console.WriteLine($"El perímetro del cuadrado es: {perimetro}");
    }

    // 5. Operaciones cruzadas con 4 números
    static void Ejercicio5()
    {
        Console.Clear();
        Console.WriteLine("--- Ejercicio 5 ---");
        Console.Write("Introduce el primer número: ");
        double n1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Introduce el segundo número: ");
        double n2 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Introduce el tercer número: ");
        double n3 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Introduce el cuarto número: ");
        double n4 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine($"Suma de los dos primeros ({n1} + {n2}): {n1 + n2}");
        Console.WriteLine($"Producto del tercero y el cuarto ({n3} * {n4}): {n3 * n4}");
    }

    // 6. Suma y promedio de 4 números
    static void Ejercicio6()
    {
        Console.Clear();
        Console.WriteLine("--- Ejercicio 6 ---");
        double suma = 0;
        for (int i = 1; i <= 4; i++)
        {
            Console.Write($"Introduce el valor numérico {i}: ");
            suma += Convert.ToDouble(Console.ReadLine());
        }

        double promedio = suma / 4;
        Console.WriteLine($"Suma total: {suma}");
        Console.WriteLine($"Promedio: {promedio}");
    }

    // 7. Coste total de artículos
    static void Ejercicio7()
    {
        Console.Clear();
        Console.WriteLine("--- Ejercicio 7 ---");
        Console.Write("Ingresa el precio del artículo: ");
        double precio = Convert.ToDouble(Console.ReadLine());
        Console.Write("Ingresa la cantidad que lleva el cliente: ");
        int cantidad = Convert.ToInt32(Console.ReadLine());

        double costeTotal = precio * cantidad;
        Console.WriteLine($"El coste total es: {costeTotal:F2}");
    }

    // 8. Nota final ponderada
    static void Ejercicio8()
    {
        Console.Clear();
        Console.WriteLine("--- Ejercicio 8 ---");
        Console.Write("Nota parcial 1: ");
        double p1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Nota parcial 2: ");
        double p2 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Nota del examen: ");
        double examen = Convert.ToDouble(Console.ReadLine());
        Console.Write("Nota del trabajo final: ");
        double trabajo = Convert.ToDouble(Console.ReadLine());

        double promedioParciales = (p1 + p2) / 2;
        double notaFinal = (promedioParciales * 0.50) + (examen * 0.30) + (trabajo * 0.20);

        Console.WriteLine($"Tu nota final en 'Desarrollo de Interfaces' es: {notaFinal:F2}");
    }

    // 9. Porcentaje de participación de socios
    static void Ejercicio9()
    {
        Console.Clear();
        Console.WriteLine("--- Ejercicio 9 ---");
        Console.Write("Aportación del Socio 1: ");
        double s1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Aportación del Socio 2: ");
        double s2 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Aportación del Socio 3: ");
        double s3 = Convert.ToDouble(Console.ReadLine());

        double totalCapital = s1 + s2 + s3;

        if (totalCapital > 0)
        {
            double porc1 = (s1 / totalCapital) * 100;
            double porc2 = (s2 / totalCapital) * 100;
            double porc3 = (s3 / totalCapital) * 100;

            Console.WriteLine($"El porcentaje del socio 1 es {porc1:F0}%, del socio 2 es {porc2:F0}% y del socio 3 es {porc3:F0}%");
        }
        else
        {
            Console.WriteLine("El capital total aportado no puede ser 0.");
        }
    }

    // 10. Comprobar si un string empieza por "www"
    static void Ejercicio10()
    {
        Console.Clear();
        Console.WriteLine("--- Ejercicio 10 ---");
        Console.Write("Introduce una cadena de texto: ");
        string texto = Console.ReadLine();

        bool empiezaPorWww = texto.StartsWith("www");

        Console.WriteLine($"Resultado: {empiezaPorWww.ToString().ToLower()}");
    }
}
