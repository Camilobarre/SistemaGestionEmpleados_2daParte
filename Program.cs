
using POO_SistemaGestiónEmpleados_2daParte.Models;

Empresa empresa = new Empresa("Tech Solutions", "123 Main St");

// Agregar empleados
Empleado emp1 = new Empleado("John", "Doe", 30, "123456", "Desarrollador", 50000m);
Empleado emp2 = new Empleado("Jane", "Smith", 28, "789101", "Diseñadora", 45000m);
empresa.AgregarEmpleado(emp1);
empresa.AgregarEmpleado(emp2);

// Mostrar todos los empleados
empresa.MostrarTodosLosEmpleados();

// Buscar empleado por número de identificación
var empleadoBuscado = empresa.BuscarEmpleado("123456");
if (empleadoBuscado != null)
{
    empleadoBuscado.MostrarInformacion();
}

// Actualizar empleado
Empleado empActualizado = new Empleado("John", "Doe", 31, "123456", "Senior Developer", 60000m);
empresa.ActualizarEmpleado("123456", empActualizado);
empresa.MostrarTodosLosEmpleados();

// Eliminar empleado
empresa.EliminarEmpleado("Jane", "Smith");
empresa.MostrarTodosLosEmpleados();

// Agregar clientes
Cliente cli1 = new Cliente("Alice", "Johnson", 25, "alice@example.com", "555-1234");
Cliente cli2 = new Cliente("Bob", "Brown", 35, "bob@example.com", "555-5678");
empresa.AgregarCliente(cli1);
empresa.AgregarCliente(cli2);

// Mostrar todos los clientes
empresa.MostrarTodosLosClientes();

// Eliminar cliente
empresa.EliminarCliente("Alice", "Johnson");
empresa.MostrarTodosLosClientes();

//Otra forma de mostrar el menú
bool continuar = true;
while (continuar)
{
    Console.WriteLine("\nMenú de Opciones:");
    Console.WriteLine("1. Agregar Empleado");
    Console.WriteLine("2. Eliminar Empleado");
    Console.WriteLine("3. Mostrar Todos los Empleados");
    Console.WriteLine("4. Actualizar Empleado");
    Console.WriteLine("5. Buscar Empleado por Número de Identificación");
    Console.WriteLine("6. Mostrar Empleados por Cargo");
    Console.WriteLine("7. Agregar Cliente");
    Console.WriteLine("8. Eliminar Cliente");
    Console.WriteLine("9. Mostrar Todos los Clientes");
    Console.WriteLine("0. Salir");
    Console.Write("Seleccione una opción: ");
    int opcion = int.Parse(Console.ReadLine());

    switch (opcion)
    {
        case 1:
            Console.Write("Nombre: ");
            string nombreEmp = Console.ReadLine();
            Console.Write("Apellido: ");
            string apellidoEmp = Console.ReadLine();
            Console.Write("Edad: ");
            int edadEmp = int.Parse(Console.ReadLine());
            Console.Write("Número de Identificación: ");
            string idEmp = Console.ReadLine();
            Console.Write("Posición: ");
            string posicionEmp = Console.ReadLine();
            Console.Write("Salario: ");
            decimal salarioEmp = decimal.Parse(Console.ReadLine());

            Empleado nuevoEmpleado = new Empleado(nombreEmp, apellidoEmp, edadEmp, idEmp, posicionEmp, salarioEmp);
            empresa.AgregarEmpleado(nuevoEmpleado);
            Console.WriteLine("Empleado agregado con éxito.");
            break;
        case 2:
            Console.Write("Nombre: ");
            string nombreEliminarEmp = Console.ReadLine();
            Console.Write("Apellido: ");
            string apellidoEliminarEmp = Console.ReadLine();
            empresa.EliminarEmpleado(nombreEliminarEmp, apellidoEliminarEmp);
            Console.WriteLine("Empleado eliminado con éxito.");
            break;
        case 3:
            empresa.MostrarTodosLosEmpleados();
            break;
        case 4:
            Console.Write("Número de Identificación del Empleado a Actualizar: ");
            string idActualizarEmp = Console.ReadLine();

            Console.Write("Nuevo Nombre: ");
            string nuevoNombreEmp = Console.ReadLine();
            Console.Write("Nuevo Apellido: ");
            string nuevoApellidoEmp = Console.ReadLine();
            Console.Write("Nueva Edad: ");
            int nuevaEdadEmp = int.Parse(Console.ReadLine());
            Console.Write("Nueva Posición: ");
            string nuevaPosicionEmp = Console.ReadLine();
            Console.Write("Nuevo Salario: ");
            decimal nuevoSalarioEmp = decimal.Parse(Console.ReadLine());

            Empleado empleadoActualizado = new Empleado(nuevoNombreEmp, nuevoApellidoEmp, nuevaEdadEmp, idActualizarEmp, nuevaPosicionEmp, nuevoSalarioEmp);
            empresa.ActualizarEmpleado(idActualizarEmp, empleadoActualizado);
            Console.WriteLine("Empleado actualizado con éxito.");
            break;
        case 5:
            Console.Write("Número de Identificación del Empleado a Buscar: ");
            string idBuscarEmp = Console.ReadLine();
            var empleadoBuscadoPorId = empresa.BuscarEmpleado(idBuscarEmp);
            if (empleadoBuscadoPorId != null)
            {
                empleadoBuscadoPorId.MostrarInformacion();
            }
            else
            {
                Console.WriteLine("Empleado no encontrado.");
            }
            break;
        case 6:
            Console.Write("Cargo a Buscar: ");
            string cargoBuscar = Console.ReadLine();
            empresa.MostrarEmpleadosPorCargo(cargoBuscar);
            break;
        case 7:
            Console.Write("Nombre: ");
            string nombreCli = Console.ReadLine();
            Console.Write("Apellido: ");
            string apellidoCli = Console.ReadLine();
            Console.Write("Edad: ");
            int edadCli = int.Parse(Console.ReadLine());
            Console.Write("Email: ");
            string emailCli = Console.ReadLine();
            Console.Write("Teléfono: ");
            string telefonoCli = Console.ReadLine();

            Cliente nuevoCliente = new Cliente(nombreCli, apellidoCli, edadCli, emailCli, telefonoCli);
            empresa.AgregarCliente(nuevoCliente);
            Console.WriteLine("Cliente agregado con éxito.");
            break;
        case 8:
            Console.Write("Nombre: ");
            string nombreEliminarCli = Console.ReadLine();
            Console.Write("Apellido: ");
            string apellidoEliminarCli = Console.ReadLine();
            empresa.EliminarCliente(nombreEliminarCli, apellidoEliminarCli);
            Console.WriteLine("Cliente eliminado con éxito.");
            break;
        case 9:
            empresa.MostrarTodosLosClientes();
            break;
        case 0:
            continuar = false;
            break;
        default:
            Console.WriteLine("Opción no válida. Intente nuevamente.");
            break;
    }
}