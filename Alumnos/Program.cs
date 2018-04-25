using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alumnos
{
    class Program
    {
        static Alumno CrearAlumno()
        {
            var aux = new Alumno();

            Console.WriteLine("Ingrese apellido del alumno: ");
            aux.Apellido = Console.ReadLine();
            do {
                Console.WriteLine("Ingrese promedio alumno: ");
                aux.Promedio = double.Parse(Console.ReadLine());
            } while (aux.Promedio < 1 || aux.Promedio > 10);

            aux.Id = 1;

            return aux;
        }

        static void Menu()
        {

            Alumno[] alumnos = new Alumno[3];
            var aux = new Alumno();
            int id;
            char opc = ' ';

            for (int i = 0; i < alumnos.Length; i++)
            {
                alumnos[i] = CrearAlumno();
                alumnos[i].Id += i;
            }

            do
            {
                aux.ListarAlumnos(alumnos);

                Console.WriteLine("escriba numero del alumno que le quiere cambiar el promedio");
                id = int.Parse(Console.ReadLine());

                id = aux.BuscarId(id, alumnos);

                if (id != -1)
                {
                    do
                    {
                        Console.WriteLine("Ingrese promedio alumno: ");
                        alumnos[id].Promedio = double.Parse(Console.ReadLine());
                    } while (alumnos[id].Promedio < 1 || alumnos[id].Promedio > 10);
                }
                else
                    Console.WriteLine("No se encontro el id");

                Console.WriteLine("Para salir presione N");
                opc = char.Parse(Console.ReadLine());

                opc = char.ToUpper(opc);
            } while (opc != 'N');
        }

        static void Main(string[] args)
        {
            Menu();
        }
    }
}
