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
1. Listar todos los clientes registrados 
2. Listar todos los conductores registrados
3. Filtrar libro por Genero
4. Filtrar libro por Autor
5. Filtrar libro por rango de fecha especifico
6. Añadir nuevo libro
7. Eliminar un libro
8. Salir
-----------------------------------------------------------------------------------------------
Selecciona una opcion --> ");

        op = Console.ReadLine();
        switch (op)
        {
            case "1":
                VeterinaryClinic.
                break;
            case "2":
                
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

void CreateCat()
{
    ManagerApp.CreateCat();
    
}

ShowMenu();
