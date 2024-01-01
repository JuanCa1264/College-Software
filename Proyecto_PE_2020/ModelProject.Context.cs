﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class Project_PE_2020Entities4 : DbContext
    {
        public Project_PE_2020Entities4()
            : base("name=Project_PE_2020Entities4")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Alumno> Alumno { get; set; }
        public virtual DbSet<CursoAcademico> CursoAcademico { get; set; }
        public virtual DbSet<Detalle_Alumno> Detalle_Alumno { get; set; }
        public virtual DbSet<Detalle_Nota> Detalle_Nota { get; set; }
        public virtual DbSet<Evaluacion> Evaluacion { get; set; }
        public virtual DbSet<Modulo> Modulo { get; set; }
        public virtual DbSet<Ponderaciones> Ponderaciones { get; set; }
    
        public virtual int AgregarDetalleNota(Nullable<int> carnet)
        {
            var carnetParameter = carnet.HasValue ?
                new ObjectParameter("carnet", carnet) :
                new ObjectParameter("carnet", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("AgregarDetalleNota", carnetParameter);
        }
    
        public virtual int AgregarDetalleNota1(Nullable<int> carnet)
        {
            var carnetParameter = carnet.HasValue ?
                new ObjectParameter("carnet", carnet) :
                new ObjectParameter("carnet", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("AgregarDetalleNota1", carnetParameter);
        }
    
        public virtual ObjectResult<Nullable<decimal>> CalcularNotaModulo(Nullable<int> carnet, Nullable<int> idMod)
        {
            var carnetParameter = carnet.HasValue ?
                new ObjectParameter("carnet", carnet) :
                new ObjectParameter("carnet", typeof(int));
    
            var idModParameter = idMod.HasValue ?
                new ObjectParameter("idMod", idMod) :
                new ObjectParameter("idMod", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<decimal>>("CalcularNotaModulo", carnetParameter, idModParameter);
        }
    }
}
