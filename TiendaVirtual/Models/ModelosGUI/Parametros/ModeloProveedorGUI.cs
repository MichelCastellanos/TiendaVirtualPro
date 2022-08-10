using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TiendaVirtual.Models.ModelosGUI.Parametros
{
    public class ModeloProveedorGUI
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private string razonSocial;

        [Required]
        [MinLength(3)]
        public string RazonSocial
        {
            get { return razonSocial; }
            set { razonSocial = value; }
        }
        private string jefe_cargo;

        public string Jefe_Cargo
        {
            get { return jefe_cargo; }
            set { jefe_cargo = value; }
        }
        private string direccion;

        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }
        private string telefono;

        public string Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }
        private string email;

        public string Email
        {
            get { return email; }
            set { email = value; }
        }
    }
}