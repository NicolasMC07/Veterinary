using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaC_sharp_NicolasMartinezCardona.Models;

public class VeterinaryClinic
{   
    // propiedades de la clase VeterinaryClinic
    public string? Name { get; set; }

    public string? Address { get; set; }

    public static List<Dog>? Dogs { get; set; }

    public static List<Cat>? Cats { get; set; } 

    // primer COnstructor de la clase VeterinaryClinic
    public VeterinaryClinic()
    {
        List<Dog> Dogs = new List<Dog>();
        List<Cat> Cats = new List<Cat>();
    }

    // segundo constructor de la clase VeterinaryClinic
    public VeterinaryClinic(string name, string address)
    {
        Name = name;
        Address = address;
    }

    //metodos de la clase VeterinaryClinic

    public static void SaveDog(Dog newDog)
    {
        VeterinaryClinic.Dogs.Add(newDog);
    }

    public static void SaveCat(Cat newCat)
    {
        VeterinaryClinic.Cats.Add(newCat);
    }

    public void UpdateDog(Dog dog)
    {

    }

    public void UpdateCat(Cat cat)
    {
        
    }

    public void DeleteDog(int id)
    {

    }

    public void DeleteCat(int id)
    {

    }

    public void ShowAllPatients()
    {

    }

    public void ShowAnimals(string type)
    {

    }

    public void ShowPatients(int idPatient)
    {

    }

}
