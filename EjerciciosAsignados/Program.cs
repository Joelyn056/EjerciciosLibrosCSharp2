using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.EjerciciosAsignados.Capitulo_10;
using System.EjerciciosAsignados.Capitulo_12;
using System.EjerciciosAsignados.Capitulo_9;

namespace EjerciciosAsignados
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
      //  [STAThread]
        static void Main(string[] arg)
        {
            ///Capitulo 12
            EjerciciosAsignados.Capitulo_12.Ejercicio1();
            EjerciciosAsignados.Capitulo_12.Ejercicio2();

            ///Capitulo 10
            EjerciciosAsignados.Capitulo_10.Estudiante();
            EjerciciosAsignados.Capitulo_10.Inventario();
            EjerciciosAsignados.Capitulo_10.Poligono();
            EjerciciosAsignados.Capitulo_10.Poligono2();
            EjerciciosAsignados.Capitulo_10.Poligono3();

            ///Capitulo 9
            EjerciciosAsignados.Capitulo_9.Ejercicio1();


        }
    }
}
