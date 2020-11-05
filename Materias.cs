using System;

namespace Pr2_CodeQuality
{
    /// <summary>
    /// distintas materias que puede tener
    /// </summary>
    class Materias
    {
        
        public int valorMatematicas {get; set;}

        public int valorCalculo {get; set;}

        public int valorProgramacion{get; set;}

        public Materias(int valorMatematicas, int valorCalculo, int valorProgramacion){
            this.valorMatematicas = valorMatematicas;
            this.valorCalculo =  valorCalculo;
            this.valorProgramacion = valorProgramacion;

        }

        public int tomarPrimeraCalificacion(){
            return valorMatematicas;
        }
        public int tomerSegundaCalificacion(){
            return valorCalculo;
        }
        public int tomarTerceraCalificacion(){
            return valorProgramacion;
        }
    }
}
