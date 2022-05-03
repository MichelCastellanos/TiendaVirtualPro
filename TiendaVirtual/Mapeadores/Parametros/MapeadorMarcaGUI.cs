using AccesoDeDatos.modelos;
using System.Collections.Generic;
using TiendaVirtual.Models.ModelosGUI.Parametros;

namespace TiendaVirtual.Mapeadores.Parametros
{
    public class MapeadorMarcaGUI : MapeadorBaseGUI<tb_Marca, ModeloMarcaGUI>
    {
        public override ModeloMarcaGUI MapearTipo1Tipo2(tb_Marca entrada)
        {
            return new ModeloMarcaGUI()
            {
                Id = entrada.Id,
                Nombre = entrada.Nombre
            };
        }

        public override IEnumerable<ModeloMarcaGUI> MapearTipo1Tipo2(IEnumerable<tb_Marca> entrada)
        {
            foreach(var item in entrada)
            {
                yield return MapearTipo1Tipo2(item);
            }
            
        }

        public override tb_Marca MapearTipo2Tipo1(ModeloMarcaGUI entrada)
        {
            return new tb_Marca()
            {
                Id = entrada.Id,
                Nombre = entrada.Nombre
            };
        }

        public override IEnumerable<tb_Marca> MapearTipo2Tipo1(IEnumerable<ModeloMarcaGUI> entrada)
        {
            foreach (var item in entrada)
            {
                yield return MapearTipo2Tipo1(item);
            }
        }
    }
}