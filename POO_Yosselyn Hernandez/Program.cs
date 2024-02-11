using System;
using System.Collections.Generic;
using System.Reflection.Emit;


namespace ListaEmpleados
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            List<Empleado> empleadosLista = new List<Empleado>();

            int opcion;

            Console.WriteLine("PROGRAMA PARA ADMINISTRAR EMPLEADOS ");
            Console.WriteLine("************************************");

            do
            {
                Console.WriteLine("Menu.");
                Console.WriteLine("1. Agregar empleados\n");
                Console.WriteLine("2. Listado de Empleados\n");
                Console.WriteLine("3. Editar empleados\n");
                Console.WriteLine("4. Eliminar empleados\n");
                Console.WriteLine("5. Salir del programa\n");

                Console.Write("Ingrese una opcion: ");
                opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Empleado.AgregarEmpleado(empleadosLista);
                        break;
                    case 2:
                        Empleado.VerListadoDeEmpleados(empleadosLista);
                        break;
                    case 3:
                        Empleado.EditarEmpleado(empleadosLista);
                        break;
                    case 4:
                        Empleado.EliminarEmpleado(empleadosLista);
                        break;
                    case 5:
                        Console.WriteLine("Gracias por usar el programa");
                        return;
                    default:
                        Console.WriteLine("Opción no válida. Por favor, ingrese una opción válida.\n");
                        break;
                }

            } while (opcion != 5);

        }
    }
}
