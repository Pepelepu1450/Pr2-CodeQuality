using System;

namespace Pr2_CodeQuality
{
    /// <summary>
    /// calcular las calificaciones de los alumnos
    /// </summary>
    class Calculadora
    {
        /// <summary>
        /// calular los resultados que tienes
        /// </summary>
        /// <param name="calificaciones"></param>
        /// <param name="valorDelaMateria"></param>
        /// <param name="ValorDeLosTrabajos"></param>
        /// <param name="PuntosExtra"></param>
        /// <returns>calificacion</returns>
        public int CalcularCalificacion(Calificaciones calificaciones, int valorDelaMateria, int ValorDeLosTrabajos, int PuntosExtra){
            int calificacion = (valorDelaMateria*calificaciones.valorDeLamateria) + (ValorDeLosTrabajos*calificaciones.valorDeLosTabajos) + (PuntosExtra*calificaciones.PuntosExtra);
            calificacion = calificacion/100;
            return calificacion;
             
        }
    }
}

