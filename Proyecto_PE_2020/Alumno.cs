//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Proyecto_PE_2020
{
    using System;
    using System.Collections.Generic;
    
    public partial class Alumno
    {
        public Alumno()
        {
            this.Detalle_Nota = new HashSet<Detalle_Nota>();
            this.Detalle_Alumno = new HashSet<Detalle_Alumno>();
        }
    
        public int carnet { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public int idCa { get; set; }
    
        public virtual ICollection<Detalle_Nota> Detalle_Nota { get; set; }
        public virtual ICollection<Detalle_Alumno> Detalle_Alumno { get; set; }
        public virtual CursoAcademico CursoAcademico { get; set; }
    }
}