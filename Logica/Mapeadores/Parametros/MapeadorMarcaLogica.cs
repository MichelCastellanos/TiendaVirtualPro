using AccesoDeDatos.DbModel;
using AccesoDeDatos.modelos;
using Logica.DTO.Parametros;
using Logica.Mapeadores.Parametros;
using System.Collections.Generic;

namespace Logica.Mapeadores.Parametros
{
    public class MapeadorMarcaLogica : MapeadorBaseLogica<MarcaDbModel, MarcaDTO>
    {
        public override MarcaDTO MapearTipo1Tipo2(MarcaDbModel entrada)
        {
            return new MarcaDTO()
            {
                Id = entrada.Id,
                Nombre = entrada.Nombre
            };
        }

        public override IEnumerable<MarcaDTO> MapearTipo1Tipo2(IEnumerable<MarcaDbModel> entrada)
        {
            foreach(var item in entrada)
            {
                yield return MapearTipo1Tipo2(item);
            }
            
        }

        public override MarcaDbModel MapearTipo2Tipo1(MarcaDTO entrada)
        {
            return new MarcaDbModel()
            {
                Id = entrada.Id,
                Nombre = entrada.Nombre
            };
        }

        public override IEnumerable<MarcaDbModel> MapearTipo2Tipo1(IEnumerable<MarcaDTO> entrada)
        {
            foreach (var item in entrada)
            {
                yield return MapearTipo2Tipo1(item);
            }
        }
    }
}