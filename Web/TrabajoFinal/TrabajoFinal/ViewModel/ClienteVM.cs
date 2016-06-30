using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TrabajoFinal.Model;
using TrabajoFinal.Globalization;

namespace TrabajoFinal.ViewModel
{
    public class ClienteVM
    {

        public List<Cliente> lstClientes { get; set; }

        public void Fill()
        {
            GymUPCEntities context = new GymUPCEntities();
            var query = context.Cliente.AsQueryable();
            lstClientes = query.ToList();

        }



    }
}