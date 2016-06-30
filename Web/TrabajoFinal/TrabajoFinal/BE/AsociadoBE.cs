using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TrabajoFinal.Model;

namespace TrabajoFinal.BE
{
    public class AsociadoBE
    {

        public bool ValidarLogin(string user, string pass)
        {
            try
            {
                GymUPCEntities context = new GymUPCEntities();
                Asociado objAsociado= context.Asociado.FirstOrDefault(x => x.Usuario == user && x.Pass == pass);

                if (objAsociado != null) return true;
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public Asociado getAsociado(string user,string pass)
        {
            GymUPCEntities context = new GymUPCEntities();
            Asociado objAsociado = context.Asociado.FirstOrDefault(x => x.Usuario == user && x.Pass == pass);
            return objAsociado;
        }
    }
}