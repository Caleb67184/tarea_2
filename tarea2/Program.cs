using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarea2
{
    internal class Program
    {
        public static void aguinaldo(string nombre,float salario)
        {
            float aguinaldo = salario * 12;
            Console.WriteLine("Nombre: "+nombre
                +" ,Salario: "+salario
                +" ,Aguinaldo: "+aguinaldo+"\n");
            
        }

        static void Main(string[] args)
        {

            string[] empleados = {"Mario","Luis","Carla","Nico","María"};
            float[] salarios = { 2500, 6300, 9800, 1900, 7200 };

            //Al final no entendí como hacerlo con un foreach
            //asi que lo hice con el for de siempre
            for (int i = 0; i < empleados.Length; i++)
            {
                aguinaldo(empleados[i], salarios[i]);
            }
            Console.Read();

        }
    }
}
