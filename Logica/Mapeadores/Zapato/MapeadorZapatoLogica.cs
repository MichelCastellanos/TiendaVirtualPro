using AccesoDeDatos.DbModel.Zapato;
using Logica.DTO.Zapato;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Mapeadores.Zapato
{
    public class MapeadorZapatoLogica : MapeadorBaseLogica<ZapatoDbModel, ZapatoDTO>
    {
        public override ZapatoDTO MapearTipo1Tipo2(ZapatoDbModel entrada)
        {
            return new ZapatoDTO()
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
                Id_Proveedor = entrada.Id_Proveedor,
                NombreMarca = entrada.NombreMarca,
                NombreCategoria = entrada.NombreCategoria,
                RazonSocialProveedor = entrada.RazonSocialProveedor
            };
        }

        public override IEnumerable<ZapatoDTO> MapearTipo1Tipo2(IEnumerable<ZapatoDbModel> entrada)
        {
            foreach (var item in entrada)
            {
                yield return MapearTipo1Tipo2(item);
            }

        }

        public override ZapatoDbModel MapearTipo2Tipo1(ZapatoDTO entrada)
        {
            return new ZapatoDbModel()
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

        public override IEnumerable<ZapatoDbModel> MapearTipo2Tipo1(IEnumerable<ZapatoDTO> entrada)
        {
            foreach (var item in entrada)
            {
                yield return MapearTipo2Tipo1(item);
            }
        }
    }
}

