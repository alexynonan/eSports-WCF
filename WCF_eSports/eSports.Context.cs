﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WCF_eSports
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class eSportsEntities : DbContext
    {
        public eSportsEntities()
            : base("name=eSportsEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<DETALLE_EQUIPO> DETALLE_EQUIPO { get; set; }
        public virtual DbSet<DETALLE_JUGADOR_PARTIDA> DETALLE_JUGADOR_PARTIDA { get; set; }
        public virtual DbSet<DETALLE_PERSONAL> DETALLE_PERSONAL { get; set; }
        public virtual DbSet<EQUIPO> EQUIPO { get; set; }
        public virtual DbSet<HEROE> HEROE { get; set; }
        public virtual DbSet<JUEGO> JUEGO { get; set; }
        public virtual DbSet<JUGADOR> JUGADOR { get; set; }
        public virtual DbSet<PARTIDA> PARTIDA { get; set; }
        public virtual DbSet<PERSONAL> PERSONAL { get; set; }
        public virtual DbSet<PRIZEPOOL> PRIZEPOOL { get; set; }
        public virtual DbSet<PUESTO_PRIZEPOOL> PUESTO_PRIZEPOOL { get; set; }
        public virtual DbSet<TORNEO> TORNEO { get; set; }
        public virtual DbSet<vw_RankingKillsPorPartida> vw_RankingKillsPorPartida { get; set; }
    
        public virtual ObjectResult<usp_KillsEquipoPorPartida_Result> usp_KillsEquipoPorPartida(Nullable<int> partida)
        {
            var partidaParameter = partida.HasValue ?
                new ObjectParameter("partida", partida) :
                new ObjectParameter("partida", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_KillsEquipoPorPartida_Result>("usp_KillsEquipoPorPartida", partidaParameter);
        }
    
        public virtual ObjectResult<ListarJugadorPorPais_Result> ListarJugadorPorPais(string pais)
        {
            var paisParameter = pais != null ?
                new ObjectParameter("pais", pais) :
                new ObjectParameter("pais", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ListarJugadorPorPais_Result>("ListarJugadorPorPais", paisParameter);
        }
    
        public virtual ObjectResult<ConsultarHeroeComplejidad_Result> ConsultarHeroeComplejidad(string complejidad)
        {
            var complejidadParameter = complejidad != null ?
                new ObjectParameter("Complejidad", complejidad) :
                new ObjectParameter("Complejidad", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ConsultarHeroeComplejidad_Result>("ConsultarHeroeComplejidad", complejidadParameter);
        }
    
        public virtual ObjectResult<usp_ListarHeroeRol_Result> usp_ListarHeroeRol(Nullable<int> idheroe, string roljugador)
        {
            var idheroeParameter = idheroe.HasValue ?
                new ObjectParameter("idheroe", idheroe) :
                new ObjectParameter("idheroe", typeof(int));
    
            var roljugadorParameter = roljugador != null ?
                new ObjectParameter("roljugador", roljugador) :
                new ObjectParameter("roljugador", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_ListarHeroeRol_Result>("usp_ListarHeroeRol", idheroeParameter, roljugadorParameter);
        }
    
        public virtual ObjectResult<ConsultarFechaTorneo_Result> ConsultarFechaTorneo(Nullable<System.DateTime> fechaIni, Nullable<System.DateTime> fechaFin)
        {
            var fechaIniParameter = fechaIni.HasValue ?
                new ObjectParameter("FechaIni", fechaIni) :
                new ObjectParameter("FechaIni", typeof(System.DateTime));
    
            var fechaFinParameter = fechaFin.HasValue ?
                new ObjectParameter("FechaFin", fechaFin) :
                new ObjectParameter("FechaFin", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ConsultarFechaTorneo_Result>("ConsultarFechaTorneo", fechaIniParameter, fechaFinParameter);
        }
    
        public virtual ObjectResult<RankingEdadMenorJugador_Result> RankingEdadMenorJugador(Nullable<int> filas)
        {
            var filasParameter = filas.HasValue ?
                new ObjectParameter("Filas", filas) :
                new ObjectParameter("Filas", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<RankingEdadMenorJugador_Result>("RankingEdadMenorJugador", filasParameter);
        }
    
        public virtual ObjectResult<usp_EdadJugador_Result> usp_EdadJugador(Nullable<int> edad)
        {
            var edadParameter = edad.HasValue ?
                new ObjectParameter("Edad", edad) :
                new ObjectParameter("Edad", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_EdadJugador_Result>("usp_EdadJugador", edadParameter);
        }
    }
}
