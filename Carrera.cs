using System;

namespace Pr2_CodeQuality
{
    /// <summary>
    /// adentro de la carrera tener grupos
    /// </summary>
    class Carrera
    {
        // en esta parte van los grupos que estan conformando la carrera
        string carrera1;
        string gruposA;
        string gruposB;

        public Carrera( string carrera1, string gruposA, string gruposB){
            this.carrera1 = carrera1;
            this.gruposA = gruposA;
            this.gruposB = gruposB;
        }
        public string PrimeraCarrera(){
            return carrera1;
        }
        public string PrimerGrupo()
        {
            return gruposA;
        }

        public string SegundoGrupo(){
            return gruposB;
        }
    }
}
