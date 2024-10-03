using System;
using System.Collections.Generic;

public abstract class Veiculo
{
    private string marca;
    private string modelo;
    private double velocidadeMaxima;

    public string Marca
    {
        get { return marca; }
        set { marca = value; }
    }

    public string Modelo
    {
        get { return modelo; }
        set { modelo = value; }
    }

    public double VelocidadeMaxima
    {
        get { return velocidadeMaxima; }
        set { velocidadeMaxima = value; }
    }

    public Veiculo(string marca, string modelo, double velocidadeMaxima)
    {
        this.marca = marca;
        this.modelo = modelo;
        this.velocidadeMaxima = velocidadeMaxima;
    }

    public abstract double CalcularConsumo();

    public virtual void ExibirInformacoes()
    {
        Console.WriteLine($"Marca: {Marca}, Modelo: {Modelo}, Velocidade Máxima: {VelocidadeMaxima} km/h");
    }
}

public class Carro : Veiculo
{
    public Carro(string marca, string modelo, double velocidadeMaxima) : base(marca, modelo, velocidadeMaxima) { }

    public override double CalcularConsumo()
    {
        return 12.0; 
    }

    public override void ExibirInformacoes()
    {
        base.ExibirInformacoes();
        Console.WriteLine($"Consumo: {CalcularConsumo()} km/l\n");
    }
}

public class Moto : Veiculo
{
    public Moto(string marca, string modelo, double velocidadeMaxima) : base(marca, modelo, velocidadeMaxima) { }

    public override double CalcularConsumo()
    {
        return 40.0; 
    }

    public override void ExibirInformacoes()
    {
        base.ExibirInformacoes();
        Console.WriteLine($"Consumo: {CalcularConsumo()} km/l\n");
    }
}

public class Caminhao : Veiculo
{
    public Caminhao(string marca, string modelo, double velocidadeMaxima) : base(marca, modelo, velocidadeMaxima) { }

    public override double CalcularConsumo()
    {
        return 8.0; 
    }

    public override void ExibirInformacoes()
    {
        base.ExibirInformacoes();
        Console.WriteLine($"Consumo: {CalcularConsumo()} km/l\n");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        List<Veiculo> veiculos = new List<Veiculo>
        {
            new Carro("Toyota", "Corolla", 200),
            new Moto("Honda", "Hornet", 180),
            new Caminhao("Scania", "113", 160)
        };

        foreach (var veiculo in veiculos)
        {
            veiculo.ExibirInformacoes();
        }
    }
}
