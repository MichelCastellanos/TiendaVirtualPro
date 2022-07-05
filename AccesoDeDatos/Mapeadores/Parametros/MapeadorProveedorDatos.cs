using AccesoDeDatos.DbModel.Parametros;
using AccesoDeDatos.modelos;
using System.Collections.Generic;

namespace AccesoDeDatos.Mapeadores.Parametros
{
    public class MapeadorProveedorDatos : MapeadorBaseDatos<tb_Proveedor, ProveedorDbModel>
    {
        public override ProveedorDbModel MapearTipo1Tipo2(tb_Proveedor entrada)
        {
            return new ProveedorDbModel()
            {
                Id = entrada.Id,
                RazonSocial = entrada.RazonSocial,
                Jefe_Cargo=entrada.Jefe_Cargo,
                Direccion= entrada.Direccion,
                Telefono= entrada.Telefono,
                Email = entrada.Email
            };
        }

        public override IEnumerable<ProveedorDbModel> MapearTipo1Tipo2(IEnumerable<tb_Proveedor> entrada)
        {
            foreach(var item in entrada)
            {
                yield return MapearTipo1Tipo2(item);
            }
            
        }

        public override tb_Proveedor MapearTipo2Tipo1(ProveedorDbModel entrada)
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

        public override IEnumerable<tb_Proveedor> MapearTipo2Tipo1(IEnumerable<ProveedorDbModel> entrada)
        {
            foreach (var item in entrada)
            {
                yield return MapearTipo2Tipo1(item);
            }
        }
    }
}