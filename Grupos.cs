using System;

namespace Pr2_CodeQuality
{
    /// <summary>
    /// los grupos que pueden contener ciertas materias
    /// </summary>
    class Grupos
    {
        string primeraMateria;
        string segundaMateria;
        string terceraMateria;

        public Grupos (string primeraMateria, string segundaMateria, string terceraMateria){
            this.primeraMateria= primeraMateria;
            this.segundaMateria = segundaMateria;
            this.terceraMateria = terceraMateria;
        }

        public string TomarPrimeraMateria(){
            return primeraMateria;
        }
        public string TomarSegundaMateria(){
            return segundaMateria;
        }
        public string TomarTerceraMateria(){
            return terceraMateria;
        }
    }
}