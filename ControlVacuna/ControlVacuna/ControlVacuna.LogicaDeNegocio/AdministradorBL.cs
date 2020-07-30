using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ControlVacuna.AccesoDatos;

namespace ControlVacuna.LogicaDeNegocio
{
    public class AdministradorBL
    {

        public int AgregarAdministrador(Administrador pAdmin)
        {
            if (NickExists(pAdmin.Nick)) return 0;

            BDComun.Contexto.Administradors.Add(pAdmin);

            return BDComun.Contexto.SaveChanges();
        }
        public bool NickExists(string nick)
        {
            return ObtenerAdministradores().Any(n => n.Nick == nick);
        }
        public Administrador BuscarAdministrador(Administrador pAdmin)
        {
            return BDComun.Contexto.Administradors.SingleOrDefault(a => a.Id_Administrador == pAdmin.Id_Administrador);
        }
        public int ModificarAdministrador(Administrador pAdmin)
        {
            Administrador tmpAdministrador = BuscarAdministrador(pAdmin);
            tmpAdministrador.Nombre = pAdmin.Nombre;
            tmpAdministrador.Apellido = pAdmin.Apellido;
            tmpAdministrador.Nick = pAdmin.Nick;
            tmpAdministrador.Pass = pAdmin.Pass;
            tmpAdministrador.Confirmar = pAdmin.Confirmar;

            return BDComun.Contexto.SaveChanges();
        }
        public int EliminarAdministrador(Administrador pAdmin)
        {
            Administrador tmpAdministradores = BuscarAdministrador(pAdmin);

            BDComun.Contexto.Administradors.Remove(pAdmin);

            return BDComun.Contexto.SaveChanges();
        }
        public List<Administrador> ObtenerAdministradores()
        {
            return BDComun.Contexto.Administradors.ToList();
        }
        public List<Administrador> ObtenerAdministradorPorNombre(Administrador pAdmin)
        {
            return BDComun.Contexto.Administradors.Where(a => a.Nombre.Contains(pAdmin.Nombre)).ToList();
        }
        //public List<Administrador> ObtenerNickDeAdmin(Administrador pAdmin)
        //{
        //    return BDComun.Contexto.Administradors.Where(n => n.Nick.Equals(pAdmin.Nick)).ToList();
        //}
        //public bool ValidarAcceso(Administrador pAdmin)
        //{
        //    var usuario = BDComun.Contexto.Administradors.SingleOrDefault(u => u.Nick == pAdmin.Nick);

        //    if (usuario == null) return false;

        //    return usuario.Pass == pAdmin.Pass;
        //}
        public bool ValidarAcceso(Administrador pAdmin)
        {
            var usuario = BDComun.Contexto.Administradors.SingleOrDefault(u => u.Nick == pAdmin.Nick);

            if (usuario == null) return false;

                return usuario.Pass == pAdmin.Pass && usuario.Nick == pAdmin.Nick;            

                //return usuario.Nick == pAdmin.Nick;
            
        }
        //public bool ValidarAcceso(Administrador pAdmin)
        //{
        //    bool Aceptado = false;
        //    string claveBD = "";
        //    var usuario = BDComun.Contexto.Administradors.SingleOrDefault(u => u.Nick == pAdmin.Nick);
        //    if(usuario != null)
        //    {
        //        claveBD = usuario.Pass;
        //        var contra = BDComun.Contexto.Administradors.SingleOrDefault(u => u.Pass == pAdmin.Pass);
        //        if (contra != null)
        //        {
        //            Aceptado = true;
        //        }
        //        else
        //            Aceptado = false;
        //    }
        //    else
        //        Aceptado = false;
        //    return Aceptado;
        //    }
        }
        }
