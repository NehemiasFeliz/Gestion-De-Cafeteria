//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Gestion_De_Cafeteria
{
    using System;
    using System.Collections.Generic;
    
    public partial class Cafeteria
    {
        public int ID { get; set; }
        public string Descripcion { get; set; }
        public int ID_Campus { get; set; }
        public int Encargado { get; set; }
        public string Estado { get; set; }
    
        public virtual Campu Campu { get; set; }
        public virtual Empleado Empleado { get; set; }
    }
}
