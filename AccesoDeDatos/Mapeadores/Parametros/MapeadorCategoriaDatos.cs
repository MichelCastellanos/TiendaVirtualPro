using AccesoDeDatos.DbModel;
using AccesoDeDatos.DbModel.Parametros;
using AccesoDeDatos.Mapeadores;
using AccesoDeDatos.modelos;
using System.Collections.Generic;

namespace AccesoDeDatos.Mapeadores.Parametros
{
    public class MapeadorCategoriaDatos : MapeadorBaseDatos<tb_Categoria, CategoriaDbModel>
    {
        public override CategoriaDbModel MapearTipo1Tipo2(tb_Categoria entrada)
        {
            return new CategoriaDbModel()
            {
                Id = entrada.Id,
                Nombre = entrada.Nombre
            };
        }

        public override IEnumerable<CategoriaDbModel> MapearTipo1Tipo2(IEnumerable<tb_Categoria> entrada)
        {
            foreach (var item in entrada)
            {
                yield return MapearTipo1Tipo2(item);
            }

        }

        public override tb_Categoria MapearTipo2Tipo1(CategoriaDbModel entrada)
        {
            return new tb_Categoria()
            {
                Id = entrada.Id,
                Nombre = entrada.Nombre
            };
        }

        public override IEnumerable<tb_Categoria> MapearTipo2Tipo1(IEnumerable<CategoriaDbModel> entrada)
        {
            foreach (var item in entrada)
            {
                yield return MapearTipo2Tipo1(item);
            }
        }
    }
}
