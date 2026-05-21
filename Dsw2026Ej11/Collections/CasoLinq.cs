using Dsw2026Ej11.Domain;
using System.Linq;

namespace Dsw2026Ej11.Collections;

/*
 * Para cada punto crear un método que permita:
 * 1. Obtener el primer libro (GetPrimero)
 * 2. Obtener el último libro (GetUltimo)
 * 3. Obtener la suma de precios (GetTotalPrecios)
 * 4. Obtener el promedio de precios (GetPromedioPrecios)
 * 5. Obtener la lista de libros con Id mayor a 15 (GetListById)
 * 6. Obtener una lista de cada libro con su título y precio en formato moneda (GetLibros) (debe retornar una lista de string)
 * 7. Obtener el libro con el precio más alto (GetMayorPrecio)
 * 8. Obtener el libro con el precio más bajo (GetMenorPrecio)
 * 9. Obtener los libros cuyo precio sea mayor al promedio (GetMayorPromedio)
 * 10. Obtener los libros ordenados por título de forma descendente
 * En todos los casos debe aplicarse LINQ
 */
public class CasoLinq
{
    private List<Libro> _libros = Libro.CrearLista();

    //1. Obtener el primer libro
    public Libro GetPrimero()
    {
        return _libros.First();
    }

    //2. Obtener el ultimo libro
    public Libro GetUltimo()
    {
        return _libros.Last();
    }

    //3. Obtener la suma de precios
    public decimal GetTotalPrecios()
    {
        return _libros.Sum(l => (decimal)l.Precio);
    }

    //4. Obtener el promedio de precios
    public decimal GetPromedioPrecios()
    {
        return _libros.Average(l => l.Precio);
    }

    //5. Obtener libros con ID mayor a 15
    public List<Libro> GetListById()
    {
        return _libros.Where(l => l.Id > 15).ToList();
    }

    //6. Obtener lista de titulo y precio en formato moneda
    public List<string> GetLibros()
    {
        return _libros.Select(l => $"{l.Titulo} - {l.Precio.ToString("N2")}").ToList();
    }

    //7. Obtener el libro con el precio mas alto
    public Libro GetMayorPrecio()
    {
        return _libros.OrderByDescending(l => l.Precio).First();
    }

    //8. Obtener el libro con el precio mas bajo
    public Libro GetMenorPrecio()
    {
        return _libros.OrderBy(l => l.Precio).First();
    }

    //9. Obtener libros cuyo precio sea mayor al promedio
    public List<Libro> GetMayorPromedio()
    {
        decimal promedio = _libros.Average(l => l.Precio);
        return _libros.Where(l => l.Precio > promedio).ToList();
    }

    //10. Obtener libros ordenados por el titulo de forma descendente
    public List<Libro> GetOrdenadosPorTitulo()
    {
        return _libros.OrderByDescending(l => l.Titulo).ToList();
    }
}
