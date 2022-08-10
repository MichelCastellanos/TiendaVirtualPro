using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDeDatos.DbModel.Zapato
{
    public class ZapatoDbModel
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private string color;

        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        private string modelo;

        public string Modelo
        {
            get { return modelo; }
            set { modelo = value; }
        }

        private int precio;

        public int Precio
        {
            get { return precio; }
            set { precio = value; }
        }

        private int? descuento;

        public int? Descuento
        {
            get { return descuento; }
            set { descuento = value; }
        }

        private int talla;

        public int Talla
        {
            get { return talla; }
            set { talla = value; }
        }

        private bool estado;

        public bool Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        private string genero;

        public string Genero
        {
            get { return genero; }
            set { genero = value; }
        }

        private int id_proveedor;

        public int Id_Proveedor
        {
            get { return id_proveedor; }
            set { id_proveedor = value; }
        }

        private int id_marca;

        public int Id_Marca
        {
            get { return id_marca; }
            set { id_marca = value; }
        }

        private int id_categoria;

        public int Id_Categoria
        {
            get { return id_categoria; }
            set { id_categoria = value; }
        }

        private string nombreCategoria;

        public string NombreCategoria
        {
            get { return nombreCategoria; }
            set { nombreCategoria = value; }
        }

        private string nombreMarca;

        public string NombreMarca
        {
            get { return nombreMarca; }
            set { nombreMarca = value; }
        }

        private string razonSocialProveedor;

        public string RazonSocialProveedor
        {
            get { return razonSocialProveedor; }
            set { razonSocialProveedor = value; }
        }

       
    }
}
