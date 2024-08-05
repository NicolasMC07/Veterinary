using PruebaC_sharp_NicolasMartinezCardona.Models;
// se instancian Gatos
VeterinaryClinic.SaveCat(new Cat(2, "kira", new DateOnly(2018, 04, 12), "Persa",  "Blanco", 18.0, false, "Pelo corto"));

// se instancian Gatos
VeterinaryClinic.SaveDog(new Dog(1, "Luna", new DateOnly(2018, 05, 13), "Pug", "Gris", 10.0, true, "Timido", "A1", "Medio", "Pelo corto"));



void ShowMenu()
{   
    Console.Clear();
    string op = "0";
    do
    {
        Console.WriteLine(
    $@"###########################################
#         Veterinary Center               #
###########################################
1. Agregar un animal
2. actualizar un animal
3. eliminar un animal
4. 
5. 
6. 
7. 
8. Salir
-----------------------------------------------------------------------------------------------
Selecciona una opcion --> ");

        op = Console.ReadLine();
        switch (op)
        {
            case "1":
                AddAnimal();
                break;
            case "2":
                UpdateAnimal();
                break;
            case "3":
                
                break;
            case "4":
                break;
            case "5":
                break;
            case "6":
                break;
            case "8":
                Console.WriteLine("Saliendo del programa...");
                Console.WriteLine("Gracias por usar la biblioteca.");
                break;
        }
        Console.WriteLine("Presiona cualquier tecla para continuar...");
        Console.ReadKey();
        Console.Clear();

    } while (op != "8");
}

// void ShowDogs()
// {   
//     Console.Clear();
//     ManagerApp.ShowHeader();
//     ManagerApp.ShowSeparator();
//     foreach (var dog in VeterinaryClinic.Dogs)
//     {
//         dog.ShowInformation();
//     }
//     ManagerApp.ShowFooter();
// }

// void ShowCats()
// {
//     Console.Clear();
//     ManagerApp.ShowHeader();
//     ManagerApp.ShowSeparator();
//     foreach (var cat in VeterinaryClinic.Cats)
//     {
//         cat
//     }
//     ManagerApp.ShowFooter();
// }

ShowMenu();

void AddAnimal()
{
    Console.WriteLine("Escribe que quieres agregar (Perro/Gato): ");
    var animal = Console.ReadLine().ToUpper();
    if (animal == "PERRO")
    {
        var newDog = ManagerApp.CreateDog();
        VeterinaryClinic.SaveDog(newDog);
    }
    else if (animal == "GATO")
    {   
        var newCat = ManagerApp.CreateCat();
        VeterinaryClinic.SaveCat(newCat);
        
    }
    else
    {
        Console.WriteLine("TIPO DE ANIMAL NO ENCONTRADO");
    }
}

void UpdateAnimal()
{
    Console.WriteLine("Escribe que quieres Actualizar (Perro/Gato): ");
    var animal = Console.ReadLine().ToUpper();
    if (animal == "PERRO")
    {   
        Console.WriteLine("Ingrese el nombre del perro a actualizar");
        var dog = Console.ReadLine();
        var dogToUpdate = VeterinaryClinic.Dogs.FirstOrDefault(d => d.Name == dog);
        if (dogToUpdate != null)
        {
            VeterinaryClinic.UpdateDog(dogToUpdate);
            Console.WriteLine("Perro actualizado correctamente");
        }
        else
        {
            Console.WriteLine("PERRO no encontrado");
        }
    }
    else if (animal == "GATO")
    {
        Console.WriteLine("Ingrese el nombre del gato a actualizar");
        var cat = Console.ReadLine();
        var catToUpdate = VeterinaryClinic.Cats.FirstOrDefault(d => d.Name == cat);
        if (catToUpdate != null)
        {
            VeterinaryClinic.UpdateCat(catToUpdate);
            Console.WriteLine("gato actualizado correctamente");
        }
        else
        {
            Console.WriteLine("GATO no encontrado");
        }
    }
    else
    {
        Console.WriteLine("TIPO DE ANIMAL NO ENCONTRADO");
    }
}