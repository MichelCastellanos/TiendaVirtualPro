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
    
    public partial class tb_Cliente
    {
        public int Id { get; set; }
        public string Primer_Nombre { get; set; }
        public string Segundo_Nombre { get; set; }
        public string Primer_Apellido { get; set; }
        public string Segundo_Apellido { get; set; }
        public string Numero_Doc { get; set; }
        public string Celular { get; set; }
        public string Email { get; set; }
        public int Creador { get; set; }
        public System.DateTime Fecha_Creado { get; set; }
        public Nullable<int> Editor { get; set; }
        public Nullable<System.DateTime> Fecha_Edicion { get; set; }
    
        public virtual tb_Vendedor tb_Vendedor { get; set; }
    }
}