//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class DETALLE_EQUIPO
    {
        public int IdEquipo { get; set; }
        public int IdTorneo { get; set; }
        public int Victorias { get; set; }
        public int Derrotas { get; set; }
        public Nullable<int> Puesto { get; set; }
    
        public virtual EQUIPO EQUIPO { get; set; }
        public virtual TORNEO TORNEO { get; set; }
    }
}
