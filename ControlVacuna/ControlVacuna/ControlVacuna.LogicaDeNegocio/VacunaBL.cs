using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ControlVacuna.AccesoDatos;

namespace ControlVacuna.LogicaDeNegocio
{
    public class VacunaBL
    {
        public int AgregarVacuna(Vacuna pVacuna)
        {
            BDComun.Contexto.Vacunas.Add(pVacuna);

            return BDComun.Contexto.SaveChanges();
        }
        public Vacuna BuscarVacuna(Vacuna pVacuna)
        {
            return BDComun.Contexto.Vacunas.SingleOrDefault(v => v.Id_Vacuna == pVacuna.Id_Vacuna);
        }
        public int ModificarVacuna(Vacuna pVacuna)
        {
            Vacuna tmpVacuna = BuscarVacuna(pVacuna);
            tmpVacuna.Id_Vacuna = pVacuna.Id_Vacuna;
            tmpVacuna.Fecha = pVacuna.Fecha;
            tmpVacuna.Paciente.Nombre = pVacuna.Paciente.Nombre;
            tmpVacuna.Cantidad = pVacuna.Cantidad;
            tmpVacuna.Descripcion = pVacuna.Descripcion;

            return BDComun.Contexto.SaveChanges();
        }
        public int EliminarVacuna(Vacuna pVacuna)
        {
            Vacuna tmpVacuna = BuscarVacuna(pVacuna);


            BDComun.Contexto.Vacunas.Remove(pVacuna);
            return BDComun.Contexto.SaveChanges();
        }
        public List<Vacuna> ObtenerVacunas()
        {
            return BDComun.Contexto.Vacunas.ToList();
        }
        public List<Vacuna> ObtenerVacunaPorFecha(Vacuna pVacuna)
        {
            return BDComun.Contexto.Vacunas.Where(v => v.Fecha == pVacuna.Fecha).ToList();
        }
    //    public List<Vacuna> ObtenerVa(Vacuna _va)
    //{
    //    DateTime dateTimeServer = <DateTime>("SELECT GETDATE() Fecha").SingleOrDefault();
    //    DateTime dateTimeClient = DateTime.Now;
    //}
    }
}
