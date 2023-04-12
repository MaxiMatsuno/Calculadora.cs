using System;

class Calculadora
{
    static void Main()
    {
        Console.WriteLine("Ingrese el primer número:");
        double num1;

        // Verifica que se ingrese un número válido
        while (!double.TryParse(Console.ReadLine(), out num1))
        {
            Console.WriteLine("Por favor, ingrese un numero");
        }

        Console.WriteLine("Ingrese el segundo número:");
        double num2;

        // Verifica que se ingrese un número válido
        while (!double.TryParse(Console.ReadLine(), out num2))
        {
            Console.WriteLine("Por favor, ingrese un numero");
        }

        Console.WriteLine("Ingrese la operación a realizar (+, -, *, /):");
        char operacion;
        
        // Verifica que se ingrese un carácter válido
        while (!char.TryParse(Console.ReadLine(), out operacion))
        {
            Console.WriteLine("Debe ingresar un carácter válido (+, -, *, /)");
        }

        if (operacion == '+')
        {
            Console.WriteLine("El resultado de la suma es: " + (num1 + num2));
        }
        else if (operacion == '-')
        {
            Console.WriteLine("El resultado de la resta es: " + (num1 - num2));
        }
        else if (operacion == '*')
        {
            Console.WriteLine("El resultado de la multiplicación es: " + (num1 * num2));
        }
        else if (operacion == '/')
        {
            if (num2 == 0)
            {
                Console.WriteLine("No se puede dividir por cero");
            }
            else
            {
                Console.WriteLine("El resultado de la división es: " + (num1 / num2));
            }
        }
        else
        {
            Console.WriteLine("Operación no válida");
        }
    }
}