using System;


public class Calculadora
{
  
    public string Marca { get; set; }
    public string Serie { get; set; }

    
    public Calculadora(string marca, string serie)
    {
        Marca = marca;
        Serie = serie;
    }

    
    public double Sumar(double a, double b)
    {
        return a + b;
    }

    public double Restar(double a, double b)
    {
        return a - b;
    }

    public double Multiplicar(double a, double b)
    {
        return a * b;
    }

    public double Dividir(double a, double b)
    {
        if (b != 0)
        {
            return a / b;
        }
        else
        {
            Console.WriteLine("Error: División por cero.");
            return double.NaN;
        }
    }
}


public class CalculadoraCientifica : Calculadora
{
    
    public CalculadoraCientifica(string marca, string serie) : base(marca, serie)
    {
    }

    
    public double Potencia(double baseNum, double exponente)
    {
        return Math.Pow(baseNum, exponente);
    }

    public double Raiz(double numero)
    {
        return Math.Sqrt(numero);
    }

    public double Modulo(double a, double b)
    {
        return a % b;
    }

    public double Logaritmo(double numero, double baseLog)
    {
        return Math.Log(numero, baseLog);
    }
}

class Program
{
    static void Main(string[] args)
    {
        var calculadoraBasica = new Calculadora("Casio", "1234");
        var calculadoraCientifica = new CalculadoraCientifica("HP", "5678");
        Console.WriteLine("casio, 1234");
        Console.WriteLine("HP, 5678");

        
        Console.WriteLine($"Suma: {calculadoraBasica.Sumar(5, 3)}");
        Console.WriteLine($"Resta: {calculadoraBasica.Restar(5, 3)}");
        Console.WriteLine($"Multiplicación: {calculadoraBasica.Multiplicar(5, 3)}");
        Console.WriteLine($"División: {calculadoraBasica.Dividir(5, 3)}");

        
        Console.WriteLine($"Potencia: {calculadoraCientifica.Potencia(2, 3)}");
        Console.WriteLine($"Raíz cuadrada: {calculadoraCientifica.Raiz(16)}");
        Console.WriteLine($"Módulo: {calculadoraCientifica.Modulo(5, 3)}");
        Console.WriteLine($"Logaritmo: {calculadoraCientifica.Logaritmo(100, 10)}");
    }
}