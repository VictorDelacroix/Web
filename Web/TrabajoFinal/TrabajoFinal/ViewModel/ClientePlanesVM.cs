using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TrabajoFinal.Model;

namespace TrabajoFinal.ViewModel
{
    public class ClientePlanesVM
    {
        public List<ClientePlan> lstClientePlanes { get; set; }

        public void Fill(int ID)
        {
            GymUPCEntities context = new GymUPCEntities();
            var query = context.ClientePlan.Where(x => x.IDCliente == ID);
            /* GG Vincenzo */
            var lista = from ClientePlan in context.ClientePlan
                        join Planes in context.Planes on ClientePlan.IDPlan equals Planes.IDPlan
                        join Cliente in context.Cliente on ClientePlan.IDCliente equals Cliente.IDCliente
                        where Cliente.IDCliente == ID
                        select new
                        {
                            Cliente = Cliente.IDCliente,
                            Nombre = Cliente.Nombre,
                            NombrePlan = Planes.Nombre,
                            Mes = ClientePlan.Mes,
                            Dia = ClientePlan.Dia,
                            Pago = Planes.Precio
                        };


            /* Hasta aca papuh */
            lstClientePlanes = query.ToList();
            
        }

        public void FillAll()
        {
            GymUPCEntities context = new GymUPCEntities();
            var query = context.ClientePlan.AsQueryable();
            lstClientePlanes = query.ToList();
        }
    }
}