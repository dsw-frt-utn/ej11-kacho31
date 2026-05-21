using Dsw2026Ej11.Domain;

namespace Dsw2026Ej11.Collections;

//Crear un diccionario donde la clave sea el legajo y el valor el alumno
//Incluir un método para agregar un alumno al diccionario
//Incluir un método para buscar un alumno utilizando la clave
//Incluir un método para retornar el diccionario
//Incluir un método para eliminar un alumno utilizando la clave
public class CasoDictionary
{
    // Diccionario donde la clave es el legajo y el valor es el Alumno
    private Dictionary<int, Alumno> _alumnos = new Dictionary<int, Alumno>();

    // Agregar un alumno al diccionario
    public void AgregarAlumno(Alumno alumno)
    {
        _alumnos[alumno.Id] = alumno;
    }

    // Buscar un alumno por legajo
    public Alumno? BuscarPorLegajo(int legajo)
    {
        _alumnos.TryGetValue(legajo, out Alumno? alumno);
        return alumno;
    }

    // Retornar el diccionario completo
    public Dictionary<int, Alumno> ObtenerDiccionario()
    {
        return _alumnos;
    }

    // Eliminar un alumno por legajo
    public void EliminarAlumno(int legajo)
    {
        _alumnos.Remove(legajo);
    }
}
