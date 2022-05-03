using AccesoDeDatos.modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TiendaVirtual.Models.ModelosGUI.Parametros;

namespace TiendaVirtual.Mapeadores.Parametros
{
    public class MapeadorCategoriaGUI: MapeadorBaseGUI<tb_Categoria, ModeloCategoriaGUI>
    {
        public override ModeloCategoriaGUI MapearTipo1Tipo2(tb_Categoria entrada)
        {
            return new ModeloCategoriaGUI()
            {
                Id = entrada.Id,
                Nombre = entrada.Nombre
            };
        }

        public override IEnumerable<ModeloCategoriaGUI> MapearTipo1Tipo2(IEnumerable<tb_Categoria> entrada)
        {
            foreach (var item in entrada)
            {
                yield return MapearTipo1Tipo2(item);
            }

        }

        public override tb_Categoria MapearTipo2Tipo1(ModeloCategoriaGUI entrada)
        {
            return new tb_Categoria()
            {
                Id = entrada.Id,
                Nombre = entrada.Nombre
            };
        }

        public override IEnumerable<tb_Categoria> MapearTipo2Tipo1(IEnumerable<ModeloCategoriaGUI> entrada)
        {
            foreach (var item in entrada)
            {
                yield return MapearTipo2Tipo1(item);
            }
        }
    }
}
