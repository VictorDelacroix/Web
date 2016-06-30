using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TrabajoFinal.Model;


namespace TrabajoFinal.BE
{
    public class ClienteBE
    {

        public bool ValidarLogin(string user, string pass)
        {
            try
            {
                GymUPCEntities context = new GymUPCEntities();
                Cliente objCliente = context.Cliente.FirstOrDefault(x => x.Usuario == user && x.Pass == pass);

                if (objCliente != null) return true;
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public Cliente getCliente(string user, string pass)
        {
            GymUPCEntities context = new GymUPCEntities();
            Cliente objCliente= context.Cliente.FirstOrDefault(x => x.Usuario == user && x.Pass == pass);
            return objCliente;
        }
    }
}