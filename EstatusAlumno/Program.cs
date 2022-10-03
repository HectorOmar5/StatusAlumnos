using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstatusAlumno
{
    internal class Program
    {
        private static List<Estatus> _listStatus = new List<Estatus>();

        static Estatus _objEstatus = new Estatus();
        static void Main(string[] args)
        {
            bool Salir = false;
            while (!Salir)
            {
                try
                {
                    Console.WriteLine("============MENU PRINCIPAL============");
                    Console.WriteLine("\t");
                    Console.WriteLine("\t***************************");
                    Console.WriteLine("\t1.- Consultar Todos");
                    Console.WriteLine("\t***************************");
                    Console.WriteLine("\t2.- Consultar Solo Uno");
                    Console.WriteLine("\t***************************");
                    Console.WriteLine("\t3.- Agregar");
                    Console.WriteLine("\t***************************");
                    Console.WriteLine("\t4.- Actualizar");
                    Console.WriteLine("\t***************************");
                    Console.WriteLine("\t5.- Eliminar");
                    Console.WriteLine("\t***************************");
                    Console.WriteLine("\t6.- Terminar");
                    Console.WriteLine("\t***************************");
                    Console.WriteLine("\nSeleccione Una Opción De La Lista");

                    string opcion = Console.ReadLine();

                    switch (opcion)
                    {
                        case "1":
                            _listStatus = CRUDEstatus.ConsultarTodos();
                            foreach (Estatus status in _listStatus)
                            {
                                Console.WriteLine($"id={status.id}, clave ={status.clave}, nombre = {status.nombre}");
                            }
                            Console.WriteLine("\n");
                            break;
                        case "2":
                            Console.WriteLine("Ingresa el id del estatus a consultar");
                            _objEstatus = CRUDEstatus.ConsultarUno(Convert.ToInt32(Console.ReadLine()));
                            Console.WriteLine($"id={_objEstatus.id}, clave ={_objEstatus.clave}, nombre = {_objEstatus.nombre}");
                            Console.WriteLine("\n");
                            break;
                        case "3":
                            _objEstatus = new Estatus();
                            Console.WriteLine("Ingresa el id del estatus");
                            _objEstatus.id = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Ingresa la clave");
                            _objEstatus.clave = Console.ReadLine();
                            Console.WriteLine("Ingresa el nombre del estatus");
                            _objEstatus.nombre = Console.ReadLine();
                            CRUDEstatus.Agregar(_objEstatus);
                            Console.WriteLine("\n");
                            break;
                        case "4":
                            Console.WriteLine("Ingresa el id a actualizar");
                            _objEstatus.id = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Ingresa la clave");
                            _objEstatus.clave = Console.ReadLine();
                            Console.WriteLine("Ingresa el nuevo nombre del estatus");
                            _objEstatus.nombre = Console.ReadLine();
                            CRUDEstatus.Actualizar(_objEstatus);
                            Console.WriteLine("\n");
                            break;
                        case "5":
                            Console.WriteLine("Ingresa el id del estatus a eliminar");
                            _objEstatus = CRUDEstatus.ConsultarUno(Convert.ToInt32(Console.ReadLine()));
                            CRUDEstatus.Eliminar(_objEstatus);
                            Console.WriteLine("\n");
                            break;
                        case "6":
                            Console.WriteLine("¿Deseas Salir De La Consola? Presiona <ENTER>");
                            Console.WriteLine("\n");
                            Salir = true;
                            break;
                    }
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            Console.ReadLine();
        }
    }
    
}
