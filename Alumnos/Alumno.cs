using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alumnos
{
    class Alumno
    {
        public int Id { get; set; }
        public string Apellido { get; set; }
        public double Promedio { get; set; }


        public void ListarAlumnos(Alumno[] alumnos)
        {
            for (int i = 0; i < alumnos.Length; i++)
                Console.WriteLine(alumnos[i].Id + "  " + alumnos[i].Apellido + "  " + alumnos[i].Promedio);
        }

        public int BuscarId(int id, Alumno[] alumnos)
        {
            for (int i = 0; i < alumnos.Length; i++)
            {
                if (id == alumnos[i].Id)
                    return i;
            }

            return -1;
        }
    }
}
