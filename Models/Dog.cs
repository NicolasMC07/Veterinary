using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaC_sharp_NicolasMartinezCardona.Models;

public class Dog : Animal
{
    // peopiedades de la clase Dog
    public bool BreedingStatus { get; set; }

    public string Temperament { get; set; }

    public string MicrochipNumber { get; set; }

    public string BarkVolume { get; set; }
    
    public string CoatType { get; set; }

    //constructor de la clase Dog
    public Dog(int id, string name, DateOnly birthdate, string breed, string color, double weightInKg, bool breedingStatus, string temperament, string microchipNumber, string barkVolume, string coatType) : base ( id,  name,  birthdate,  breed,  color,  weightInKg)
    {   
        Id = id;
        BreedingStatus = breedingStatus;
        Temperament = temperament;
        MicrochipNumber = microchipNumber;
        BarkVolume = barkVolume;
        CoatType = coatType;
    }

    //metodos de la clase Dog

    public void CastrateAnimal()
    {
        Console.WriteLine("Ingrese el id del perro a castar: ");
        int dog = Convert.ToInt32(Console.ReadLine());
        //validar si el dog ya ha sido castrado
        


    }

    public void Hairdress()
    {
        
    }

    public override void ShowInformation()
    {   
        Console.WriteLine($"{Name} | {Birthdate,-14} | {Color,-15} | {WeightInKg, -16}Kg");
    }
}
