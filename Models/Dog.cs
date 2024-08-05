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
        Console.WriteLine("ingresa el Nombre del perro a castrar");
        var dog = Console.ReadLine();

        var dogToCastrate = VeterinaryClinic.Dogs.FirstOrDefault(c => c.Name == dog);

        if (dogToCastrate != null) 
        {
            if (dogToCastrate.BreedingStatus == true)
            {
                Console.WriteLine("El perro puede será castrado");
            }
            else
            {
                Console.WriteLine("El perro no puede ser castrado");
            }
        }
        else
        {
            Console.WriteLine("Perro no encontrado");
        }

    }

    public void Hairdress()
    {
        Console.WriteLine("ingresa el Nombre del perro a motilar");
        var dog = Console.ReadLine();

        var dogToHairdress = VeterinaryClinic.Cats.FirstOrDefault(c => c.Name == dog);

        if (dogToHairdress != null) 
        {
            if (dogToHairdress.FurLength == "Pelo corto")
            {
                Console.WriteLine("El perro no puede ser motilado");
            }
            else
            {
                Console.WriteLine("El perro será motilado");
            }
        }
        else
        {
            Console.WriteLine("perro no encontrado");
        }
    }

    public override void ShowInformation()
    {   
        Console.WriteLine($"{Name} | {Birthdate,-14} | {Color,-15} | {WeightInKg, -16}Kg");
    }
}
