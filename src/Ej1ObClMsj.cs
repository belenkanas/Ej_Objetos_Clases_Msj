﻿using System;
namespace DefaultNamespace;

public class Circulo
{
    private double radio { get; set; };

    public Circulo(double radio)
    {
        this.Radio = radio;
    }
    public double GetPerimeter()
    {
        double perimetro = Math.Pi * this.Radio * 2
        return perimetro
    }
    
    public double GetArea()
    {
        double area = Math.Pow(this.Radio, 2.0) * Math.Pi
        return area
    }
}

class Program
{
    static void Main(string[] args)
    {
        Circulo Uno = new Circulo(2.0)
        Uno.GetPerimeter();
        Uno.GetArea();

    }
}