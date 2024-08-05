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

    public static List<Dog>? Dogs { get; set; } = new List<Dog>();

    public static List<Cat>? Cats { get; set; } = new List<Cat>();

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
        var dogToUpdate = VeterinaryClinic.Dogs.FirstOrDefault(d => d.Equals(dog));

        if (dogToUpdate != null)
        {
            Console.WriteLine("Ingresa el nombre: ");
            dogToUpdate.Name = Console.ReadLine();
            Console.WriteLine("Ingresa la fecha de nacimiento del perro: ");
            dogToUpdate.Birthdate = DateOnly.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa la raza del perro: ");
            dogToUpdate.Breed = Console.ReadLine();
            Console.WriteLine("Ingresa el color del perro: ");
            dogToUpdate.Color = Console.ReadLine();
            Console.WriteLine("Ingresa el peso del perro: ");
            dogToUpdate.WeightInKg = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingresa el estado de apareamiento del perro (true o false): ");
            dogToUpdate.BreedingStatus = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("Ingresa el temperamento del perro: ");
            dogToUpdate.Temperament = Console.ReadLine();
            Console.WriteLine("Ingresa el numero del microchip: ");
            dogToUpdate.MicrochipNumber = Console.ReadLine();
            Console.WriteLine("Ingresa el tipo de volumen del ladrido del perro: ");
            dogToUpdate.BarkVolume = Console.ReadLine();
            Console.WriteLine("Ingresa tipo de pelo del perro: ");
            dogToUpdate.CoatType = Console.ReadLine();
        }
        else
        {
            Console.WriteLine("Perro no encontrado...");
        }
    }

    public void UpdateCat(Cat cat)
    {
        var catToUpdate = VeterinaryClinic.Cats.FirstOrDefault(c => c.Equals(cat));

        if (catToUpdate != null)
        {
            Console.WriteLine("Ingresa el nombre: ");
            catToUpdate.Name = Console.ReadLine();
            Console.WriteLine("Ingresa la fecha de nacimiento del perro: ");
            catToUpdate.Birthdate = DateOnly.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa la raza del perro: ");
            catToUpdate.Breed = Console.ReadLine();
            Console.WriteLine("Ingresa el color del perro: ");
            catToUpdate.Color = Console.ReadLine();
            Console.WriteLine("Ingresa el peso del perro: ");
            catToUpdate.WeightInKg = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingresa el estado de apareamiento del perro (true o false): ");
            catToUpdate.BreedingStatus = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("Ingresa tipo de pelo del perro: ");
            catToUpdate.FurLength = Console.ReadLine();
        }
        else
        {
            Console.WriteLine("Gato no encontrado...");
        }
    }

    public void DeleteDog(int id)
    {
        Console.WriteLine("Ingresa el id del perro a eliminar");
        var dog = Console.ReadLine();
        var dogToDelete = Dogs.FirstOrDefault(d => d.Id.Equals(dog));
        Dogs.Remove(dogToDelete);
    }

    public void DeleteCat(int id)
    {
        Console.WriteLine("Ingresa el id del gato a eliminar");
        var cat = Console.ReadLine();
        var catToDelete = Cats.FirstOrDefault(c => c.Id.Equals(cat));
        Cats.Remove(catToDelete);
    }

    public void ShowAllPatients()
    {
        ManagerApp.ShowHeader();
        ManagerApp.ShowSeparator();
        foreach (var dog in Dogs)
        {
            dog.ShowInformation();
        }

        foreach (var cat in Cats)
        {
            cat.ShowInformation();
        }
        ManagerApp.ShowFooter();
    }

    public void ShowAnimals(string type)
    {
        if (type == "Gato")
        {
            ManagerApp.ShowHeader();
            ManagerApp.ShowSeparator();
            foreach (var cat in Cats)
            {
                cat.ShowInformation();
            }
            ManagerApp.ShowFooter();
        }
        else if (type == "Perro")
        {
            ManagerApp.ShowHeader();
            ManagerApp.ShowSeparator();
            foreach (var dog in Dogs)
            {
                dog.ShowInformation();
            }
            ManagerApp.ShowFooter();
        }
    }

    public void ShowPatients(string name)
    {
        
    }

}
