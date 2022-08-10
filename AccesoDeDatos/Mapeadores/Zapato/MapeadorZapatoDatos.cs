using AccesoDeDatos.DbModel.Zapato;
using AccesoDeDatos.modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDeDatos.Mapeadores.Zapato
{
        public class MapeadorZapatoDatos : MapeadorBaseDatos<tb_Zapato, ZapatoDbModel>
        {
            public override ZapatoDbModel MapearTipo1Tipo2(tb_Zapato entrada)
            {
                return new ZapatoDbModel()
                {
                    Id = entrada.Id,
                    Color = entrada.Color,
                    Modelo = entrada.Modelo,
                    Precio = entrada.Precio,
                    Descuento = entrada.Descuento,
                    Talla= entrada.Talla,
                    Estado= entrada.Estado,
                    Genero= entrada.Genero,
                    Id_Categoria= entrada.Id_Categoria,
                    Id_Marca=entrada.Id_Marca,
                    Id_Proveedor=entrada.Id_Proveedor,
                    NombreMarca=entrada.tb_Marca.Nombre,
                    NombreCategoria=entrada.tb_Categoria.Nombre,
                    RazonSocialProveedor=entrada.tb_Proveedor.RazonSocial
                };
            }

            public override IEnumerable<ZapatoDbModel> MapearTipo1Tipo2(IEnumerable<tb_Zapato> entrada)
            {
                foreach (var item in entrada)
                {
                    yield return MapearTipo1Tipo2(item);
                }

            }

            public override tb_Zapato MapearTipo2Tipo1(ZapatoDbModel entrada)
            {
                return new tb_Zapato()
                {
                    Id = entrada.Id,
                    Color = entrada.Color,
                    Modelo = entrada.Modelo,
                    Precio = entrada.Precio,
                    Descuento = entrada.Descuento,
                    Talla = entrada.Talla,
                    Estado = entrada.Estado,
                    Genero = entrada.Genero,
                    Id_Categoria = entrada.Id_Categoria,
                    Id_Marca = entrada.Id_Marca,
                    Id_Proveedor = entrada.Id_Proveedor
                };
            }

            public override IEnumerable<tb_Zapato> MapearTipo2Tipo1(IEnumerable<ZapatoDbModel> entrada)
            {
                foreach (var item in entrada)
                {
                    yield return MapearTipo2Tipo1(item);
                }
            }
        }
}
