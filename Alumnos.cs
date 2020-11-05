using System;

namespace Pr2_CodeQuality
{
    /// <summary>
    /// cantidad de alumnos que puede tener el grupo
    /// </summary>
    class Alumnos
    {
        string primerAlumno;
        string segundoAlumno;
        string tercerAlumno;

        public Alumnos(string primerAlumno, string segundoAlumno, string tercerAlumno){
            this.primerAlumno =  primerAlumno;
            this.segundoAlumno = segundoAlumno;
            this.tercerAlumno = tercerAlumno;

        }
        
        public string TomarPrimerALumno(){
            return primerAlumno;
        }

        public string TomarSegundoAlumno(){
            return segundoAlumno;
        }

        public string TomarTercerAlumno(){
            return tercerAlumno;
        }
    }
}
