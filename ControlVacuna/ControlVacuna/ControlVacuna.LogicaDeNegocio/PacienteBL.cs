using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ControlVacuna.AccesoDatos;

namespace ControlVacuna.LogicaDeNegocio
{
    public class PacienteBL
    {
        public int AgregarPaciente(Paciente pPaciente)
        {
            BDComun.Contexto.Pacientes.Add(pPaciente);

            return BDComun.Contexto.SaveChanges();
        }
        public Paciente BuscarPaciente(Paciente pPaciente)
        {
            return BDComun.Contexto.Pacientes.SingleOrDefault(p => p.Id_Paciente == pPaciente.Id_Paciente);
        }
        public int ModificarPaciente(Paciente pPaciente)
        {
            Paciente tmppaciente = BuscarPaciente(pPaciente);
            tmppaciente.Nombre = pPaciente.Nombre;
            tmppaciente.Apellido = pPaciente.Apellido;
            tmppaciente.Edad = pPaciente.Edad;
            tmppaciente.Direccion = pPaciente.Direccion;

            return BDComun.Contexto.SaveChanges();
        }
        public int EliminarPaciente(Paciente pPaciente)
        {
            Paciente tmppaciente = BuscarPaciente(pPaciente);

            BDComun.Contexto.Pacientes.Remove(pPaciente);

            return BDComun.Contexto.SaveChanges();
        }

        public List<Paciente> ObtenerPacientes()
        {
            return BDComun.Contexto.Pacientes.ToList();
        }
        public List<Paciente> ObtenerPacientesPorNombre(Paciente pPaciente)
        {
            return BDComun.Contexto.Pacientes.Where(p => p.Nombre.Contains(pPaciente.Nombre)).ToList();
        }
    }
}
