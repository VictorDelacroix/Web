using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TrabajoFinal.Model;

namespace TrabajoFinal.ViewModel
{
    public class EstablecimientosVM
    {
        public List<Establecimiento> LstEstablecimiento { get; set; }
        public void Fill()
        {
            GymUPCEntities context = new GymUPCEntities();
            var query = context.Establecimiento.AsQueryable();
            LstEstablecimiento = query.ToList();
        }
    }
}