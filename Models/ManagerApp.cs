using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaC_sharp_NicolasMartinezCardona.Models;
public static class ManagerApp
{   
    // metodos de static de la clase static ManagerApp
    public static Dog CreateDog()
    {
        Console.WriteLine("Ingresa el id del perro: ");
        int id = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ingresa el nombre del perro: ");
        var name = Console.ReadLine();
        Console.WriteLine("Ingresa la fecha de nacimiento del perro: ");
        DateOnly birthDate = DateOnly.Parse(Console.ReadLine());
        Console.WriteLine("Ingresa la raza del perro: ");
        var breed = Console.ReadLine();
        Console.WriteLine("Ingresa el color del perro: ");
        var color = Console.ReadLine();
        Console.WriteLine("Ingresa el peso del perro: ");
        double weightInKg = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Ingresa el estado de apareamiento del perro (true o false): ");
        bool breedingStatus = Convert.ToBoolean(Console.ReadLine());
        Console.WriteLine("Ingresa el temperamento del perro: ");
        var temperament = Console.ReadLine();
        Console.WriteLine("Ingresa el numero del microchip: ");
        var microchipNumber = Console.ReadLine();
        Console.WriteLine("Ingresa el tipo de volumen del ladrido del perro: ");
        var barkVolume = Console.ReadLine();
        Console.WriteLine("Ingresa tipo de pelo del perro: ");
        var coatType = Console.ReadLine();
        var newDog = new Dog(id,name,birthDate,breed,color,weightInKg,breedingStatus,temperament,microchipNumber,barkVolume,coatType);
        return newDog;
    }

    public static Cat CreateCat()
    {
        Console.WriteLine("Ingresa el id del gato: ");
        int id = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ingresa el nombre del gato: ");
        var name = Console.ReadLine();
        Console.WriteLine("Ingresa la fecha de nacimiento del gato: ");
        DateOnly birthDate = DateOnly.Parse(Console.ReadLine());
        Console.WriteLine("Ingresa la raza del gato: ");
        var breed = Console.ReadLine();
        Console.WriteLine("Ingresa el color del gato: ");
        var color = Console.ReadLine();
        Console.WriteLine("Ingresa el peso del gato: ");
        double weightInKg = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Ingresa el estado de apareamiento del gato (true o false): ");
        bool breedingStatus = Convert.ToBoolean(Console.ReadLine());
        Console.WriteLine("Ingresa el tipo de pelo del gato: ");
        var furLength = Console.ReadLine();
        var newCat = new Cat(id,name,birthDate,breed,color,weightInKg,breedingStatus,furLength);
        return newCat;
    }

    public static void ShowHeader()
    {
        Console.WriteLine(@$"###########################################
#                Animales                 #
###########################################
Nombre    | Nacimiento | Color | Peso Kg ");
    }

    public static void ShowFooter()
    {
        Console.WriteLine(@$"###########################################");
    }

    public static void ShowSeparator()
    {
        Console.WriteLine(@$"-------------------------------------------");
    }

}
