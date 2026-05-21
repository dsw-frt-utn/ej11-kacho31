using Dsw2026Ej11.Collections;
using Dsw2026Ej11.Domain;
using System.Security.Cryptography.X509Certificates;

namespace Dsw2026Ej11.Tests;


internal class Ejemplos
{
    //Agregar 3 alumnos a la lista
    //Listar por consola los alumnos
    //Buscar por nombre un alumno que exista y mostrar por consola
    //Buscar por nombre un alumno que no exista y mostrar por consola el texto "No existe"
    //Eliminar un alumno y listar por consola los alumnos
    //Eliminar el primer elemento de la lista y listar por consola los alumnos
    public static void EjemploList()
    {
        CasoList lista = new CasoList();

        //Agregar 3 alumnos
        Alumno alumno1 = new Alumno(1, "Juan", 8.5);
        Alumno alumno2 = new Alumno(2, "Maria", 9.0);
        Alumno alumno3 = new Alumno(3, "Pedro", 7.5);

        lista.AgregarAlumno(alumno1);
        lista.AgregarAlumno(alumno2);
        lista.AgregarAlumno(alumno3);

        //Listar alumnos por consola
        Console.WriteLine("lISTA DE ALUMNOS");
        foreach (Alumno a in lista.ObtenerAlumnos())
        {
            Console.WriteLine(a);
        }

        //Buscar un alumno que no exista
        Console.WriteLine("\n BUSCAR ALUMNO INEXISTENTE");
        Alumno? noEncontrado = lista.BuscarPorNombre("Carlos");
        if (noEncontrado == null)
            Console.WriteLine("Ese alumno no existe");
        else
            Console.WriteLine(noEncontrado);

        //Eliminar un alumno y listar
        Console.WriteLine("\n ELIMINAR alumno2 (Maria)");
        lista.EliminarAlmuno(alumno2);
        foreach (Alumno a in lista.ObtenerAlumnos())
        {
            Console.WriteLine(a);
        }

        //Eliminar el primer elemento y listar
        Console.WriteLine("\n ELIMINAR PRIMER ELEMENTO");
        lista.EliminarEnPosicion(0);
        foreach (Alumno a in lista.ObtenerAlumnos())
        {
            Console.WriteLine(a);
        }

    }

    //Agregar 3 alumnos al diccionario
    //Listar por consola los alumnos
    //Buscar un alumno por clave y mostrar por consola
    //Buscar un alumno por clave, pero que no exista, y mostrar por consola el texto "No existe"
    //Eliminar un alumno por clave y listar por consola los alumnos
    public static void EjemploDictionary()
    {
        CasoDictionary diccionario = new CasoDictionary();

        //Agregar 3 alumnos
        Alumno alumno1 = new Alumno(1, "Juan", 8.5);
        Alumno alumno2 = new Alumno(2, "Maria", 9.0);
        Alumno alumno3 = new Alumno(3, "Pedro", 7.5);

        diccionario.AgregarAlumno(alumno1);
        diccionario.AgregarAlumno(alumno2);
        diccionario.AgregarAlumno(alumno3);

        //Listar alumnos por consola
        Console.WriteLine("DICCIONARIO DE ALUMNOS");
        foreach (KeyValuePair<int, Alumno> par in diccionario.ObtenerDiccionario())
        {
            Console.WriteLine($"Legajo: {par.Key} - {par.Value}");
        }

        //Buscar un alumno que exista
        Console.WriteLine("\nBUSCAR ALUMNO EXISTENTE (legajo 2)");
        Alumno encontrado = diccionario.BuscarPorLegajo(2);
        Console.WriteLine(encontrado);

        //Buscar un alumno que no exista
        Console.WriteLine("\nBUSCAR ALUMNO INEXISTENTE");
        Alumno noExistente = diccionario.BuscarPorLegajo(99);
        if (noExistente == null)
            Console.WriteLine("No existe ese alumno");
        else
            Console.WriteLine(noExistente);

        //Eliminar un alumno y lsitar
        Console.WriteLine("\nELIMINAR ALUMNO (legajo 1)");
        diccionario.EliminarAlumno(1);
        foreach (KeyValuePair<int, Alumno> par in diccionario.ObtenerDiccionario())
        {
            Console.WriteLine($"Legajo: {par.Key} - {par.Value}");
        }

    }

    //Realizar una llamada a cada método definido en CasoLinq y mostar por consola según corresponda
    public static void EjemploLinq()
    {
        CasoLinq linq = new CasoLinq();

        //1. Primer libro
        Console.WriteLine("PRIMER LIBRO");
        Console.WriteLine(linq.GetPrimero());

        //2. Ultimo libro
        Console.WriteLine("\nULTIMO LIBRO");
        Console.WriteLine(linq.GetUltimo());

        //3. Suma de precios
        Console.WriteLine("\nTOTAL DE PRECIOS");
        Console.WriteLine(linq.GetTotalPrecios().ToString("N2"));

        //4. Promedio de precios
        Console.WriteLine("\nPROMEDIO DE PRECIOS");
        Console.WriteLine(linq.GetPromedioPrecios().ToString("N2"));

        //5. Libros con ID mayor a 15
        Console.WriteLine("\nLIBROS CON ID MAYOR A 15");
        foreach (Libro libro in linq.GetListById())
        {
            Console.WriteLine(libro);
        }

        //6. Lista de titulos y precios en formato moneda
        Console.WriteLine("\nTITULO Y PRECIOS");
        foreach (string item in linq.GetLibros())
        {
            Console.WriteLine(item);
        }

        //7. Libro con precio mas alto
        Console.WriteLine("\nLIBRO CON PRECIO MAS ALTO");
        Console.WriteLine(linq.GetMayorPrecio());

        //8. Libro con precio mas bajo
        Console.WriteLine("\n LIBRO CON PRECIO MAS BAJO");
        Console.WriteLine(linq.GetMenorPrecio());

        //9. Libros con precio mayor al promedio
        Console.WriteLine("\nLIBROS CON PRECIO MAYOR AL PROMEDIO");
        foreach (Libro libro in linq.GetMayorPromedio())
        {
            Console.WriteLine(libro);
        }

        //10. Libros ordenados por titulo descendente
        Console.WriteLine("\nLIBROS ORDENADOS POR TITULO DESCENDENTE");
        foreach (Libro libro in linq.GetOrdenadosPorTitulo())
        {
            Console.WriteLine(libro);
        }
    }
}   
