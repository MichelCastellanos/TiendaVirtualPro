using AccesoDeDatos.DbModel;
using AccesoDeDatos.modelos;
using System.Collections.Generic;

namespace AccesoDeDatos.Mapeadores.Parametros
{
    public class MapeadorMarcaDatos : MapeadorBaseDatos<tb_Marca, MarcaDbModel>
    {
        public override MarcaDbModel MapearTipo1Tipo2(tb_Marca entrada)
        {
            return new MarcaDbModel()
            {
                Id = entrada.Id,
                Nombre = entrada.Nombre
            };
        }

        public override IEnumerable<MarcaDbModel> MapearTipo1Tipo2(IEnumerable<tb_Marca> entrada)
        {
            foreach(var item in entrada)
            {
                yield return MapearTipo1Tipo2(item);
            }
            
        }

        public override tb_Marca MapearTipo2Tipo1(MarcaDbModel entrada)
        {
            return new tb_Marca()
            {
                Id = entrada.Id,
                Nombre = entrada.Nombre
            };
        }

        public override IEnumerable<tb_Marca> MapearTipo2Tipo1(IEnumerable<MarcaDbModel> entrada)
        {
            foreach (var item in entrada)
            {
                yield return MapearTipo2Tipo1(item);
            }
        }
    }
}