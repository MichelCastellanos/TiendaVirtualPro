//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AccesoDeDatos.modelos
{
    using System;
    using System.Collections.Generic;
    
    public partial class tb_Usuario_Vendedor
    {
        public int Id { get; set; }
        public string Usuario { get; set; }
        public string Clave { get; set; }
        public int Id_Vendedor { get; set; }
    
        public virtual tb_Vendedor tb_Vendedor { get; set; }
    }
}
