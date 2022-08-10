using Logica.DTO.Parametros;
using System.Collections.Generic;
using TiendaVirtual.Models.ModelosGUI.Parametros;

namespace TiendaVirtual.Mapeadores.Parametros
{

    public class MapeadorProveedorGUI : MapeadorBaseGUI<ProveedorDTO, ModeloProveedorGUI>
    {
        public override ModeloProveedorGUI MapearTipo1Tipo2(ProveedorDTO entrada)
        {
            return new ModeloProveedorGUI()
            {
                Id = entrada.Id,
                RazonSocial = entrada.RazonSocial,
                Jefe_Cargo = entrada.Jefe_Cargo,
                Direccion = entrada.Direccion,
                Telefono = entrada.Telefono,
                Email = entrada.Email
            };
        }

        public override IEnumerable<ModeloProveedorGUI> MapearTipo1Tipo2(IEnumerable<ProveedorDTO> entrada)
        {
            foreach (var item in entrada)
            {
                yield return MapearTipo1Tipo2(item);
            }

        }

        public override ProveedorDTO MapearTipo2Tipo1(ModeloProveedorGUI entrada)
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

        public override IEnumerable<ProveedorDTO> MapearTipo2Tipo1(IEnumerable<ModeloProveedorGUI> entrada)
        {
            foreach (var item in entrada)
            {
                yield return MapearTipo2Tipo1(item);
            }
        }
    }
}
