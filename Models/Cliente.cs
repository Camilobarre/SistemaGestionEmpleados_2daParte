using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO_SistemaGestiónEmpleados_2daParte.Models;
public class Cliente : Persona
{
    //Propiedades adicionales para Cliente
    public string Email { get; set; }
    public string Telefono { get; set; }

    //Constructor para Cliente heredado de Persona
    public Cliente(string nombre, string apellido, int edad, string email, string telefono)
        : base(nombre, apellido, edad)
    {
        Email = email;
        Telefono = telefono;
    }

    //Sobreescritura del método MostrarInformacion() para mostrar información específica de Cliente
    public override void MostrarInformacion()
    {
        Console.WriteLine($"Nombre Completo: {Nombre} {Apellido}, Edad: {Edad}, Email: {Email}, Teléfono: {Telefono}");
    }
}
