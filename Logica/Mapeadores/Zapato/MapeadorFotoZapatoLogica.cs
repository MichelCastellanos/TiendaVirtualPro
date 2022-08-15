using AccesoDeDatos.DbModel.Zapato;
using AccesoDeDatos.Mapeadores;
using Logica.DTO.Zapato;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Mapeadores.Zapato
{
    public class MapeadorFotoZapatoLogica : MapeadorBaseDatos<FotoZapatoDbModel, FotoZapatoDTO>
    {
        public override FotoZapatoDTO MapearTipo1Tipo2(FotoZapatoDbModel entrada)
        {
            return new FotoZapatoDTO()
            {
                Id = entrada.Id,
                NombreFoto = entrada.NombreFoto,
                Id_Zapato = entrada.Id_Zapato
            };
        }

        public override IEnumerable<FotoZapatoDTO> MapearTipo1Tipo2(IEnumerable<FotoZapatoDbModel> entrada)
        {
            foreach (var item in entrada)
            {
                yield return MapearTipo1Tipo2(item);
            }

        }

        public override FotoZapatoDbModel MapearTipo2Tipo1(FotoZapatoDTO entrada)
        {
            return new FotoZapatoDbModel()
            {
                Id = entrada.Id,
                NombreFoto = entrada.NombreFoto,
                Id_Zapato = entrada.Id_Zapato
            };
        }

        public override IEnumerable<FotoZapatoDbModel> MapearTipo2Tipo1(IEnumerable<FotoZapatoDTO> entrada)
        {
            foreach (var item in entrada)
            {
                yield return MapearTipo2Tipo1(item);
            }
        }
    }
}
