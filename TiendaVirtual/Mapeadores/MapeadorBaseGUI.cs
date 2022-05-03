using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TiendaVirtual.Mapeadores
{
    public abstract class MapeadorBaseGUI<Tipo1,Tipo2>
    {
        public abstract Tipo2 MapearTipo1Tipo2(Tipo1 entrada);
        public abstract IEnumerable<Tipo2> MapearTipo1Tipo2(IEnumerable<Tipo1> entrada);
        public abstract Tipo1 MapearTipo2Tipo1(Tipo2 entrada);
        public abstract IEnumerable<Tipo1> MapearTipo2Tipo1(IEnumerable<Tipo2> entrada);
    }
}