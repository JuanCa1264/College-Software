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
    
    public partial class Detalle_Nota
    {
        public int idDetN { get; set; }
        public int carnet { get; set; }
        public decimal nota { get; set; }
        public int idMod { get; set; }
        public int idEv { get; set; }
    
        public virtual Alumno Alumno { get; set; }
        public virtual Evaluacion Evaluacion { get; set; }
        public virtual Modulo Modulo { get; set; }
    }
}
