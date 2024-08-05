using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaC_sharp_NicolasMartinezCardona.Models;

public abstract class Animal
{
    // propiedades de la clase Animal
    protected int id;
    public int Id
    {
        get { return id; }
        set { id = value; }
    }

    protected string name;
    public string Name
    {
        get { return name; }
        set { name = value; }
    }
    protected DateOnly birthdate;
    public DateOnly Birthdate
    {
        get { return birthdate; }
        set { birthdate = value; }
    }

    protected string breed;
    public string Breed
    {
        get { return breed; }
        set { breed = value; }
    }

    protected string color;
    public string Color
    {
        get { return color; }
        set { color = value; }
    }

    protected double weightInKg;
    public double WeightInKg
    {
        get { return weightInKg; }
        set { weightInKg = value; }
    }

    // Constructor de la clase Animal

    public Animal(int id, string name, DateOnly birthdate, string breed, string color, double weightInKg)
    {
        Id = id;
        Name = name;
        Birthdate = birthdate;
        Breed = breed;
        Color = color;
        WeightInKg = weightInKg;
    }

    //metodos de la clase Animal

    public abstract void ShowInformation();

    protected void BasicReview()
    {
        
    }

    protected void CalculateAgeInMonths()
    {   
        var birthdate = DateTime.Now.Month - Birthdate.Month;
        Console.WriteLine(birthdate);
    }

}
