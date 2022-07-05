using AccesoDeDatos.modelos;
using Logica.DTO.Parametros;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TiendaVirtual.Models.ModelosGUI.Parametros;

namespace TiendaVirtual.Mapeadores.Parametros
{
    public class MapeadorCategoriaGUI: MapeadorBaseGUI<CategoriaDTO, ModeloCategoriaGUI>
    {
        public override ModeloCategoriaGUI MapearTipo1Tipo2(CategoriaDTO entrada)
        {
            return new ModeloCategoriaGUI()
            {
                Id = entrada.Id,
                Nombre = entrada.Nombre
            };
        }

        public override IEnumerable<ModeloCategoriaGUI> MapearTipo1Tipo2(IEnumerable<CategoriaDTO> entrada)
        {
            foreach (var item in entrada)
            {
                yield return MapearTipo1Tipo2(item);
            }

        }

        public override CategoriaDTO MapearTipo2Tipo1(ModeloCategoriaGUI entrada)
        {
            return new CategoriaDTO()
            {
                Id = entrada.Id,
                Nombre = entrada.Nombre
            };
        }

        public override IEnumerable<CategoriaDTO> MapearTipo2Tipo1(IEnumerable<ModeloCategoriaGUI> entrada)
        {
            foreach (var item in entrada)
            {
                yield return MapearTipo2Tipo1(item);
            }
        }
    }
}
