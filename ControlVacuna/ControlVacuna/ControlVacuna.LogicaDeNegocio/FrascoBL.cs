using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ControlVacuna.AccesoDatos;

namespace ControlVacuna.LogicaDeNegocio
{
    public class FrascoBL
    {
        public int AgregarFrasco(Frasco pFrasco)
        {
            BDComun.Contexto.Frascoes.Add(pFrasco);

            return BDComun.Contexto.SaveChanges();
        }
        public Frasco BuscarFrasco(Frasco pFrasco)
        {
           return BDComun.Contexto.Frascoes.SingleOrDefault(f => f.Id_Frasco == pFrasco.Id_Frasco);
        }
        public int ModificarFrasco(Frasco pFrasco)
        {
            Frasco tmpFrasco = BuscarFrasco(pFrasco);
            tmpFrasco.Id_Frasco = pFrasco.Id_Frasco;
            tmpFrasco.Fecha_Entrega = pFrasco.Fecha_Entrega;
            tmpFrasco.Fecha_Finalizacion = pFrasco.Fecha_Finalizacion;

            return BDComun.Contexto.SaveChanges();
        }
        public int EliminarFrasco(Frasco pFrasco)
        {
            Frasco tmpFrasco = BuscarFrasco(pFrasco);

            BDComun.Contexto.Frascoes.Remove(pFrasco);

            return BDComun.Contexto.SaveChanges();
        }


        public List<Frasco> ObtenerFrasco()
        {
            return BDComun.Contexto.Frascoes.ToList();
        }
        public List<Frasco> ObtenerFrascoPorFechaEntrega(Frasco pFrasco)
        {
            return BDComun.Contexto.Frascoes.Where(f => f.Fecha_Entrega.Equals(pFrasco.Fecha_Entrega)).ToList();
        }
    }
}
