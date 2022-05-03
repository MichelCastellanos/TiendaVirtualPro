using AccesoDeDatos.modelos;
using System.Collections.Generic;
using TiendaVirtual.Models.ModelosGUI.Parametros;

namespace TiendaVirtual.Mapeadores.Parametros
{
    public class MapeadorProveedorGUI : MapeadorBaseGUI<tb_Proveedor, ModeloProveedorGUI>
    {
        public override ModeloProveedorGUI MapearTipo1Tipo2(tb_Proveedor entrada)
        {
            return new ModeloProveedorGUI()
            {
                Id = entrada.Id,
                RazonSocial = entrada.RazonSocial,
                Jefe_Cargo=entrada.Jefe_Cargo,
                Direccion= entrada.Direccion,
                Telefono= entrada.Telefono,
                Email = entrada.Email
            };
        }

        public override IEnumerable<ModeloProveedorGUI> MapearTipo1Tipo2(IEnumerable<tb_Proveedor> entrada)
        {
            foreach(var item in entrada)
            {
                yield return MapearTipo1Tipo2(item);
            }
            
        }

        public override tb_Proveedor MapearTipo2Tipo1(ModeloProveedorGUI entrada)
        {
            return new tb_Proveedor()
            {
                Id = entrada.Id,
                RazonSocial = entrada.RazonSocial,
                Jefe_Cargo = entrada.Jefe_Cargo,
                Direccion = entrada.Direccion,
                Telefono = entrada.Telefono,
                Email = entrada.Email
            };
        }

        public override IEnumerable<tb_Proveedor> MapearTipo2Tipo1(IEnumerable<ModeloProveedorGUI> entrada)
        {
            foreach (var item in entrada)
            {
                yield return MapearTipo2Tipo1(item);
            }
        }
    }
}