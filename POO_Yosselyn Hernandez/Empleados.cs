using System;
using System.Collections.Generic;

namespace ListaEmpleados
{
    public class Empleado
    {
        public int IdentificacionId { get; }
        public string NombreDelEmpleado { get; set; }
        public string ApellidoDelEmpleado { get; set; }
        public string EmployeePosition { get; set; }
        public List<Empleado> Empleados { get; set; } = new List<Empleado>();

        public Empleado(int identificacionId)
        {
            IdentificacionId = identificacionId;
        }

        public static void VerListadoDeEmpleados(List<Empleado> empleados)
        {
            if (empleados.Count == 0)
            {
                Console.WriteLine("No se han agregado empleados");
            }
            else
            {
                foreach (var empleado in empleados)
                {
                    Console.WriteLine($"ID: {empleado.IdentificacionId}, Nombre: {empleado.NombreDelEmpleado} {empleado.ApellidoDelEmpleado}, Posicion: {empleado.EmployeePosition}");

                    if (empleado.Empleados != null && empleado.Empleados.Count > 0)
                    {
                        Console.WriteLine("Subordinados:");

                        foreach (var subordinado in empleado.Empleados)
                        {
                            Console.WriteLine($"  - {subordinado.NombreDelEmpleado} {subordinado.ApellidoDelEmpleado}");
                        }
                    }
                }
            }
        }

        public static void AgregarEmpleado(List<Empleado> empleados)
        {
            Console.Write("Ingrese el nombre del empleado: \n");
            string nombre = Console.ReadLine();

            Console.Write("Ingrese el apellido del empleado: \n");
            string apellido = Console.ReadLine();

            Console.Write("Ingrese la posicion del empleado: \n");
            string posicion = Console.ReadLine();

            int nuevoId = empleados.Count > 0 ? empleados[empleados.Count - 1].IdentificacionId + 1 : 1;

            Empleado empleado = new Empleado(nuevoId)
            {
                NombreDelEmpleado = nombre,
                ApellidoDelEmpleado = apellido,
                EmployeePosition = posicion
            };

            empleados.Add(empleado);

            Console.WriteLine("Empleado agregado exitosamente\n");
        }

        public static void EditarEmpleado(List<Empleado> empleados)
        {
            Console.WriteLine("Listado de Empleados");
            VerListadoDeEmpleados(empleados);

            Console.Write("Seleccione un ID de Empleado para editarlo: ");
            int empleadoId;
            while (!int.TryParse(Console.ReadLine(), out empleadoId) || empleadoId <= 0)
            {
                Console.WriteLine("Entrada inválida. Por favor, ingrese un número entero positivo.");
                Console.Write("Seleccione un ID de Empleado para editarlo: ");
            }

            Empleado empleado = empleados.Find(e => e.IdentificacionId == empleadoId);

            if (empleado != null)
            {
                Console.Write("Ingrese el nuevo nombre del empleado:\n");
                empleado.NombreDelEmpleado = Console.ReadLine();

                Console.Write("Ingrese el nuevo apellido del empleado:\n");
                empleado.ApellidoDelEmpleado = Console.ReadLine();

                Console.Write("Ingrese la nueva posicion del empleado:\n");
                empleado.EmployeePosition = Console.ReadLine();

                Console.WriteLine("Empleado editado exitosamente\n");
            }
            else
            {
                Console.WriteLine("No se encontró el empleado\n");
            }
        }

        public static void EliminarEmpleado(List<Empleado> empleados)
        {
            Console.WriteLine("Listado de Empleados\n");
            VerListadoDeEmpleados(empleados);

            Console.Write("Seleccione un ID de Empleado para eliminarlo:\n");
            int empleadoId;
            while (!int.TryParse(Console.ReadLine(), out empleadoId) || empleadoId <= 0)
            {
                Console.WriteLine("Entrada inválida. Por favor, ingrese un número entero positivo.");
                Console.Write("Seleccione un ID de Empleado para eliminarlo: ");
            }

            Empleado empleado = empleados.Find(e => e.IdentificacionId == empleadoId);

            if (empleado != null)
            {
                empleados.Remove(empleado);
                Console.WriteLine("Empleado eliminado exitosamente\n");
            }
            else
            {
                Console.WriteLine("No se encontró el empleado\n");
            }
        }
    }
}



