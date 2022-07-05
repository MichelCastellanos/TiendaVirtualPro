using AccesoDeDatos.DbModel;
using AccesoDeDatos.DbModel.Parametros;
using Logica.DTO.Parametros;
using System.Collections.Generic;

namespace Logica.Mapeadores.Parametros
{
    public class MapeadorCategoriaLogica : MapeadorBaseLogica<CategoriaDbModel, CategoriaDTO>
    {
        public override CategoriaDTO MapearTipo1Tipo2(CategoriaDbModel entrada)
        {
            return new CategoriaDTO()
            {
                Id = entrada.Id,
                Nombre = entrada.Nombre
            };
        }

        public override IEnumerable<CategoriaDTO> MapearTipo1Tipo2(IEnumerable<CategoriaDbModel> entrada)
        {
            foreach (var item in entrada)
            {
                yield return MapearTipo1Tipo2(item);
            }

        }

        public override CategoriaDbModel MapearTipo2Tipo1(CategoriaDTO entrada)
        {
            return new CategoriaDbModel()
            {
                Id = entrada.Id,
                Nombre = entrada.Nombre
            };
        }

        public override IEnumerable<CategoriaDbModel> MapearTipo2Tipo1(IEnumerable<CategoriaDTO> entrada)
        {
            foreach (var item in entrada)
            {
                yield return MapearTipo2Tipo1(item);
            }
        }
    }
}
