using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO_SistemaGestiónEmpleados_2daParte.Models;
public class Persona
{
    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public int Edad { get; set; }

    //Se crea un constructor para Persona
    public Persona(string nombre,
    string apellido,
    int edad)
    {
        this.Nombre = nombre;
        this.Apellido = apellido;
        this.Edad = edad;
    }

    public virtual void MostrarInformacion()
    {
        Console.WriteLine($"Nombre Completo: {Nombre} {Apellido}, Edad: {Edad}");
    }
}