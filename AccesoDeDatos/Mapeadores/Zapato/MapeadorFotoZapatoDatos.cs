using AccesoDeDatos.DbModel.Zapato;
using AccesoDeDatos.modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDeDatos.Mapeadores.Zapato
{
    public class MapeadorFotoZapatoDatos : MapeadorBaseDatos<tb_Foto, FotoZapatoDbModel>
    {
        public override FotoZapatoDbModel MapearTipo1Tipo2(tb_Foto entrada)
        {
            return new FotoZapatoDbModel()
            {
                Id = entrada.Id,
                NombreFoto = entrada.Ruta,
                Id_Zapato = entrada.Id_Zapato
            };
        }

        public override IEnumerable<FotoZapatoDbModel> MapearTipo1Tipo2(IEnumerable<tb_Foto> entrada)
        {
            foreach (var item in entrada)
            {
                yield return MapearTipo1Tipo2(item);
            }

        }

        public override tb_Foto MapearTipo2Tipo1(FotoZapatoDbModel entrada)
        {
            return new tb_Foto()
            {
                Id = entrada.Id,
                Ruta = entrada.NombreFoto,
                Id_Zapato = entrada.Id_Zapato
            };
        }

        public override IEnumerable<tb_Foto> MapearTipo2Tipo1(IEnumerable<FotoZapatoDbModel> entrada)
        {
            foreach (var item in entrada)
            {
                yield return MapearTipo2Tipo1(item);
            }
        }
    }
}