using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO_SistemaGestiónEmpleados_2daParte.Models;
public class Empresa
{
    //Propiedades de la clase Empresa (Incluye lista de empleados y clientes)
    public string Nombre { get; set; }
    public string Direccion { get; set; }
    public List<Empleado> ListaEmpleados { get; set; }
    public List<Cliente> ListaClientes { get; set; }

    //Constructor de la clase Empresa
    public Empresa(string nombre, string direccion)
    {
        Nombre = nombre;
        Direccion = direccion;
        ListaEmpleados = new List<Empleado>();
        ListaClientes = new List<Cliente>();
    }

    //Método para agregar un empleado (Utiliza Add)
    public void AgregarEmpleado(Empleado empleado)
    {
        ListaEmpleados.Add(empleado);
    }

    //Método para eliminar un empleado (Utiliza RemoveAll)
    public void EliminarEmpleado(string nombre, string apellido)
    {
        ListaEmpleados.RemoveAll(e => e.Nombre == nombre && e.Apellido == apellido);
    }

    //Método para mostrar los empleados (Ciclo ForEach)
    public void MostrarTodosLosEmpleados()
    {
        foreach (var empleado in ListaEmpleados)
        {
            empleado.MostrarInformacion();
        }
    }

    //Método para actualizar un empleado (Utiliza FirstOrDefault)
    public void ActualizarEmpleado(string numeroDeIdentificacion, Empleado empleadoActualizado)
    {
        var empleado = ListaEmpleados.FirstOrDefault(e => e.NumeroDeIdentificacion == numeroDeIdentificacion);
        if (empleado != null)
        {
            empleado.Nombre = empleadoActualizado.Nombre;
            empleado.Apellido = empleadoActualizado.Apellido;
            empleado.Edad = empleadoActualizado.Edad;
            empleado.Posicion = empleadoActualizado.Posicion;
            empleado.Salario = empleadoActualizado.Salario;
        }
    }

    //Método para buscar un empleado (Utiliza FirstOrDefault)
    public Empleado BuscarEmpleado(string numeroDeIdentificacion)
    {
        return ListaEmpleados.FirstOrDefault(e => e.NumeroDeIdentificacion == numeroDeIdentificacion);
    }

    //Método para mostrar empleados por cargo (Utiliza Where y ToList)
    public void MostrarEmpleadosPorCargo(string cargo)
    {
        var empleadosPorCargo = ListaEmpleados.Where(e => e.Posicion == cargo).ToList();
        foreach (var empleado in empleadosPorCargo)
        {
            empleado.MostrarInformacion();
        }
    }

    //Métodos para agregar un cliente (Utiliza Add)
    public void AgregarCliente(Cliente cliente)
    {
        ListaClientes.Add(cliente);
    }

    //Método para eliminar un cliente (Utiliza RemoveAll)
    public void EliminarCliente(string nombre, string apellido)
    {
        ListaClientes.RemoveAll(c => c.Nombre == nombre && c.Apellido == apellido);
    }

    //Método para mostrar los clientes (Ciclo ForEach)
    public void MostrarTodosLosClientes()
    {
        foreach (var cliente in ListaClientes)
        {
            cliente.MostrarInformacion();
        }
    }
}
