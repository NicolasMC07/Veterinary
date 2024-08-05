using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaC_sharp_NicolasMartinezCardona.Models;

public class Cat : Animal
{
    public bool BreedingStatus { get; set; }

    public string FurLength { get; set; } 

    public Cat(int id, string name, DateOnly birthdate, string breed, string color, double weightInKg, bool breedingStatus, string furLength) : base( id,  name,  birthdate,  breed,  color,  weightInKg)
    {
        BreedingStatus = breedingStatus;
        FurLength = furLength;
    }

    public void CastrateAnimal()
    {

    }

    public void Hairdress()
    {
        
    }
}
