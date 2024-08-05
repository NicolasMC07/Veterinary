using System;
using System.Collections.Generic;
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

    }

    public void Hairdress()
    {
        
    }

    public override void ShowInformation()
    {   
        foreach (var cat in VeterinaryClinic.Cats)
        {
            Console.WriteLine($"{Name} | {Birthdate,-14} | {Color,-15} | {WeightInKg, -16}");
        }
    }
}
