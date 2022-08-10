using AccesoDeDatos.DbModel.Parametros;
using Logica.DTO.Parametros;
using System.Collections.Generic;

namespace Logica.Mapeadores.Parametros
{
    public class MapeadorProveedorLogica : MapeadorBaseLogica<ProveedorDbModel, ProveedorDTO>
    {
        public override ProveedorDTO MapearTipo1Tipo2(ProveedorDbModel entrada)
        {
            return new ProveedorDTO()
            {
                Id = entrada.Id,
                RazonSocial = entrada.RazonSocial,
                Jefe_Cargo = entrada.Jefe_Cargo,
                Direccion = entrada.Direccion,
                Telefono = entrada.Telefono,
                Email = entrada.Email
            };
        }

        public override IEnumerable<ProveedorDTO> MapearTipo1Tipo2(IEnumerable<ProveedorDbModel> entrada)
        {
            foreach (var item in entrada)
            {
                yield return MapearTipo1Tipo2(item);
            }

        }

        public override ProveedorDbModel MapearTipo2Tipo1(ProveedorDTO entrada)
        {
            return new ProveedorDbModel()
            {
                Id = entrada.Id,
                RazonSocial = entrada.RazonSocial,
                Jefe_Cargo = entrada.Jefe_Cargo,
                Direccion = entrada.Direccion,
                Telefono = entrada.Telefono,
                Email = entrada.Email
            };
        }

        public override IEnumerable<ProveedorDbModel> MapearTipo2Tipo1(IEnumerable<ProveedorDTO> entrada)
        {
            foreach (var item in entrada)
            {
                yield return MapearTipo2Tipo1(item);
            }
        }
    }
}