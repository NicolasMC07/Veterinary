using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaC_sharp_NicolasMartinezCardona.Models;

public class Cat : Animal
{
    //propiedades de la clase Cat
    public bool BreedingStatus { get; set; }

    public string FurLength { get; set; } 

    //Constructor de la clase Cat

    public Cat(int id, string name, DateOnly birthdate, string breed, string color, double weightInKg, bool breedingStatus, string furLength) : base( id,  name,  birthdate,  breed,  color,  weightInKg)
    {
        BreedingStatus = breedingStatus;
        FurLength = furLength;
    }

    // metods de la clase Cat
    public void CastrateAnimal()
    {   
        Console.WriteLine("ingresa el Nombre del gato a castrar");
        var cat = Console.ReadLine();

        var catToCastrate = VeterinaryClinic.Cats.FirstOrDefault(c => c.Name == cat);

        if (catToCastrate != null) 
        {
            if (catToCastrate.BreedingStatus == true)
            {
                Console.WriteLine("El gato puede será castrado");
            }
            else
            {
                Console.WriteLine("El gato no puede ser castrado");
            }
        }
        else
        {
            Console.WriteLine("Gato no encontrado");
        }
    }

    public void Hairdress()
    {
        Console.WriteLine("ingresa el Nombre del gato a motilar");
        var cat = Console.ReadLine();

        var catToHairdress = VeterinaryClinic.Cats.FirstOrDefault(c => c.Name == cat);

        if (catToHairdress != null) 
        {
            if (catToHairdress.FurLength == "Pelo corto")
            {
                Console.WriteLine("El gato no puede ser motilado");
            }
            else
            {
                Console.WriteLine("El gato será motilado");
            }
        }
        else
        {
            Console.WriteLine("Gato no encontrado");
        }
    }

    public override void ShowInformation()
    {   
        foreach (var cat in VeterinaryClinic.Cats)
        {
            Console.WriteLine($"{Name} | {Birthdate,-14} | {Color,-15} | {WeightInKg, -16}");
        }
    }
    
}
