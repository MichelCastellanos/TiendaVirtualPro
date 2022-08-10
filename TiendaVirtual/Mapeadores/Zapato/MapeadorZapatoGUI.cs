using Logica.DTO.Zapato;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TiendaVirtual.Models.ModelosGUI.Zapato;


namespace TiendaVirtual.Mapeadores.Zapato
{
    public class MapeadorZapatoGUI : MapeadorBaseGUI<ZapatoDTO, ModeloZapatoGUI>
    {
        public override ModeloZapatoGUI MapearTipo1Tipo2(ZapatoDTO entrada)
        {
            return new ModeloZapatoGUI()
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

        public override IEnumerable<ModeloZapatoGUI> MapearTipo1Tipo2(IEnumerable<ZapatoDTO> entrada)
        {
            foreach (var item in entrada)
            {
                yield return MapearTipo1Tipo2(item);
            }

        }

        public override ZapatoDTO MapearTipo2Tipo1(ModeloZapatoGUI entrada)
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
                Id_Proveedor = entrada.Id_Proveedor
            };
        }

        public override IEnumerable<ZapatoDTO> MapearTipo2Tipo1(IEnumerable<ModeloZapatoGUI> entrada)
        {
            foreach (var item in entrada)
            {
                yield return MapearTipo2Tipo1(item);
            }
        }
    }
}