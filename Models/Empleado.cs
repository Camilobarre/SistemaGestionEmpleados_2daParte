using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO_SistemaGestiónEmpleados_2daParte.Models;
public class Empleado : Persona
{   
    //Propiedades adicionales para Empleado
    public Guid Id { get; set; }
    public string NumeroDeIdentificacion { get; set; }
    public string Posicion { get; set; }
    public decimal Salario { get; set; }

    //Constructor para Empleado, tomando una base heredada de Persona
    public Empleado(string nombre, string apellido, int edad, string numeroDeIdentificacion, string posicion, decimal salario) : base(nombre, apellido, edad)
    {
        this.Id = Guid.NewGuid();
        this.NumeroDeIdentificacion = numeroDeIdentificacion;
        this.Posicion = posicion;
        this.Salario = salario;
    }

    //Método para calcular la bonificación del salario
    private decimal CalcularBonificacion()
    {
        return Salario * 0.10m;
    }

    //Sobreescritura del método MostrarInformacion para mostrar información del empleado con bonificación al salario
    public override void MostrarInformacion()
    {
        decimal salarioConBonificacion = Salario + CalcularBonificacion();
        Console.WriteLine($"Nombre Completo: {Nombre} {Apellido}, Edad: {Edad}, Posición: {Posicion}, Salario con Bonificación: {salarioConBonificacion:C}");
    }
}