using System;

namespace Pr2_CodeQuality
{
    /// <summary>
    /// 
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {            
            Calculadora calculadora = new Calculadora();

            Calificaciones calificaciones = new Calificaciones("jose",80,5,5);
            Calificaciones calificaciones1 = new Calificaciones("ana",60,25,10);
            Calificaciones calificaciones2 = new Calificaciones ("isis",50,30,10);

            Carrera Multimedia = new Carrera("multimedia","multimedia1","multimedia2");

            Materias materias = new Materias(100,100,100);
        }
    }
}
