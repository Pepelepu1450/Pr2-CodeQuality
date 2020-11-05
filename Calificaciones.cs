using System;

namespace Pr2_CodeQuality
{
    /// <summary>
    /// Evaluacion criteria que pue pueden tener las materias
    /// </summary>
    class Calificaciones
    {
        string nombre;
        public int valorDeLamateria{get;set;}
        public int valorDeLosTabajos{get;set;}
        public int PuntosExtra{get;set;}

        public Calificaciones (string nombre, int valorDeLamateria, int valorDeLosTabajos, int PuntosExtra){
            this.nombre = nombre;
            this.valorDeLamateria = valorDeLamateria;
            this.valorDeLosTabajos= valorDeLosTabajos;
            this.PuntosExtra = PuntosExtra;
        }

        public string TomarNombre(){
            return nombre;
        }
        
    }
}
